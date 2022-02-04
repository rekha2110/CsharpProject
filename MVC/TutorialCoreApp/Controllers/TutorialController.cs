using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCoreApp.Models;

namespace TutorialCoreApp.Controllers
{
    public class TutorialController : Controller
    {
        TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;               
        }
        public IActionResult Index()
        {
            var tutorialList = _tutorialDbContext.tutorial.ToList();

            return View(tutorialList);
        }
        public IActionResult TutorialEntry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TutorialEntry(Tutorial tutorial)
        {
            _tutorialDbContext.tutorial.Add(tutorial);
            _tutorialDbContext.SaveChanges();
            ViewBag.message = "Tutorial details saves successfully";
            return View();
        }
        public IActionResult Edit(int Id)
        {
            return View();
        }
        public IActionResult Delete(int Id)
        {
            return View();
        }
    }
}
