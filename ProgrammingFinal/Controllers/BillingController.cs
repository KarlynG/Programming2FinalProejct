using Microsoft.AspNetCore.Mvc;
using ProgrammingFinal.Core.Enums;
using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Entities;
using ProgrammingFinal.Services.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingFinal.Controllers
{
    public class BillingController : Controller
    {
        private readonly IProductsService _productService;
        private readonly IBillingService _billingService;
        private readonly IStockService _stockService;
        private readonly IClientService _clientservice;
        public BillingController(IProductsService productService, 
            IBillingService billingService, 
            IStockService stockService,
            IClientService clientService)
        {
            _productService = productService;
            _billingService = billingService;
            _stockService = stockService;
            _clientservice = clientService;
        }
        [HttpPost]
        public async Task<IActionResult> FormBilling(string productName, int quantityBought, int clientId)
        {
            bool stockResult = await _stockService.UpdateStock(productName, quantityBought);
            if (!stockResult) return RedirectToAction("BillingView", "Billing");

            Clients client = await _clientservice.GetByIdAsync(clientId);

            int productPrice = await _productService.GetPriceByName(productName);
            int total = (int)GetTotal(client.Category, productPrice, quantityBought);
            bool isPremium = checkIfClientIsPremium(client.Category);

            int discountPremium = 0;
            if (isPremium) discountPremium = (int)(productPrice * 0.05);

            Billing billing = new Billing
            {
                BillingDate = DateTime.Now,
                ProductName = productName,
                QuantityBought = quantityBought,
                ClientName = client.Name,
                PremiumDiscount = discountPremium,
                Itbis = (int)(productPrice * 0.18),
                Total = total
            };
            await _billingService.AddAsync(billing);
            return RedirectToAction("Index", "Home");
        }

        private bool checkIfClientIsPremium(ClientType client)
        {
            return client == 0;
        }

        private double GetTotal(ClientType category, double price, int quantity)
        {
            if (category == 0)
            {
                double discount = price * 0.05;
                price -= discount;
            }
            double itbis = price * 0.18;
            price += itbis;
            return price * quantity;
        }

        public async Task<List<Products>> GetProductsAsyncData()
        {
            var result =  await _productService.GetAllAsync();
            var products = (from s in result select s).ToList();
            return products;
        }
        public async Task<List<Clients>> GetClientsAsyncData()
        {
            var result = await _clientservice.GetAllAsync();
            var clients = (from s in result select s).ToList();
            return clients;
        }
        public IActionResult BillingView()
        {
            dynamic model = new ExpandoObject();
            model.Products = GetProductsAsyncData().Result;
            model.Clients = GetClientsAsyncData().Result;
            return View(model);
        }

        
    }
}
