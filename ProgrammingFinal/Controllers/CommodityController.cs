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
    public class CommodityController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IStockService _stockService;
        private readonly IVendorsService _vendorService;
        private readonly IEntriesService _entriesService;

        public CommodityController(
            IProductsService productsService, 
            IStockService stockService, 
            IVendorsService vendorsService,
            IEntriesService entriesService)
        {
            _productsService = productsService;
            _stockService = stockService;
            _vendorService = vendorsService;
            _entriesService = entriesService;
        }
        public async Task<List<Products>> GetProductAsyncData()
        {
            IEnumerable<Products> products = await _productsService.GetAllAsync();
            var result = (from s in products select s).ToList();
            return result;

        }
        public async Task<List<Vendors>> GetVendorAsyncData()
        {
            IEnumerable<Vendors> vendor = await _vendorService.GetAllAsync();
            var result = (from s in vendor  select s).ToList();
            return result;
        }
        [HttpPost]
         public async Task<IActionResult> FormCommodity(string productName, int vendorId, int quantity)
         {
            bool result = await _stockService.UpdateStock(productName, quantity);
            if (!result) return RedirectToAction("AddCommodity", "Commodity");

            Entries entry = new Entries { ProductName = productName, VendorId = vendorId, Quantity = quantity, DateAdded = DateTime.Now };
            await _entriesService.AddAsync(entry);
            return RedirectToAction("Index", "Home");
         }
        public IActionResult AddCommodity()
        {
            dynamic model = new ExpandoObject();
            model.Products = GetProductAsyncData().Result;
            model.Vendors = GetVendorAsyncData().Result;
            return View(model);
        }
    }
}
