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
    public class ContactanosController : Controller
    {
        private readonly ILogger<ContactanosController> _logger;

        public ContactanosController(ILogger<ContactanosController> logger)
        {
            _logger = logger;
        }

        public IActionResult contactanos()
        {
            return View();
        }


        
    }
}
