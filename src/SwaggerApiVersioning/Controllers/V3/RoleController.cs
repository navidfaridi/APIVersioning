using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiVersioning.Controllers.V3
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("3.0")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { api = "version 3" });
        }

    }
}
