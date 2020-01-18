using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GruntbackAuto.Interfaces;
using GruntbackAuto.Models;
using GruntbackAuto.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GruntbackAuto.Controllers
{
    public class PartController : Controller
    {
        IPartRepository _partRepository;

        public PartController()
        {
            _partRepository = new PartRepository();
        }

        /// <summary>
        /// Allow the caller (such as unit tests) to inject their own partrepo 
        /// </summary>
        /// <param name="partRepository"></param>
        public PartController(IPartRepository partRepository)
        {
            _partRepository = partRepository;
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
            var part = _partRepository.GetPart(id);
            return part;
        }

        /// <summary>
        /// Should also be authorized, in a real world app. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Part> GetAllParts()
        {
            var parts = _partRepository.GetAllParts().ToList();
            return parts;
        }

        [HttpPost]
        public void AddNewPart(Part part)
        {
            _partRepository.AddPart(part);// new Part() { Description = description, ID = id, Name = name, WeightPounds = weightPounds });
        }
    }
}