using EFCore_Tekrar.Models.Context;
using EFCore_Tekrar.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_Tekrar.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;

        public CategoryController(MyContext db) //MiddleWare'de bu tanımlamayı yaptığımız için direkt instance alıyor
        {
            _db = db;
        }

        public IActionResult GetCategories()
        {
            return View(_db.Categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateCategory(Category item)
        {
            _db.Categories.Add(item);
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        public IActionResult UpdateCategory(int id)
        {
            return View(_db.Categories.Find(id));
        
        }

        [HttpPost]

        public IActionResult UpdateCategory(Category item)
        {
            Category original = _db.Categories.Find(item.ID);
            original.CategoryName = item.CategoryName;
            original.Description = item.Description;
            original.ModifiedDate = DateTime.Now;
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        public IActionResult DeleteCategory(int id) 
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

    }
}
