using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();

        public IActionResult Index()
        {
            var people = db.People.ToList();
            return View(people);
        }

        public IActionResult Create(int id)
        {
            ViewBag.ExperienceId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            //var id = @ViewBag.ExperienceId; 
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Details", "Experiences", new {id = person.ExperienceId});
        }

        public IActionResult Edit(int id)
        {
            var thisPerson = db.People.FirstOrDefault(person => person.PersonId == id);
           
            return View(thisPerson);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details", "Experiences", new { id = person.ExperienceId });
        }

   

  
        public IActionResult Delete(int id)
        {
            var thisPerson = db.People.FirstOrDefault(person => person.PersonId == id);
            var thisExperience = thisPerson.ExperienceId;
            db.People.Remove(thisPerson);
            db.SaveChanges();
            return RedirectToAction("Details", "Experiences", new { id = thisPerson.ExperienceId });
        }
    }
}
