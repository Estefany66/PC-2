using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc_2.Models;

namespace pc_2.Controllers
{
    public class ComprarController : Controller
    {
        private readonly ILogger<ComprarController> _logger;

        public ComprarController(ILogger<ComprarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        
    }
}
