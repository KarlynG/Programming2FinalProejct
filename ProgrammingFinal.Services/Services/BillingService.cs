using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IBillingService : IBaseService<Billing>
    {
        Task<List<Billing>> GetBillingAsyncData();
    }
    public class BillingService : BaseService<Billing>, IBillingService
    {
        public BillingService(IBillingRepository repository) : base(repository)
        {
        }
        public async Task<List<Billing>> GetBillingAsyncData()
        {
            IEnumerable<Billing> billings = await GetAllAsync();
            List<Billing> result = (from s in billings select s).ToList();
            return result;
        }
    }
}
