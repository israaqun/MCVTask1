using Microsoft.AspNetCore.Mvc;
using msvTask1.Data;

namespace msvTask1.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public IActionResult Index()
        {
            var employees=context.Employees.ToList();
            return View("Index",employees);
        }
    }
}
