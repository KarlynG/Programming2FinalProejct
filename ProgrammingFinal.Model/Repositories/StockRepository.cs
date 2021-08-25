using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IStockRepository : IBaseRepository<Stock> { }
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public StockRepository(ProgrammingFinalContext context) : base(context)
        {
        }
    }
}
