using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet.Models;



namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Transactions t = new Transactions();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // our losely coupled class to return us employee interface base on type
            WorkerFactory factory = new WorkerFactory();

            // result to be returned to the view
            List<EmployeeDetails> result = new List<EmployeeDetails>();

            // get required data from database
            List<PersonBase> data = t.GetEmployeesFromDb();

            // process our data with the loop and create result
            foreach (PersonBase p in data)
            {
                // from worker factory get the class corresponding to employee                  
                IWorker worker = factory.GetEmployee(p.Type);

                // get the email details based on the class
                EmployeeDetails item = worker.GetEmployeeDetails(p);

                // add the employee to the list
                result.Add(item);
            }

            // PermanentEmployeeWage

            // return the view with the list as model
            return View(result);
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
