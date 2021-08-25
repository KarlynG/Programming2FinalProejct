using Microsoft.EntityFrameworkCore;
using ProgrammingFinal.Model.Contexts;
using ProgrammingFinal.Model.Repositories;
using ProgrammingFinal.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Test
{
    public class BaseTests
    {
        protected readonly IClientService _clientService;
        protected readonly IProductsService _productService;
        protected readonly IVendorsService _vendorService;
        public BaseTests()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProgrammingFinalContext>();
            optionsBuilder.UseInMemoryDatabase("ProgrammingContextTest");
            var context = new ProgrammingFinalContext(optionsBuilder.Options);

            context.Clients.Add(new Model.Entities.Clients
            {
                Name = "Karlyn",
                Document = 123,
                PhoneNumber = 123,
                Email = "karlyn@hotmail.com",
                Category = Core.Enums.ClientType.REGULAR
            });

            context.Clients.Add(new Model.Entities.Clients
            {
                Name = "Karlyn2",
                Document = 1234,
                PhoneNumber = 1234,
                Email = "karlyn@hotmail.com",
                Category = Core.Enums.ClientType.PREMIUM
            });

            context.Products.Add(new Model.Entities.Products
            {
                Name = "Crotolamo",
                Price = 1000
            });

            context.Products.Add(new Model.Entities.Products
            {
                Name = "Uxiono",
                Price = 500
            });

            context.Vendors.Add(new Model.Entities.Vendors
            {
                Name = "Juan Perez",
                PhoneNumber = 12345,
                email = "juan@juan.com"
            });

            context.Vendors.Add(new Model.Entities.Vendors
            {
                Name = "Maria Jose",
                PhoneNumber = 54321,
                email = "marioa@maria.com"
            });

            context.SaveChanges();

            var clientRepository = new ClientsRepository(context);
            var productRepository = new ProductsRepository(context);
            var vendorRepository = new VendorsRepository(context);

            _clientService = new ClientService(clientRepository);
            _productService = new ProductsService(productRepository);
            _vendorService = new VendorsService(vendorRepository);
        }
    }
}
