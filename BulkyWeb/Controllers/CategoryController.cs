using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // retrieve from db
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj) { 

            // custom validation
            //if(obj.Name == obj.DisplayOrder.ToString()) {
            //    //AddModelError(ModelField, CustomErrorMessage)
            //    ModelState.AddModelError("Name", "The display order cannot exactly match the name");
            //}

            // test is not related to any property within the model - hence it will show for ModelOnly
            //if (obj.Name != null && obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}

            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

