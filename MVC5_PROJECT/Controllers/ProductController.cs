using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_PROJECT.Models;
using MVC5_PROJECT.Controllers.DAL;
using MVC5_PROJECT.ModelView;

namespace MVC5_PROJECT.Controllers
{


    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ShowProduct()
        {
            ViewModel_Product_Customer A = new ViewModel_Product_Customer(GetProduct(), GetCustomer());
            return View(A);
        }

        private Customer GetCustomer()
        {
            Customer B = new Customer() { Email = "email", FName = "Yulia", LName = "LN", PW = "pw" };
            return B;
        }

        private Product GetProduct()
        {
            Product A = new Product() { Amount = 10, Description = "new product",  Manufacturer = "manufacturer", Name = "cream", Price = 15, Supplier_Price = 8 };
            return A;
        }

        [HttpPost]
        public ActionResult Submit(ProductViewModel A)
        {

            EntityContext dal = new EntityContext();

            ModelState.Clear();
            TryValidateModel(A);
            if (ModelState.IsValid)
            {

                dal.Products.Add(A.Prod);
                dal.SaveChanges();
                A.Prod = new Product();

            }
            else
                A.Prod = new Product();

            A.Prod_List = dal.Products.ToList<Product>();
            return View("AddProduct",A);
        }

        public ActionResult AddProduct()
        {
            EntityContext dal = new EntityContext();
            ProductViewModel A = new ProductViewModel();
            A.Prod = new Product();
            A.Prod_List = dal.Products.ToList<Product>();
            return View(A);
        }
        [Authorize]
        public ActionResult GetProductsByJson() {

            EntityContext dal = new EntityContext();
            ProductViewModel A = new ProductViewModel();
            A.Prod = new Product();
            A.Prod_List = dal.Products.ToList<Product>();
            return Json(A,JsonRequestBehavior.AllowGet);
        }



        public ActionResult Purchase(int ProdID,float Price, string ProdName)
        {
            Session["ProdID"] = ProdID;
            Session["Price"] = Price;
            Session["ProdName"] = ProdName;
            return View();
        }
    }


}