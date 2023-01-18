using BusinessLayer.Concrete;
using DataAcsessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            CategoryMeneger categoryMeneger = new CategoryMeneger(new EfCategoryRepository());
            var value = categoryMeneger.GetListAll();
            return Ok(value);
        }
    }
}
