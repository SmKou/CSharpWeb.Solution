using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index(string[] args)
        {
            return View();
        }
    }
}
