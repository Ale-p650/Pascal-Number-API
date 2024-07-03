using Microsoft.AspNetCore.Mvc;
using WebApplication2.Logica;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PascalController : Controller
    {
        [HttpGet]
        public string Get(int num)
        {
            return PascalCSV.Generate(num);
        }
    }
}
