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
    public class TablesController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IClientService _clientService;
        private readonly IVendorsService _vendorService;
        private readonly IStockService _stockService;
        private readonly IEntriesService _entryService;
        private readonly IBillingService _billingService;

        public TablesController(
            IProductsService productService,
            IClientService clientService,
            IVendorsService vendorService,
            IStockService stockService,
            IEntriesService entryService,
            IBillingService billingService)
        {
            _productsService = productService;
            _clientService = clientService;
            _vendorService = vendorService;
            _stockService = stockService;
            _entryService = entryService;
            _billingService = billingService;
        }
        #region Client
        [HttpPost]
        public async Task<IActionResult> ClientFiltered(int option, string clientName, string category)
        {
            IEnumerable<Clients> clients = await _clientService.GetAllAsync();
            List<Clients> result = new List<Clients>();
            if (option == 0)
            {
                result = (from s in clients where s.Name == clientName select s).ToList();
            }
            else if (option == 1)
            {
                ClientType categoryFilter = ClientType.PREMIUM;
                if (category.ToLower() == "regular")
                {
                    categoryFilter = ClientType.REGULAR;
                }
                result = (from s in clients where s.Category == categoryFilter select s).ToList();
            }

            return View("Client", result);
        }
        #endregion
        #region Product & Stock
        [HttpPost]
        public async Task<IActionResult> ProductFiltered(string productName)
        {
            IEnumerable<Products> products = await _productsService.GetAllAsync();
            List<Products> result = (from s in products where s.Name == productName select s).ToList();

            dynamic model = new ExpandoObject();
            model.Products = result;
            model.Stocks = await  _stockService.GetStockAsyncData();
            return View("Product", model);
        }
        #endregion
        #region Vendor
        [HttpPost]
        public async Task<IActionResult> VendorFiltered(int option, string vendorName, string email)
        {
            IEnumerable<Vendors> vendor = await _vendorService.GetAllAsync();
            List<Vendors> result = new List<Vendors>();
            if (option == 0)
            {
                result = (from s in vendor where s.Name == vendorName select s).ToList();
            }
            else if (option == 1)
            {
                result = (from s in vendor where s.email == email select s).ToList();
                
            }
            return View("Vendor", result);
        }
        
        #endregion
        #region Entries
        [HttpPost]
        public async Task<IActionResult> EntryFiltered(
            int option, 
            string productName, 
            DateTime date, 
            int vendorId, 
            int extraOptions)
        {
            IEnumerable<Entries> entries = await _entryService.GetAllAsync();
            IEnumerable<Vendors> vendor = await _vendorService.GetAllAsync();
            List<Entries> result = new List<Entries>();
            List<Vendors> otherResult = new List<Vendors>();
            dynamic model = new ExpandoObject();
            switch (option)
            {
                case 0:
                    {
                        result = (from s in entries where s.ProductName == productName select s).ToList();
                        break;
                    }

                case 1:
                    {
                        result = (from s in entries where s.DateAdded == date select s).ToList();
                        break;
                    }

                case 2:
                    {
                        result = (from s in entries where s.VendorId == vendorId select s).ToList();
                        otherResult = (from s in vendor where s.Id == vendorId select s).ToList();

                        ViewBag.Options = await ApplyExtraOptions(extraOptions, result[0].ProductName, result[0].Quantity, result.Count, 0);
                        model.Entries = result;
                        model.Vendor = otherResult;
                        return View("Entries", model);
                    }
            }
            ViewBag.Options = await ApplyExtraOptions(extraOptions, result[0].ProductName, result[0].Quantity, result.Count, 0);
            model.Entries = result;
            model.Vendor = vendor;
            return View("Entries", model);
        }
        private async Task<string> ApplyExtraOptions(
            int extraOptions, 
            string productName, 
            int quantity, 
            int count,
            int total)
        {
            switch (extraOptions)
            {
                case 0:
                    return "";
                case 1:
                    string sumatoria = await GetSumatoria(productName, quantity);
                    return "La sumatoria total de los productos comprados es: " + sumatoria;
                case 2:
                    return "El conteo total de registros agregados es: " + count;
                case 3:
                    return "El promedio es: " + total;
                case 4:
                    return "El valor máximo es: " + total;
                case 5:
                    return "El valor mínimo es: " + total;
                default:
                    return "";
            }
        }
        private async Task<string> GetSumatoria(string productName, int quantity)
        {
            int product = await _productsService.GetPriceByName(productName);
            int result = product * quantity;
            return result.ToString();
        }

        
        #endregion
        #region Billing
        [HttpPost]
        public async Task<IActionResult> BillingFiltered(
            int option,
            DateTime date,
            string clientName,
            int extraOptions)
        {
            IEnumerable<Billing> billings = await _billingService.GetAllAsync();
            List<Billing> result = new List<Billing>();
            switch (option)
            {
                case 0:
                    {
                        result = (from s in billings where s.ClientName == clientName select s).ToList();
                        break;
                    }

                case 1:
                    {
                        result = (from s in billings where s.BillingDate == date select s).ToList();
                        break;
                    }
            }
            ViewBag.Options = await ApplyExtraOptions(
                extraOptions, 
                result[0].ProductName, 
                result[0].QuantityBought, 
                result.Count,
                result[0].Total);

            return View("Billings", result);
        }
        #endregion
        #region ClientView
        public async Task<IActionResult> Client()
        {
            return View(await _clientService.GetClientAsyncData());
        }
        
        #endregion
        #region VendorView
        public async Task<IActionResult> Vendor()
        {
            return View(await _vendorService.GetVendorAsyncData());
        }
        
        #endregion
        #region ProductView
        public async Task<IActionResult> Product()
        {
            dynamic model = new ExpandoObject();
            model.Products = await _productsService.GetProductAsyncData();
            model.Stocks = await _stockService.GetStockAsyncData();
            return View(model);
        }
        
        #endregion
        #region EntryView
        public async Task<IActionResult> Entries()
        {
            dynamic model = new ExpandoObject();
            model.Entries = await _entryService.GetEntriesAsyncData();
            model.Vendor = await _vendorService.GetVendorAsyncData();
            return View(model);
        }
        
        #endregion
        #region BillingView
        public async Task<IActionResult> Billings()
        {
            return View(await _billingService.GetBillingAsyncData());
        }
        
        #endregion
    }
}
