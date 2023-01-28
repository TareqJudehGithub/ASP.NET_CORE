using Microsoft.AspNetCore.Mvc;

namespace EmpManage.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
