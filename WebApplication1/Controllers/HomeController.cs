using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //viewBag是字典 可以隨意定義名稱(這邊是message)當變數使用
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetData()
        {
            //return Content("Hi~這邊放json file", "application/json");

            //return File(@"C:\Users\Linting\Desktop\cat.jpg", "image/jpg");

            //jsonresult
            //List<Product> products = new List<Product>();
            ////這邊的products是個容器
            //Product product1 = new Product();
            //product1.Id = 1;
            //product1.Name = "apple";
            //product1.Price = 30;
            //products.Add(product1);

            //Product product2 = new Product();
            //product2.Id = 2;
            //product2.Name = "Samsung";
            //product2.Price = 30;
            //products.Add(product2);

            //Product product3 = new Product();
            //product3.Id = 3;
            //product3.Name = "LG";
            //product3.Price = 30;
            //products.Add(product3);
            //return Json(products, JsonRequestBehavior.AllowGet);

            //redirect  從about到home
            return RedirectToAction("About", "Home");
        }

        [HttpGet]  //actionfilter
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]  //很常用 可以取代if(user.isauthorized...的程式碼)
        [HttpPost]
        public ActionResult Index(string name)
        {
            return View();
        }
    }
}