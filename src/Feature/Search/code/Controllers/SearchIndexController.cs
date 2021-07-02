using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecorePoweredBlog.Feature.Search.Controllers
{
    public class SearchIndexController : Controller
    {
        // GET: SearchIndex
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            var item = Sitecore.Context.Database.GetItem("{DBB9D18E-6214-4126-8746-87FC5493771C}");
            string str = item.Fields["ButtonLabel"].Value;
            string search = item.Fields["HighlighterText"].Value;
            // Logic
            // Debugging - Being The Detective In a Crime Movie Where You Are Also The Murderer.
            return View(item);
        }
    }
}
