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
    public class NosotrosController : Controller
    {
        private readonly ILogger<NosotrosController> _logger;

        public NosotrosController(ILogger<NosotrosController> logger)
        {
            _logger = logger;
        }

        public IActionResult nosotros()
        {
            return View();
        }


        
    }
}
