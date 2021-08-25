using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingFinal.Test
{
    public class VendorServiceTest : BaseTests
    {
        [Fact]
        public async Task ShouldSaveVendorAsync()
        {
            var vendors = new Vendors { Name = "Juan", PhoneNumber = 123, email = "perez@perez.com" };
            var result = await _vendorService.AddAsync(vendors);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllVendorsAsync()
        {
            var result = await _vendorService.GetAllAsync();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ShouldUpdateVendorAsync()
        {
            var vendor = _vendorService.GetByIdAsync(2);
            vendor.Result.Name = "xd";
            var result = await _vendorService.UpdateAsync(2, vendor.Result);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShoulDeleteVendorByIdAsync()
        {
            var result = await _vendorService.DeleteByIdAsync(1);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetAllVendorDataAsync()
        {
            var result = await _vendorService.GetVendorAsyncData();

            Assert.NotEmpty(result);
        }
    }
}
