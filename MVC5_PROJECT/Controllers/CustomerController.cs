using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_PROJECT.Models;
using MVC5_PROJECT.ModelBinders;
using MVC5_PROJECT.Controllers.DAL;
using System.Web.Security;

namespace MVC5_PROJECT.Controllers
{

    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer A = new Customer { Email = "email", FName = "fname", LName = "lname", PW = "pw" };
            return View("Load",A);
        }

        public ActionResult Register()
        {

            return View(new Customer());
        }

        [HttpPost]
        public ActionResult Submit(Customer A)
        {
            EntityContext dal = new EntityContext();
            //if this email is taken
            if ((from u in dal.Customers where (u.Email == A.Email) select u).ToList<Customer>().Count!=0)
            {
                Session["DuplicateEmail"] = "This Email is already taken, please try another or log in.";
                return View("Register", A);
            }

            if (ModelState.IsValid) //when i new customer is registered User obj insered in User table
            {
                User B = new User { Email = A.Email, PW = A.PW, Manager = false };
                dal.Customers.Add(A);
                dal.SaveChanges();
                dal.Users.Add(B);
                dal.SaveChanges();
                List<Customer> temp=(from u in dal.Customers where (u.Email == A.Email) select u).ToList<Customer>();
                Session["ID"] = temp[0].ID;
                Session["Manager"] = "False";
                Session["Name"] = A.FName;
                Session["DuplicateEmail"] = null;
                FormsAuthentication.SetAuthCookie("cookie", false);
                return RedirectToRoute("");
            }
            else
            {
                Session["DuplicateEmail"] = null;
                return View("Register", A);
            }
        }

        public ActionResult MyPage()
        {

            return View();
        }


    }
}