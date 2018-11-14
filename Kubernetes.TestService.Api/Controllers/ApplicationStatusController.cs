using Microsoft.AspNetCore.Mvc;

namespace Kubernetes.TestService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationStatusController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> Get()
        {
            return Ok();
        }
    }
}
