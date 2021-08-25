using ProgrammingFinal.Model.Contexts;
using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IClientRepository : IBaseRepository<Clients> {}
    public class ClientsRepository : BaseRepository<Clients>, IClientRepository
    {
        public ClientsRepository(ProgrammingFinalContext context) : base(context)
        {
        }
    }
}
