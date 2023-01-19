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

        public ViewResult Details()
        {
            var employee = _employeeRepository.GetEmployee(2);
            return View(employee);
        }
    }
}
