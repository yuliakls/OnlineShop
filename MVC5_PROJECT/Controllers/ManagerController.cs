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
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Manager_Page()
        {
            return View();
        }

        public ActionResult Customer_List()
        {
            EntityContext dal = new EntityContext();
            CustomerViewModel A = new CustomerViewModel();
            
            A.Cust_List = dal.Customers.ToList<Customer>();
            return View(A);

        }

    }
}