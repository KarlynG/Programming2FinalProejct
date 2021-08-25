using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IEntriesService : IBaseService<Entries>
    {
        Task<List<Entries>> GetEntriesAsyncData();
    }
    public class EntriesService : BaseService<Entries>, IEntriesService
    {
        public EntriesService(IEntriesRepository repository) : base(repository)
        {
        }
        public async Task<List<Entries>> GetEntriesAsyncData()
        {
            IEnumerable<Entries> entries = await GetAllAsync();
            List<Entries> result = (from s in entries select s).ToList();
            return result;
        }
    }
}
