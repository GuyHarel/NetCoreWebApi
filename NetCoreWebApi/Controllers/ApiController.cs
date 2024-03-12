using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api")]
        [Authorize]
        public ActionResult Get()
        {
            var test = 123;
            return new JsonResult(new { statut = "NetCoreWebApi - ok" });
        }


        [HttpGet]
        [Route("api/test")]
        [AllowAnonymous]
        public ActionResult GetTest()
        {
            var test = 123;
            return new JsonResult(new { statut = "NetCoreWebApi - ok" });
        }

    }
}
