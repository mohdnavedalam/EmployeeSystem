﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Controllers
{
    public class EmployeeSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
