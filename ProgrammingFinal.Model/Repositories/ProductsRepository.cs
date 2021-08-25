using ProgrammingFinal.Model.Contexts;
using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IProductsRepository : IBaseRepository<Products> {}
    public class ProductsRepository : BaseRepository<Products>, IProductsRepository
    {
        public ProductsRepository(ProgrammingFinalContext context): base(context)
        {
        }
    }
}
