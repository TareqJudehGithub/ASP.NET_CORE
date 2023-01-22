using EmpManage.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;  // to Add Controller class

namespace EmpManage.Controllers
{
    public class HomeController : Controller
    {
        // Dependency Injection - to inject a field into a constructor
        // member fields
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
        public string Greet()
        {
            return "Hello world!";
        }


        // ViewData view
        //public ViewResult Details()
        //{
        //    var employee = _employeeRepository.GetEmployee(2);
        //    ViewData["Employee"] = employee;
        //    ViewData["PageTitle"] = "Details";
        //    return View();
        //}

        // ViewBag view

        //public ViewResult Details()
        //{
        //    var employee = _employeeRepository.GetEmployee(1);
        //    ViewBag.employee = "Employee";
        //    ViewBag.PageTitle = "Details";


        //    var employee = _employeeRepository.GetEmployee(1);


        //    return View(employee);
        //}


        // Strongly Typed view
        public ViewResult Details()
        {
            var employee = _employeeRepository.GetEmployee(1);
            ViewBag.employee = "Employee";
            ViewBag.PageTitle = "Page tab";
            return View(employee);
        }



        //public ViewResult Details()
        //{
        //    var employee = _employeeRepository.GetEmployee(2);

        //    return View("../MyViews/MyViewsTest"); // relative path
        //}
        //public ViewResult Details()
        //{
        //    var employee = _employeeRepository.GetEmployee(2);
        //    return View("~/RootLvlView/Index.cshtml"); // Absolute path
        //}
    }
}
