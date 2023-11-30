
using Microsoft.AspNetCore.Mvc;
using testASP.Models;

namespace testASP.Controllers
{
    public class ContactsController : Controller
    {

        public IActionResult Index()//contacts
        {
            Contact model = new()
            {
                JoiningDate = DateOnly.FromDateTime(DateTime.Today),
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/Photo");
            }
            return View("Index");
        }
    }
}
