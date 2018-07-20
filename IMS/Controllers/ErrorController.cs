using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult NotFound()
        {
            return View("404");
        }

        public ViewResult InternalServer()
        {
            return View("500");
        }

    }
}