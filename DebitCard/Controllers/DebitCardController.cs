using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebitCard.Controllers
{
    public class DebitCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
