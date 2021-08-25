using ProgrammingFinal.Model.Entities;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IVendorsService : IBaseService<Vendors>
    {
        Task<List<Vendors>> GetVendorAsyncData();
    }
    public class VendorsService : BaseService<Vendors>, IVendorsService
    {
        public VendorsService(IVendorsRepository repository) : base(repository)
        {
        }

        public async Task<List<Vendors>> GetVendorAsyncData()
        {
            IEnumerable<Vendors> vendor = await GetAllAsync();
            List<Vendors> result = (from s in vendor select s).ToList();
            return result;
        }
    }
}
