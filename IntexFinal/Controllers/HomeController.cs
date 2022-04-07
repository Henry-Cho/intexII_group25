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
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.AspNetCore.Http;

namespace IntexFinal.Controllers
{
    public class HomeController : Controller
    {
        private ICrashRepository repo;
        private InferenceSession _session;


        public HomeController(ICrashRepository context, InferenceSession session)
        {
            repo = context;
            _session = session;
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
            int pageSize = 7;
            var c = new IncidentsViewModel();

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


            return View();
        }

        [HttpPost]
        public IActionResult Filter(IFormCollection form )
        {
            string? city = null;
            string? county_name = null;
            int? route = null; 
            double? milepoint = null;
            string? main_road_name = null;
            int? crash_severity_id = null;
            bool? work_zone_related = null;
            bool? pedestrian_involved = null;
            bool? bicyclist_involved = null;
            bool? motorcycle_involved = null;
            bool? improper_restraint = null;

            bool? unrestrained = null;
            bool? dui = null;
            bool? intersection_related = null;
            bool? wild_animal_related = null;
            bool? domestic_animal_related = null;
            bool? overturn_rollover = null;
            bool? commercial_motor_veh_involved = null;

            bool? teenage_driver_involved = null;
            bool? older_driver_involved = null;
            bool? night_dark_condition = null;
            bool? single_vehicle = null;
            bool? distracted_driving = null;
            bool? drowsy_driving = null;
            bool? roadway_departure = null;
        
            var route_temp = form["route"];
            if(route_temp != "null")
            {
                route = Convert.ToInt32(route_temp);
            }
            var milepoint_temp = form["milepoint"];
            if (milepoint_temp != "null")
            {
                milepoint = Convert.ToInt32(milepoint_temp);
            }
            var main_road_temp = form["main_road_name"];
            if (main_road_temp != "null")
            {
                main_road_name = main_road_temp;
            }
            var city_temp = form["city"];
            if (city_temp != "null")
            {
                city = city_temp;
            }
            var crash_severity_temp = form["crash_severity_id"];
            if (crash_severity_temp != "null")
            {
                crash_severity_id = Convert.ToInt32(crash_severity_temp);
            }

            var work_temp = form["work_zone_related"];
            if (work_temp != "null")
            {
                work_zone_related = Convert.ToBoolean(work_temp);
            }
            var pedestrian_temp= form["pedestrian_involved"];
            if (pedestrian_temp != "null")
            {
                pedestrian_involved = Convert.ToBoolean(pedestrian_temp);
            }
            var bicyclist_temp = form["bicyclist_involved"];
            if (bicyclist_temp != "null")
            {
                bicyclist_involved = Convert.ToBoolean(bicyclist_temp);
            }
            var motorcycle_temp = form["motorcycle_involved"];
            if (motorcycle_temp != "null")
            {
                motorcycle_involved = Convert.ToBoolean(motorcycle_temp);
            }
            var improper_temp = form["improper_restraint"];
            if (improper_temp != "null")
            {
                improper_restraint = Convert.ToBoolean(improper_temp);
            }
            var unrestrained_temp = form["unrestrained"];
            if (unrestrained_temp != "null")
            {
                unrestrained = Convert.ToBoolean(unrestrained_temp);
            }
            var dui_temp = form["dui"];
            if (dui_temp != "null")
            {
                dui = Convert.ToBoolean(dui_temp);
            }
            var intersection_temp = form["intersection_related"];
            if (intersection_temp != "null")
            {
                intersection_related = Convert.ToBoolean(intersection_temp);
            }
            var wild_animal_temp = form["wild_animal_related"];
            if (wild_animal_temp != "null")
            {
                wild_animal_related = Convert.ToBoolean(wild_animal_temp);
            }
            var domestic_animal_temp = form["domestic_animal_related"];
            if (domestic_animal_temp != "null")
            {
                domestic_animal_related = Convert.ToBoolean(domestic_animal_temp);
            }
            var overturn_temp = form["overturn_rollover"];
            if (overturn_temp != "null")
            {
                overturn_rollover = Convert.ToBoolean(overturn_temp);
            }
            var commercial_temp = form["commercial_motor_veh_involved"];
            if (commercial_temp != "null")
            {
                commercial_motor_veh_involved = Convert.ToBoolean(commercial_temp);
            }
            var teenage_driver_temp = form["teenage_driver_involved"];
            if (teenage_driver_temp != "null")
            {
                teenage_driver_involved = Convert.ToBoolean(teenage_driver_temp);
            }
            var older_driver_temp = form["older_driver_involved"];
            if (older_driver_temp != "null")
            {
                older_driver_involved = Convert.ToBoolean(older_driver_temp);
            }
            var night_temp = form["night_dark_condition"];
            if (night_temp != "null")
            {
                night_dark_condition = Convert.ToBoolean(night_temp);
            }
            var single_temp= form["single_vehicle"];
            if (single_temp != "null")
            {
                single_vehicle = Convert.ToBoolean(single_temp);
            }
            var distracted_temp= form["distracted_driving"];
            if (distracted_temp != "null")
            {
                distracted_driving = Convert.ToBoolean(distracted_temp);
            }
            var drowsy_temp= form["drowsy_driving"];
            if (drowsy_temp != "null")
            {
                drowsy_driving = Convert.ToBoolean(drowsy_temp);
            }
            var roadway_temp = form["roadway_departure"];
            if (roadway_temp != "null")
            {
               roadway_departure = Convert.ToBoolean(roadway_temp);
            }


            List<crash_data> record = repo.GetFiltered(city, county_name, route, milepoint, main_road_name, crash_severity_id,   work_zone_related,   pedestrian_involved,   bicyclist_involved,   motorcycle_involved,   improper_restraint,
              unrestrained,   dui,   intersection_related,   wild_animal_related,   domestic_animal_related,   overturn_rollover,   commercial_motor_veh_involved,
              teenage_driver_involved,   older_driver_involved,   night_dark_condition,   single_vehicle,   distracted_driving,   drowsy_driving,   roadway_departure);

            int pageSize = 7;
            int pageNum = 1;
            IncidentsViewModel c = new IncidentsViewModel
            {
                Incidents = record.AsQueryable()
                .OrderByDescending(x => x.crash_datetime)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumIncidents = record.Count(),
                    IncidentsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View("Incidents", c);
        }

        [HttpGet]
        public IActionResult SeverityCalculator()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FullCalculator()
        {
            crash_prediction cd = new crash_prediction();
            return View(cd);
        }
        [HttpPost]
        public IActionResult FullCalculator(crash_prediction data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.First()};
            result.Dispose();
            return RedirectToAction("Result", prediction);
        }
        [HttpGet]
        public IActionResult CityCalc()
        {
            crash_prediction cd = new crash_prediction();
            return View(cd);
        }
        [HttpPost]
        public IActionResult CityCalc(crash_prediction data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();
            return RedirectToAction("Result", prediction);
        }
        [HttpGet]
        public IActionResult DistCalc()
        {
            crash_prediction cd = new crash_prediction();
            return View(cd);
        }
        [HttpPost]
        public IActionResult DistCalc(crash_prediction data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();
            return RedirectToAction("Result", prediction);
        }
        [HttpGet]
        public IActionResult SpecialCalc()
        {
            crash_prediction cd = new crash_prediction();
            return View(cd);
        }
        [HttpPost]
        public IActionResult SpecialCalc(crash_prediction data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();
            return RedirectToAction("Result", prediction);
        }
        public IActionResult Result(Prediction p)
        {
            if (p.PredictedValue > 5)
            {
                p.PredictedValue = 5.0f;
            }
            if(p.PredictedValue < 1)
            {
                p.PredictedValue = 1.0f;
            }
            return View(p);
        }
        public IActionResult Stats()
        {
            return View();
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
