using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using clv_mvc.Models;
using Parser;
using Newtonsoft.Json;
using System.Data;

namespace clv_mvc.Controllers
{
    public class HomeController : Controller
    {
        public struct inputparams
        {
            public double h;
            public double ob;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult Research()
        {
            return View();
        }

        public IActionResult Publications()
        {
            return View();
        }

        public IActionResult Visualization()
        {
            return View();
        }

        public IActionResult Openings()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public string NewChart(double h, double ob)
        {
            List<Output> data = new List<Output>();


            data = Parser.Program.ProcessAndGetOutput(h, ob);

            List<List<double>> l = new List<List<double>>();
            List<double> TT, EE, TE, BB;
            BB = new List<double>();
            TE = new List<double>();
            EE = new List<double>();
            TT = new List<double>();
            for (int i = 0; i < data.Count; i++)
            {
                TT.Add(data[i].TT);
                EE.Add(data[i].EE);
                TE.Add(data[i].TE);
                BB.Add(data[i].BB);
            }
            l.Add(TT);
            l.Add(EE);
            l.Add(TE);
            l.Add(BB);

            var a = JsonConvert.SerializeObject(l);

            return a;
        }
    }
}
