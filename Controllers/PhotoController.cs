using Microsoft.AspNetCore.Mvc;

namespace testASP.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
