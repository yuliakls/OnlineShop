using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_PROJECT.Models;

namespace MVC5_PROJECT.ModelBinders
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase A = controllerContext.HttpContext;
            string Fname = A.Request.Form["Customer_FName"];
            string Lname = A.Request.Form["Customer_LName"];
            string PW = A.Request.Form["Customer_PW"];
            string Email = A.Request.Form["Customer_Email"];
            Customer temp = new Customer() { Email = Email, FName = Fname, LName = Lname, PW = PW };
            return temp;
        }
    }
}