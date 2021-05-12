using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rocky.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rocky.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>
            {
                new Category() { Id = 1, Name = "First category" },
                new Category() { Id = 2, Name = "Second category" },
                new Category() { Id = 3, Name = "Third category" }
            };
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
