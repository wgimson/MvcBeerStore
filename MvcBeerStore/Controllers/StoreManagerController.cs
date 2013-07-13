using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBeerStore.Models;

namespace MvcBeerStore.Controllers
{ 
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private BeerStoreEntities db = new BeerStoreEntities();

        //
        // GET: /StoreManager/

        public ViewResult Index()
        {
            var beers = db.Beers.Include(b => b.Style).Include(b => b.Brewery);
            return View(beers.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ViewResult Details(int id)
        {
            Beer beer = db.Beers.Find(id);
            return View(beer);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.StyleId = new SelectList(db.Styles, "StyleId", "Name");
            ViewBag.BreweryId = new SelectList(db.Breweries, "BreweryId", "Name");
            return View();
        } 

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult Create(Beer beer)
        {
            if (ModelState.IsValid)
            {
                db.Beers.Add(beer);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.StyleId = new SelectList(db.Styles, "StyleId", "Name", beer.StyleId);
            ViewBag.BreweryId = new SelectList(db.Breweries, "BreweryId", "Name", beer.BreweryId);
            return View(beer);
        }
        
        //
        // GET: /StoreManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Beer beer = db.Beers.Find(id);
            ViewBag.StyleId = new SelectList(db.Styles, "StyleId", "Name", beer.StyleId);
            ViewBag.BreweryId = new SelectList(db.Breweries, "BreweryId", "Name", beer.BreweryId);
            return View(beer);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Beer beer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StyleId = new SelectList(db.Styles, "StyleId", "Name", beer.StyleId);
            ViewBag.BreweryId = new SelectList(db.Breweries, "BreweryId", "Name", beer.BreweryId);
            return View(beer);
        }

        //
        // GET: /StoreManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Beer beer = db.Beers.Find(id);
            return View(beer);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Beer beer = db.Beers.Find(id);
            db.Beers.Remove(beer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}