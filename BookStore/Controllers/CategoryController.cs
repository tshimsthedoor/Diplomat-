using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objectCategory = _db.Categories;
            return View(objectCategory);
        }
        
        //GET
        public IActionResult Create()
        {
            
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            
            return View();
        }
    }
}
