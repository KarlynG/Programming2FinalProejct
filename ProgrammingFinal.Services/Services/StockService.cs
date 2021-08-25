using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IStockService : IBaseService<Stock> {
        Task<bool> UpdateStock(string productName, int quantityBought);
        Task<List<Stock>> GetStockAsyncData();
    }
    public class StockService : BaseService<Stock>, IStockService
    {
        public StockService(IStockRepository repository) : base(repository)
        {
        }

        public async Task<bool> UpdateStock(string productName, int quantityBought)
        {
            IEnumerable<Stock> stock = await GetAllAsync();
            var result = (from s in stock where s.ProductName == productName select s).ToList();
            
            bool haveEnoughStock = StockIsLessThanBought(quantityBought, result);
            if (!haveEnoughStock) return false;

            Stock newStock = GetByIdAsync(result[0].Id).Result;
            newStock.Quantity = result[0].Quantity - quantityBought;
            var updateResult = await UpdateAsync(result[0].Id, newStock);
            return true;
        }

        private bool StockIsLessThanBought(int quantityBought, List<Stock> stock)
        {
            return stock[0].Quantity > quantityBought;
        }
        public async Task<List<Stock>> GetStockAsyncData()
        {
            IEnumerable<Stock> products = await GetAllAsync();
            List<Stock> result = (from s in products select s).ToList();
            return result;
        }
    }
}
