﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TravelBlog.Controllers
{
    public class ExperiencesController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            var experienceList = db.Experiences
                                   .Include(experience => experience.Location)
                                   .ToList();
            return View(experienceList);

        }

        public IActionResult Create(int id)
        {
            ViewBag.LocationId = id;

          
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Details", "Locations", new {id = experience.LocationId});
        }

        public IActionResult Details(int id)
        {
            var thisExperience = db.Experiences.Include(experience => experience.Location)
                                   .Include(experience => experience.People)
                                   .FirstOrDefault(experience => experience.ExperienceId == id);
            return View(thisExperience);
        }

        public IActionResult Delete(int id)
        {
			var thisExperience = db.Experiences.FirstOrDefault(experience => experience.ExperienceId == id);
            return View(thisExperience);
            
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experience => experience.ExperienceId == id);
            var locationId = thisExperience.LocationId;
            db.Experiences.Remove(thisExperience);
            db.SaveChanges();
            return RedirectToAction("Details", "Locations", new { id = locationId });
        }

        public IActionResult Edit(int id)
        {
            var thisExperience = db.Experiences.Include(experience => experience.Location)
                                   .FirstOrDefault(experience => experience.ExperienceId == id);
            return View(thisExperience);
        }

        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            db.Entry(experience).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details", new { id = experience.ExperienceId});
        }
    }
}
