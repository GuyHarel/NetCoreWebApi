using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(new { statut = "ok" });
        }
    }
}