using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.Controllers
{
    public class ErrorController : Controller
    {
        private string errorCode;

        public ErrorController(string err){
            errorCode = err;
        }
        // GET: Error
        public ViewResult NotFound() {
            ViewBag.Title = errorCode;
            ViewBag.ErrorCode = errorCode;
            string viewToReturn;
            switch (errorCode){
                case "404":
                    viewToReturn = "404Error";
                    break;
                case "500":
                    viewToReturn = "500Error";
                    break;
                default:
                    viewToReturn = "DefaultError";
                    break;
            }
            return View(viewToReturn);
        }

    }
}