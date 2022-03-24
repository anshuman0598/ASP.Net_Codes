using Microsoft.AspNetCore.Mvc;

namespace LoginWithSessionInASP.NetCORE.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
