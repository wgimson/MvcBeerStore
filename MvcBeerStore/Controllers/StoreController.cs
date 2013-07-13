using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBeerStore.Models;

namespace MvcBeerStore.Controllers
{
    public class StoreController : Controller
    {
        private BeerStoreEntities storeDB = new BeerStoreEntities();
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var styles = storeDB.Styles.ToList();
            return View(styles);
        }

        //
        // GET: /Store/Browse
        public ActionResult Browse(string style)
        {
            // Retrieve Style and its associated Beers from database
            var styleModel = storeDB.Styles.Include("Beers").Single(s => s.Name == style);
            return View(styleModel);
        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var beer = storeDB.Beers.Find(id);
            return View(beer);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Styles.ToList();
            return PartialView(genres);
        }
    }
}
