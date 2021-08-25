using Microsoft.AspNetCore.Mvc;
using ProgrammingFinal.Models;
using ProgrammingFinal.Services.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProgrammingFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IClientService _clientService;
        private readonly IVendorsService _vendorService;
        private readonly IBillingService _billingService;
        private readonly IEventLogService _eventLogService;

        public HomeController(
            IProductsService productService,
            IClientService clientService,
            IVendorsService vendorService,
            IBillingService billingService,
            IEventLogService eventLogService)
        {
            _productsService = productService;
            _clientService = clientService;
            _vendorService = vendorService;
            _billingService = billingService;
            _eventLogService = eventLogService;
        }

        public async Task<IActionResult> Index()
        {
            var client = await _clientService.GetClientAsyncData();
            var product = await _productsService.GetProductAsyncData();
            var vendor = await _vendorService.GetVendorAsyncData();
            var billing = await _billingService.GetBillingAsyncData();
            var eventLogs = await _eventLogService.GetEventLogAsyncData();

            ViewBag.Clients =  client.Count;
            ViewBag.Products = product.Count;
            ViewBag.Vendor = vendor.Count;
            ViewBag.Billing = billing.Count;

            return View(eventLogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
