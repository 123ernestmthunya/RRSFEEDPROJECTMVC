using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataLayer;
namespace PresentationLayer.Controllers
{
    public class NewsCategoryController : Controller
    {
        // GET: NewsCategory
        public ActionResult Index()
        {
            return View();
        }
    }
}