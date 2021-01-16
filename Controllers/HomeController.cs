using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core_MVC_General.Models;
using Core_MVC_General.EFContext;
using Microsoft.EntityFrameworkCore;

namespace Core_MVC_General.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LaunchCompanyContext dbContext;
        public HomeController(ILogger<HomeController> logger, LaunchCompanyContext context)
        {
            this.dbContext = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var lc = dbContext.LaunchCenters.Where(lcs => lcs.ID.Equals("101"));

            ///*
            // * Lazy Loading
            // */
            var launchCenters = dbContext.LaunchCenters;
            LaunchCenter lcent = launchCenters.First();
            ICollection<Staff> staff = lcent.Personnel;
            Staff charlie = staff.First(s => s.Name.Equals("Charlie"));

            Staff numberOneStaff = new Staff { Name = "Nathen", StaffID = 133, LaunchCenterID = "101" };
            ////var launchCentersWithPersonnel = context.LaunchCenters.Include<LaunchCenter>("Personnel");

            ///*
            // * Eager Loading
            // */
            var launchCentersWithPersonnel = dbContext.LaunchCenters.Include(lc => lc.Personnel);
            var lcs = dbContext.LaunchCenters.Where(lc => lc.Commander.Equals("Jeck")).Include(lc => lc.Personnel);
            List<LaunchCenter> allCenters = lcs.ToList();
            LaunchCenter lc101 = lcs.First();
            return View(numberOneStaff);
            //return View();
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
