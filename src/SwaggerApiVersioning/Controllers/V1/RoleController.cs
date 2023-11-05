using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApiVersioning.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { api="version 1" });
        }

    }
}
