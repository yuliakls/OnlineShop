using MVC5_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_PROJECT.Controllers.DAL;
using System.Web.Security;

namespace MVC5_PROJECT.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Authenticate(User A)
        {

            EntityContext dal = new EntityContext();
            if (ModelState.IsValid)
            {
                List<User> Temp = (from u in dal.Users where (u.Email == A.Email) && (u.PW == A.PW) select u).ToList<User>();
                if (Temp.Count == 1)
                {// User Authenticated

                    FormsAuthentication.SetAuthCookie("cookie", false);

                    //-------------------my code-----------------


                    List<Customer> custs = (from u in dal.Customers where (u.Email == A.Email) select u).ToList<Customer>();
                    if (custs.Count == 1)
                    {


                        Session["Name"] = custs[0].FName;
                        Session["ID"] = custs[0].ID;
                        Session["Manager"] = Temp[0].Manager.ToString();


                    }
                    //-------------------------------------------


                    return RedirectToAction("ShowHomePage", "Home");

                }
                else
                {
                    return View("Login", A);
                }


            }
            else
                return View("Login", A);



        }

        public ActionResult Logout()
        {
            Session["Manager"] = null;
            Session["Name"] = null;
            //FormsAuthentication.SetAuthCookie("cookie", false);
            FormsAuthentication.SignOut();

            return RedirectToAction("ShowHomePage", "Home");

        }
    }
}