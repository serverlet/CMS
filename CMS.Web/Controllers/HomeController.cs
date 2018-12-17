using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Test()
        {
            throw new Exception("测试");
        }

        public ActionResult NotFound()
        {
            return Content("抱歉我们没有找到该页面！");
        }
    }
}