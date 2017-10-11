﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class LocationsController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.Include(locations => locations.Experiences).FirstOrDefault(location => location.LocationId == id);
         
            return View(thisLocation);
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
            return View(thisLocation);
        }
        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details", new {id = location.LocationId});
        }
        public IActionResult Delete(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
            return View(thisLocation);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
            db.Locations.Remove(thisLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
