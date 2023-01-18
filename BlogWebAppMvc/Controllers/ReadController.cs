using Microsoft.AspNetCore.Mvc;

namespace BlogWebAppMvc.Controllers
{
    public class ReadController : Controller
    {
        //Aciqlama posto kodlarla
        public IActionResult Index()
        {
            return View();
        } 
        //Aciqlama postu yazilarla
        public IActionResult Index2()
        {
            return View();
        }  
        //Duyuru postu
        public IActionResult Index3()
        {
            return View();
        }

    }
}
