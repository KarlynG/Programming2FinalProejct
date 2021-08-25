using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingFinal.Test
{
    public class ClientServiceTest : BaseTests
    {
        [Fact]
        public async Task ShouldSaveClientAsync()
        {
            var client = new Clients { Name = "Juan", Category = Core.Enums.ClientType.PREMIUM, Document = 123 };
            var result = await _clientService.AddAsync(client);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllClientsAsync()
        {
            var result = await _clientService.GetAllAsync();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ShouldUpdateClientAsync()
        {
            var client = _clientService.GetByIdAsync(2);
            client.Result.Name = "Juan";
            var result = await _clientService.UpdateAsync(2, client.Result);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShoulDeleteClientByIdAsync()
        {
            var result = await _clientService.DeleteByIdAsync(1);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllClientDataAsync()
        {
            var result = await _clientService.GetClientAsyncData();

            Assert.NotEmpty(result);
        }
    }
}
