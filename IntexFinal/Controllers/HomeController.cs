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
            int pageSize = 7;

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
        public IActionResult SeverityCalculator()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FullCalculator()
        {
            crash_data cd = new crash_data();
            return View(cd);
        }
        [HttpPost]
        public IActionResult FullCalculator(crash_data cd)
        {
            return View(cd);
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
