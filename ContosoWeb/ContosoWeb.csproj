using Microsoft.AspNetCore.Mvc;
using ContosoWeb.Api;
using Xunit;

namespace ContosoWeb.Tests
{
    public class IncidentsApiTests
    {
        [Fact]
        public void Get_ReturnsOk()
        {
            var controller = new IncidentsApiController();

            var result = controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }
    }
}