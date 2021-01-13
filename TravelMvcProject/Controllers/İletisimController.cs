using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelMvcProject.Models.Siniflar;

namespace TravelMvcProject.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim

        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.iletisims.ToList();
            return View(deger);
        }
    }
}