using System.Web.Http;

namespace ContosoWeb.Api
{
    public class IncidentsApiController : ApiController
    {
        [HttpGet]
        [Route("api/incidents")]
        public IHttpActionResult Get()
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