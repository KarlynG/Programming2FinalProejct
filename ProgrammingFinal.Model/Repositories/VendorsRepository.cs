using ProgrammingFinal.Model.Contexts;
using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IVendorsRepository : IBaseRepository<Vendors> {}
    public class VendorsRepository : BaseRepository<Vendors>, IVendorsRepository
    {
        public VendorsRepository(ProgrammingFinalContext context) : base(context)
        {
        }
    }
}
