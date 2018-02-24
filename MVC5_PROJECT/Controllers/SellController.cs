using MVC5_PROJECT.Controllers.DAL;
using MVC5_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_PROJECT.Controllers
{
    public class SellController : Controller
    {
        // GET: Sell
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult Submit()
        {

            EntityContext dal = new EntityContext();
            Sell A = new Sell();
            A.Customer_ID = int.Parse(Session["ID"].ToString());
            A.Product_ID = int.Parse(Session["ProdID"].ToString());
            A.Price = float.Parse(Session["Price"].ToString());
            ModelState.Clear();
            TryValidateModel(A);
            if (ModelState.IsValid)
            {

                dal.Sells.Add(A);
                dal.SaveChanges();
                return RedirectToRoute("");

            }
            else
                return RedirectToRoute("");





        }


        public ActionResult GetSellsByJson()
        {
          
            int id = int.Parse(Session["ID"].ToString());
            EntityContext dal = new EntityContext();
            //List<Customer> temp = (from u in dal.Customers where (u.Email == A.Email) select u).ToList<Customer>();
            List<Sell> A = (from x in dal.Sells where (x.Customer_ID == id) select x).ToList<Sell>();
             return Json(A, JsonRequestBehavior.AllowGet);
        }
    }
}