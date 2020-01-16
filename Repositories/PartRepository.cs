using GruntbackAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Repositories
{
    public class PartRepository
    {
        public void AddPart(Part part)
        {
            using (var db = new PartContext())
            {
                db.Parts.Add(part);
                db.SaveChanges();
            }
        }
    }
}
