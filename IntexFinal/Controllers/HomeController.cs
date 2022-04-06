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
using Newtonsoft.Json;

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

        [HttpGet]
        public IActionResult FilteredIncidents(IQueryable<crash_data> cd, int pageNum = 1)
        {
            int pageSize = 7;

            var c = new IncidentsViewModel
            {
            Incidents = cd
                .OrderByDescending(x => x.crash_datetime)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

            PageInfo = new PageInfo
            {
                TotalNumIncidents = cd.Count(),
                IncidentsPerPage = pageSize,
                CurrentPage = pageNum
            }
            };
            return View(c);
        }

        public IActionResult Incidents(int pageNum = 1)
        {
            //List<crash_data> cd = (List<crash_data>)TempData["record"];
            int pageSize = 7;
            var c = new IncidentsViewModel();

            //if (cd?.Count() == null)
            //{
                c = new IncidentsViewModel
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
            //}
            //else
            //{
            //    cd = (List<crash_data>)cd.AsQueryable();
            //    c = new IncidentsViewModel
            //    {
            //        Incidents = (IQueryable<crash_data>)cd
            //            .OrderByDescending(x => x.crash_datetime)
            //            .Skip((pageNum - 1) * pageSize)
            //            .Take(pageSize),

            //        PageInfo = new PageInfo
            //        {
            //            TotalNumIncidents = cd.Count(),
            //            IncidentsPerPage = pageSize,
            //            CurrentPage = pageNum
            //        }
            //    };
            //    ViewData["record"] = JsonConvert.DeserializeObject<List<crash_data>>((string)TempData["record"]);
            //}

            return View(c);
        }

        [HttpGet]
        public IActionResult Filter()
        {
            var csi = repo.Crash_Data
                .Select(x => x.crash_severity_id)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.crash_severity_id = csi;

            var cn = repo.Crash_Data
                .Select(x => x.county_name)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.county_name = cn;

            var ct = repo.Crash_Data
                .Select(x => x.city)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.city = ct;

            var lux = repo.Crash_Data
                .Select(x => x.long_utm_x)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.long_utm_x = csi;

            var lay = repo.Crash_Data
                .Select(x => x.lat_utm_y)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.lat_utm_y = lay;

            var mrn = repo.Crash_Data
                .Select(x => x.main_road_name)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.main_road_name = mrn;

            var mp = repo.Crash_Data
                .Select(x => x.milepoint)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.milepoint = mp;

            var rt = repo.Crash_Data
                .Select(x => x.route)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.route = rt;

            var cdt = repo.Crash_Data
                .Select(x => x.crash_datetime)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.crash_datetime = cdt;

            return View();
        }

        [HttpPost]
        public IActionResult Filter(crash_data cd)
        {
            var record = repo.GetFiltered(cd.city, cd.county_name, cd.crash_datetime, cd.route, cd.milepoint, cd.main_road_name, cd.lat_utm_y, cd.long_utm_x, cd.crash_severity_id,
                cd.work_zone_related, cd.pedestrian_involved, cd.bicyclist_involved, cd.motorcycle_involved, cd.improper_restraint, cd.unrestrained, cd.dui, cd.intersection_related,
                cd.wild_animal_related, cd.domestic_animal_related, cd.overturn_rollover, cd.commercial_motor_veh_involved,
                cd.teenage_driver_involved, cd.older_driver_involved, cd.night_dark_condition, cd.single_vehicle, cd.distracted_driving, cd.drowsy_driving, cd.roadway_departure);
               
            //TempData["record"] = JsonConvert.SerializeObject(record);
            return RedirectToAction("FilteredIncidents", new { cd = record, pageNum = 1});
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
