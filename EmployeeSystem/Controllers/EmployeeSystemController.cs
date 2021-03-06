using EmployeeSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Controllers
{
    public class EmployeeSystemController : Controller
    {
        private AppDbContext db = null;
        public EmployeeSystemController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult List()
        {
            List<Employee> model = (from e in db.Employees
                                    orderby e.EmployeeID
                                    select e).ToList();

            return View(model);
        }
    }
}
