using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
        
        //GET
        public IActionResult Create()
        {
            return View();
        }
    }
}
