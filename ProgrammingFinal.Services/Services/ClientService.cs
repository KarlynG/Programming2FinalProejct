using ProgrammingFinal.Model.Entities;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IClientService : IBaseService<Clients>
    {
        Task<List<Clients>> GetClientAsyncData();
    }
    public class ClientService : BaseService<Clients>, IClientService
    {
        
        public ClientService(IClientRepository repository) : base(repository)
        {
        }

        public async Task<List<Clients>> GetClientAsyncData()
        {
            IEnumerable<Clients> clients = await GetAllAsync();
            List<Clients> result = (from s in clients select s).ToList();
            return result;
        }
    }
}
