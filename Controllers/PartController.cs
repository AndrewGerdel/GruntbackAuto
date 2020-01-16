using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GruntbackAuto.Models;
using GruntbackAuto.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GruntbackAuto.Controllers
{
    public class PartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public void Test()
        {
            var part = new Part();
            part.ID = 1;
            part.Description = "part1";
            part.Name = "Part 1";
            part.WeightPounds = 0.5m;
            var repo = new PartRepository();
            repo.AddPart(part);
        }
    }
}