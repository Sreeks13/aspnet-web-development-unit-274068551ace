using Microsoft.AspNetCore.Mvc;

namespace ContosoWeb.Api
{
    [ApiController]
    [Route("api/incidents")]
    public class IncidentsApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var incidents = new[]
            {
                new
                {
                    Station = "Central",
                    Incident = "Fire",
                    Status = "Active"
                },
                new
                {
                    Station = "North",
                    Incident = "Medical",
                    Status = "Closed"
                }
            };

            return Ok(incidents);
        }
    }
}