using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Home(string[] args)
        {
            return View();
        }
    }
}