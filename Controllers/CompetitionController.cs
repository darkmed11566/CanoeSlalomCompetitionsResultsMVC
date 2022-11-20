using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.Controllers
{
    public class CompetitionController : Controller
    {
        public IActionResult AddCompetition()
        {
            return View();
        }
    }
}
