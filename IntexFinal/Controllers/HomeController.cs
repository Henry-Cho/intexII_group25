using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IntexFinal.Models;
using IntexFinal.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IntexFinal.Controllers
{
    public class HomeController : Controller
    {
        private ICrashRepository repo;

        public HomeController(ICrashRepository context)
        {
            repo = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Incidents(int pageNum = 1)
        {
            int pageSize = 20;

            var x = new IncidentsViewModel
            {
                Incidents = repo.Crash_Data
                .OrderByDescending(x => x.crash_datetime)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumIncidents = repo.Crash_Data.Count(),
                    IncidentsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(crash_data c)
        {
            repo.CreateCrashData(c);
            return RedirectToAction("Incidents");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
