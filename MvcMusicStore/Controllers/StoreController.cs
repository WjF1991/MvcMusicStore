using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            //return View();
            return "hello from Store.index()";
        }

        // GET: Store/Browse?name=1
        public string Browse(int id)
        {
            //return View();
            string message = HttpUtility.HtmlEncode(id);
            return "hello from Store.Browse(), ID：" + message;
        }

        // GET: Store/Details
        public string Details()
        {
            //return View();
            return "hello from Store.Details()";
        }
    }
}