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
        PartRepository partRepository;

        public PartController()
        {
            partRepository = new PartRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Returns a part.  In real-world application I would also decorate this action with authorize. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Part Get(int id)
        {
            var part = partRepository.GetPart(id);
            return part;
        }

        /// <summary>
        /// Should also be authorized, in a real world app. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Part> GetAllParts()
        {
            var parts = partRepository.GetAllParts();
            return parts;
        }

        [HttpPost]
        public void AddNewPart(Part part)
        {
            partRepository.AddPart(part);// new Part() { Description = description, ID = id, Name = name, WeightPounds = weightPounds });
        }
    }
}