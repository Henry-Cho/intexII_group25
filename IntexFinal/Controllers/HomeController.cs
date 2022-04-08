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
using Newtonsoft.Json.Linq;

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

        //returns list of all Incidents in database by default, or can be filtered
        public IActionResult Incidents(int pageNum = 1, string r = "")
        {
            //r represents redirect
            // if r is present, we want to keep temp data to have access to our list of crash data
            //if not, we want to delete it
            if (r != "r")
            {
                TempData.Remove("FilteredList");
            }
            if (r == "")
            {
                ViewBag.Redirect = false;
            }
            else
            {
                ViewBag.Redirect = true;
            }
            int pageSize = 4;
            var c = new IncidentsViewModel();
            List<crash_data> cd = new List<crash_data>();
            //this creates pulls a filtered list from the database if necessary
            if (TempData["FilteredList"] != null)
            {
                JObject temp = JsonConvert.DeserializeObject(TempData["FilteredList"].ToString()) as JObject;
                TempData.Keep("FilteredList");
                var fd = temp.ToObject<FilteredData>();
                cd = repo.GetFiltered(fd.city, fd.county_name, fd.route, fd.main_road_name, fd.crash_severity_id, fd.work_zone_related, fd.pedestrian_involved, fd.bicyclist_involved, fd.motorcycle_involved, fd.improper_restraint,
                fd.unrestrained, fd.dui, fd.intersection_related, fd.wild_animal_related, fd.domestic_animal_related, fd.overturn_rollover, fd.commercial_motor_veh_involved,
                fd.teenage_driver_involved, fd.older_driver_involved, fd.night_dark_condition, fd.single_vehicle, fd.distracted_driving, fd.drowsy_driving, fd.roadway_departure);
            }
            //if there is no passed filtered data, pull all data
            if (cd.Count() == 0)
            {
                c = new IncidentsViewModel
                {
                    Incidents = repo.crash_data
                        .OrderByDescending(x => x.crash_datetime)
                        .Skip((pageNum - 1) * pageSize)
                        .Take(pageSize),

                    PageInfo = new PageInfo
                    {
                        TotalNumIncidents = repo.crash_data.Count(),
                        IncidentsPerPage = pageSize,
                        CurrentPage = pageNum
                    }
                };
            }
            //otherwise pull only the filtered data
            else
            {
                c = new IncidentsViewModel
                {
                    Incidents = cd.AsQueryable()
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
            }
            //set length so that user can see number of results
            if (cd.Count() != 0)
                ViewBag.Length = cd.Count();
            else
                ViewBag.Length = repo.crash_data.ToList().Count();

            return View(c);
        }

        //page that does the filtering. it has to be in separate view since it is so big
        [HttpGet]
        public IActionResult Filter()
        {
            var csi = repo.crash_data
                .Select(x => x.crash_severity_id)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.crash_severity_id = csi;

            var cn = repo.crash_data
                .Select(x => x.county_name)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.county_name = cn;

            var ct = repo.crash_data
                .Select(x => x.city)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.city = ct;


            var mrn = repo.crash_data
                .Select(x => x.main_road_name)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.main_road_name = mrn;

            var mp = repo.crash_data
                .Select(x => x.milepoint)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.milepoint = mp;

            var rt = repo.crash_data
                .Select(x => x.route)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            ViewBag.route = rt;


            return View();
        }

        // goes through and manages all the form inputs so that they can be used in the database
        [HttpPost]
        public IActionResult Filter(IFormCollection form )
        {
            FilteredData fd = new FilteredData();
            fd.city = null;
            fd.county_name = null;
            fd.route = null; 
            fd.main_road_name = null;
            fd.crash_severity_id = null;
            fd.work_zone_related = null;
            fd.pedestrian_involved = null;
            fd.bicyclist_involved = null;
            fd.motorcycle_involved = null;
            fd.improper_restraint = null;

            fd.unrestrained = null;
            fd.dui = null;
            fd.intersection_related = null;
            fd.wild_animal_related = null;
            fd.domestic_animal_related = null;
            fd.overturn_rollover = null;
            fd.commercial_motor_veh_involved = null;

            fd.teenage_driver_involved = null;
            fd.older_driver_involved = null;
            fd.night_dark_condition = null;
            fd.single_vehicle = null;
            fd.distracted_driving = null;
            fd.drowsy_driving = null;
            fd.roadway_departure = null;
        
            // if it is "null" then that means we do not want to filter this item
            var route_temp = form["route"];
            if(route_temp != "null")
            {
                fd.route = Convert.ToInt32(route_temp);
            }
            var main_road_temp = form["main_road_name"];
            if (main_road_temp != "null")
            {
                fd.main_road_name = main_road_temp;
            }
            var city_temp = form["city"];
            if (city_temp != "null")
            {
                fd.city = city_temp;
            }
            var crash_severity_temp = form["crash_severity_id"];
            if (crash_severity_temp != "null")
            {
                fd.crash_severity_id = Convert.ToInt32(crash_severity_temp);
            }

            var work_temp = form["work_zone_related"];
            if (work_temp != "null")
            {
                fd.work_zone_related = Convert.ToBoolean(work_temp);
            }
            var pedestrian_temp= form["pedestrian_involved"];
            if (pedestrian_temp != "null")
            {
                fd.pedestrian_involved = Convert.ToBoolean(pedestrian_temp);
            }
            var bicyclist_temp = form["bicyclist_involved"];
            if (bicyclist_temp != "null")
            {
                fd.bicyclist_involved = Convert.ToBoolean(bicyclist_temp);
            }
            var motorcycle_temp = form["motorcycle_involved"];
            if (motorcycle_temp != "null")
            {
                fd.motorcycle_involved = Convert.ToBoolean(motorcycle_temp);
            }
            var improper_temp = form["improper_restraint"];
            if (improper_temp != "null")
            {
                fd.improper_restraint = Convert.ToBoolean(improper_temp);
            }
            var unrestrained_temp = form["unrestrained"];
            if (unrestrained_temp != "null")
            {
                fd.unrestrained = Convert.ToBoolean(unrestrained_temp);
            }
            var dui_temp = form["dui"];
            if (dui_temp != "null")
            {
                fd.dui = Convert.ToBoolean(dui_temp);
            }
            var intersection_temp = form["intersection_related"];
            if (intersection_temp != "null")
            {
                fd.intersection_related = Convert.ToBoolean(intersection_temp);
            }
            var wild_animal_temp = form["wild_animal_related"];
            if (wild_animal_temp != "null")
            {
                fd.wild_animal_related = Convert.ToBoolean(wild_animal_temp);
            }
            var domestic_animal_temp = form["domestic_animal_related"];
            if (domestic_animal_temp != "null")
            {
                fd.domestic_animal_related = Convert.ToBoolean(domestic_animal_temp);
            }
            var overturn_temp = form["overturn_rollover"];
            if (overturn_temp != "null")
            {
                fd.overturn_rollover = Convert.ToBoolean(overturn_temp);
            }
            var commercial_temp = form["commercial_motor_veh_involved"];
            if (commercial_temp != "null")
            {
                fd.commercial_motor_veh_involved = Convert.ToBoolean(commercial_temp);
            }
            var teenage_driver_temp = form["teenage_driver_involved"];
            if (teenage_driver_temp != "null")
            {
                fd.teenage_driver_involved = Convert.ToBoolean(teenage_driver_temp);
            }
            var older_driver_temp = form["older_driver_involved"];
            if (older_driver_temp != "null")
            {
                fd.older_driver_involved = Convert.ToBoolean(older_driver_temp);
            }
            var night_temp = form["night_dark_condition"];
            if (night_temp != "null")
            {
                fd.night_dark_condition = Convert.ToBoolean(night_temp);
            }
            var single_temp= form["single_vehicle"];
            if (single_temp != "null")
            {
                fd.single_vehicle = Convert.ToBoolean(single_temp);
            }
            var distracted_temp= form["distracted_driving"];
            if (distracted_temp != "null")
            {
                fd.distracted_driving = Convert.ToBoolean(distracted_temp);
            }
            var drowsy_temp= form["drowsy_driving"];
            if (drowsy_temp != "null")
            {
                fd.drowsy_driving = Convert.ToBoolean(drowsy_temp);
            }
            var roadway_temp = form["roadway_departure"];
            if (roadway_temp != "null")
            {
               fd.roadway_departure = Convert.ToBoolean(roadway_temp);
            }

            //stores this data in tempdata so we can access in other controllers
            TempData["FilteredList"] = JsonConvert.SerializeObject(fd);
            
            return RedirectToAction("Incidents", new { pageNum = 1, r="r"});
        }

        //Calculator Home
        [HttpGet]
        public IActionResult SeverityCalculator()
        {
            return View();
        }
        //Page for all the inputs for our model
        [HttpGet]
        public IActionResult FullCalculator()
        {
            crash_prediction cd = new crash_prediction();
            return View(cd);
        }
        // sends data through the model and returns prediction info
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
        //calculator just based on city all other data held constant
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
        //calculator based on just distractions all other variables held constant
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

        //calculator just for special events, everything else held constant
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
        //result page to show what crash severity was calculated by the model
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
        //informational page, no functionality
        public IActionResult Stats()
        {
            return View();
        }

        //GDPR compliant privacy policy
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //used to make filtering easier by compiling all the data together
        public struct FilteredData {
            public string? city;
            public string? county_name;
            public int? route;
            public string? main_road_name;
            public int? crash_severity_id;
            public bool? work_zone_related;
            public bool? pedestrian_involved;
            public bool? bicyclist_involved;
            public bool? motorcycle_involved;
            public bool? improper_restraint;

            public bool? unrestrained;
            public bool? dui;
            public bool? intersection_related;
            public bool? wild_animal_related;
            public bool? domestic_animal_related;
            public bool? overturn_rollover;
            public bool? commercial_motor_veh_involved;

            public bool? teenage_driver_involved;
            public bool? older_driver_involved;
            public bool? night_dark_condition;
            public bool? single_vehicle;
            public bool? distracted_driving;
            public bool? drowsy_driving;
            public bool? roadway_departure;
        }


    }
}
