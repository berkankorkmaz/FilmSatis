using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilmSatis.Controllers
{
    public class YoungController : Controller
    {
        // GET: Young
        [OnlyYoungAndAdmin] 
        public ActionResult Index()
        {
            return View();
        }
    }
}