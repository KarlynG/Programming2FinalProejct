using Microsoft.AspNetCore.Mvc;
using ProgrammingFinal.Core.Enums;
using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Entities;
using ProgrammingFinal.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingFinal.Controllers
{
    public class BussinessController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IStockService _stockService;
        private readonly IClientService _clientService;
        private readonly IVendorsService _vendorService;
        private readonly IEventLogService _eventLogService;

        public BussinessController(
            IProductsService productService, 
            IStockService stockService,
            IClientService clientService,
            IVendorsService vendorService,
            IEventLogService eventLogService)
        {
            _stockService = stockService;
            _productsService = productService;
            _clientService = clientService;
            _vendorService = vendorService;
            _eventLogService = eventLogService;
        }

        [HttpPost]
        public async Task<IActionResult> FormProductAsync(string name, int price, int quantity)
        {
            Products product = new Products{ Name = name, Price = price };
            Stock stock = new Stock { ProductName = product.Name, Quantity = quantity };
            EventLog eventLog = new EventLog { 
                Date = DateTime.Now, 
                Entry = "Se ha agregado el producto: " + product.Name + " con un stock de " + quantity
            };

            await _productsService.AddAsync(product);
            await _stockService.AddAsync(stock);
            await _eventLogService.AddAsync(eventLog);

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> FormClientAsync(string name, int document, int phoneNumber, string email, ClientType category)
        {
            Clients client = new Clients { Document = document, Name = name, PhoneNumber = phoneNumber, Email = email, Category = category };
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se ha agregado el cliente: " + client.Name
            };

            await _clientService.AddAsync(client);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public async Task<IActionResult> FormVendorAsync(string name, string document, int phoneNumber, string email)
        {
            Vendors vendor = new Vendors { Name = name, Document = document, PhoneNumber = phoneNumber, email = email };
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se ha agregado el proveedor: " + vendor.Name
            };

            await _vendorService.AddAsync(vendor);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Client()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Vendor()
        {
            return View();
        }
    }
}
