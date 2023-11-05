using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiVersioning.Controllers.V2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { api = "version 2" });
        }
    }
}
