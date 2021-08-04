using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture1.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
