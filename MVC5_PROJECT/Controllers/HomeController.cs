using MVC5_PROJECT.Controllers.DAL;
using MVC5_PROJECT.Models;
using MVC5_PROJECT.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.Time = DateTime.Now.ToString(); // Not Saved when redirected
            //ViewData["Time"] = DateTime.Now.ToString(); // Not Saved when redirected
            //TempData["Time"]= DateTime.Now.ToString(); //1 request data only (until view),methods keep/pick for multiple views
            //Session["Time"] = DateTime.Now.ToString(); //multiple requests
            return RedirectToAction("ShowHomePage","Home");

            //return View();
        }

        public ActionResult ShowHomePage()
        {
            EntityContext dal = new EntityContext();
            ProductViewModel A = new ProductViewModel();
            A.Prod = new Product();
            A.Prod_List = dal.Products.ToList<Product>();
            return View(A);

        }


        //public ActionResult Register()
        //{
        //    //ViewData["Time"] = DateTime.Now.ToString();

        //    return RedirectToAction("Register", "Customer");

        //}

        //public ActionResult Submit()
        //{
        //    //ViewData["Time"] = DateTime.Now.ToString();

        //    return RedirectToAction("Submit", "Customer");

        //}


    }
}