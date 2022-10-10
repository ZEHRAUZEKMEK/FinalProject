using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.wwwroot
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase 
    {
        [HttpGet]
        public string Get()
        {
            return "Merhaba";
        }
    }
}
