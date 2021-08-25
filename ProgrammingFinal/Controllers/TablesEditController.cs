using Microsoft.AspNetCore.Mvc;
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
    public class TablesEditController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IClientService _clientService;
        private readonly IVendorsService _vendorService;
        private readonly IStockService _stockService;
        private readonly IEntriesService _entryService;
        private readonly IBillingService _billingService;
        private readonly IEventLogService _eventLogService;
        public TablesEditController(
            IProductsService productService,
            IClientService clientService,
            IVendorsService vendorService,
            IStockService stockService,
            IEntriesService entryService,
            IBillingService billingService,
            IEventLogService eventLogService)
        {
            _productsService = productService;
            _clientService = clientService;
            _vendorService = vendorService;
            _stockService = stockService;
            _entryService = entryService;
            _billingService = billingService;
            _eventLogService = eventLogService;
        }
        #region ClientEdit
        public async Task<IActionResult> ClientEdit(int id)
        {
            Clients client = await _clientService.GetByIdAsync(id);
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> ClientEdit(int id, string name, int phoneNumber, string email, int document)
        {
            Clients client = await _clientService.GetByIdAsync(id);
            client.Name = name;
            client.PhoneNumber = phoneNumber;
            client.Email = email;
            client.Document = document;

            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se editó el cliente: #" + client.Id + ". Nombre actual: " + client.Name
            };

            await _clientService.UpdateAsync(id, client);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Client", "Tables");
        }
        public async Task<IActionResult> DeleteClient(int id)
        {
            Clients client = await _clientService.GetByIdAsync(id);
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se eliminó el cliente: " + client.Name + " Id: " + client.Id
            };

            await _clientService.DeleteByIdAsync(id);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Client", "Tables");
        }
        #endregion
        #region ProductEdit
        [HttpPost]
        public async Task<IActionResult> ProductEdit(int id, string name, int price, int quantity)
        {
            if (quantity != 0)
            {
                IEnumerable<Stock> stock = await _stockService.GetAllAsync();
                int stockProductId = (from s in stock where s.ProductName == name select s.Id).First();
                Stock newStock = await _stockService.GetByIdAsync(stockProductId);
                newStock.Quantity = quantity;
                await _stockService.UpdateAsync(stockProductId, newStock);
            }
            Products products = await _productsService.GetByIdAsync(id);
            products.Name = name;
            products.Price = price;

            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se editó el producto: #" + products.Id + ". Nombre actual: " + products.Name
            };

            await _productsService.UpdateAsync(id, products);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Product", "Tables");
        }
        public async Task<IActionResult> ProductEdit(int id)
        {
            Products product = await _productsService.GetByIdAsync(id);
            return View(product);
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            Products product = await _productsService.GetByIdAsync(id);
            IEnumerable<Stock> result = await _stockService.GetAllAsync();
            List<Stock> otherResult = (from s in result where s.ProductName == product.Name select s).ToList();
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se eliminó el producto: #" + product.Id
            };

            await _productsService.DeleteByIdAsync(id);
            await _stockService.DeleteByIdAsync(otherResult[0].Id);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Product", "Tables");
        }
        #endregion
        #region VendorEdit
        [HttpPost]
        public async Task<IActionResult> VendorEdit(int id, string name, int phoneNumber, string document, string email)
        {
            Vendors vendor = await _vendorService.GetByIdAsync(id);
            vendor.Name = name;
            vendor.PhoneNumber = phoneNumber;
            vendor.Document = document;
            vendor.email = email;

            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se editó el Proveedor: #" + vendor.Id + ". Nombre actual: " + vendor.Name
            };

            await _vendorService.UpdateAsync(id, vendor);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Vendor", "Tables");
        }
        public async Task<IActionResult> VendorEdit(int id)
        {
            Vendors vendor = await _vendorService.GetByIdAsync(id);
            return View(vendor);
        }
        public async Task<IActionResult> DeleteVendor(int id)
        {
            Vendors vendor = await _vendorService.GetByIdAsync(id);
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se eliminó el Proveedor: #" + vendor.Id
            };

            await _vendorService.DeleteByIdAsync(id);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Vendor", "Tables");
        }
        #endregion
        #region EntryEdit
        [HttpPost]
        public async Task<IActionResult> EntryEdit(int id, string productName, int quantity, int vendorId)
        {
            Entries entry = await _entryService.GetByIdAsync(id);
            entry.ProductName = productName;
            entry.Quantity = quantity;
            entry.VendorId = vendorId;

            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se editó la mercancia: #" + entry.Id
            };

            await _entryService.UpdateAsync(id, entry);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Entries", "Tables");
        }
        public async Task<IActionResult> EntryEdit(int id)
        {
            var entry = await _entryService.GetByIdAsync(id);
            dynamic model = new ExpandoObject();
            model.Products = await _productsService.GetProductAsyncData();
            model.Vendors = await _vendorService.GetVendorAsyncData();
            model.Entry = entry;
            return View(model);
        }
        public async Task<IActionResult> DeleteEntry(int id)
        {
            Entries entry = await _entryService.GetByIdAsync(id);
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se eliminó la mercancia: #" + entry.Id
            };

            await _entryService.DeleteByIdAsync(id);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Entries", "Tables");
        }
        #endregion
        #region BillingEdit
        [HttpPost]
        public async Task<IActionResult> BillingsEdit(
            int id,
            string productName,
            int quantityBought,
            int clientId,
            int premiumDiscount,
            int itbis,
            int total)
        {
            Billing billing = await _billingService.GetByIdAsync(id);
            Clients client = await _clientService.GetByIdAsync(clientId);
            billing.ProductName = productName;
            billing.QuantityBought = quantityBought;
            billing.ClientName = client.Name;
            billing.PremiumDiscount = premiumDiscount;
            billing.Itbis = itbis;
            billing.Total = total;

            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se editó la factura: #" + billing.Id
            };

            await _billingService.UpdateAsync(id, billing);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Billings", "Tables");
        }
        public async Task<IActionResult> BillingsEdit(int id)
        {
            Billing billing = await _billingService.GetByIdAsync(id);
            dynamic model = new ExpandoObject();
            model.Products = await _productsService.GetProductAsyncData();
            model.Clients = await _clientService.GetClientAsyncData();
            model.Billing = billing;
            return View(model);
        }
        public async Task<IActionResult> DeleteBilling(int id)
        {
            Billing billing = await _billingService.GetByIdAsync(id);
            EventLog eventLog = new EventLog
            {
                Date = DateTime.Now,
                Entry = "Se eliminó la factura: #" + billing.Id
            };

            await _billingService.DeleteByIdAsync(id);
            await _eventLogService.AddAsync(eventLog);
            return RedirectToAction("Billings", "Tables");
        }
        #endregion
    }
}
