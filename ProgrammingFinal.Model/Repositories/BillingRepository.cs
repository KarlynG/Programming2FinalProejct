using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IBillingRepository : IBaseRepository<Billing> { }
    public class BillingRepository : BaseRepository<Billing>, IBillingRepository
    {
        public BillingRepository(ProgrammingFinalContext context) : base(context)
        {
        }
    }
}
