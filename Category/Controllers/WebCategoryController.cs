using Category.Models;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Mvc;

namespace Category.Controllers
{
    public class WebCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public WebCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.Categories.ToList();
            return View(data);
        }
        public IActionResult Create_Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create_Add(CategoryModel formdata)
        {
            var data = _db.Categories.Add(formdata);
            _db.SaveChanges();
            return View("Index");
        }
        //[HttpPost]
        //public IActionResult Create(CategoryModel FormData)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Categories.Add(FormData);
        //        _db.SaveChanges();
        //        return RedirectToAction();
        //    }
        
    }
}
