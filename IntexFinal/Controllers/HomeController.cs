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
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

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
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();
            return RedirectToAction("Result", prediction);
        }
        [HttpGet]
        public IActionResult Result(Prediction p)
        {
            return View(p);
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
