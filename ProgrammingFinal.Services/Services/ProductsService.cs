using ProgrammingFinal.Model.Entities;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IProductsService : IBaseService<Products> {
        Task<int> GetPriceByName(string productName);
        Task<List<Products>> GetProductAsyncData();
    }
    public class ProductsService : BaseService<Products>, IProductsService
    {
        public ProductsService(IProductsRepository repository) : base(repository)
        {
        }

        public async Task<int> GetPriceByName(string productName)
        {
            IEnumerable<Products> products = await GetAllAsync();
            int productPrice = (from s in products where s.Name == productName select s.Price).First();
            return productPrice;
        }
        public async Task<List<Products>> GetProductAsyncData()
        {
            IEnumerable<Products> products = await GetAllAsync();
            List<Products> result = (from s in products select s).ToList();
            return result;

        }
    }
}
