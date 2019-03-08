using E_shop.Models;
using E_shop.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_shop.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            var categories = db.Categories.ToList();
           // ViewBag.Categories = categories;

          
            var products = db.Products.Where(p => p.Featured == true).ToList();
            //ViewBag.Products = products;

            var ViewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products
            };
            return View(ViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult SingleProduct(int id)
        {
            var product = db.Products.Where(x => x.Id == id).SingleOrDefault();
            if (product == null)
            {
                return HttpNotFound();
            }

            Category category = db.Categories.Find(product.CategoryID);

            ViewBag.Category = category;
           
            return View(product);
        }
    }
}