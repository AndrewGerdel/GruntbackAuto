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

        public Part GetPart(int id)
        {
            using (var db = new PartContext())
            {
                return db.Parts.Where(x => x.ID.Equals(id)).FirstOrDefault();
            }
        }

        public IEnumerable<Part> GetAllParts()
        {
            using (var db = new PartContext())
            {
                return db.Parts.ToList();
            }
        }
    }
}
