using Microsoft.AspNetCore.Mvc;

namespace BlogWebAppMvc.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
