using Microsoft.AspNetCore.Mvc;

namespace LoginWithSessionInASP.NetCORE.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
