using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using scheduleApp.DAL;
using scheduleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace scheduleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() 
        {
            using (var db = new ScheduleDB())
            {
                var model = db.Schedule
                                .Include(x => x.Discipline)
                                .Include(x => x.TimeBegin)
                                .Include(x => x.TimeEnd)
                                .ToList();
                return View(model);
            }
                
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Discipline")]
        public IActionResult GetDisciplineList()
        {
            using (var db = new ScheduleDB())
            {

                var model = db.Discipline.ToList();
                return View("Discipline", model);
            }
        }
        [HttpPost]
        public IActionResult CreateDiscipline(Discipline item)
        {
            using (var db = new ScheduleDB())
            {

                db.Discipline.Add(item);
                db.SaveChanges();

            }
            return Redirect("/Discipline");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
