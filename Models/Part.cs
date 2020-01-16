using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Models
{
    public class PartContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
    }

    public class Part
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal WeightPounds { get; set; }
    }
}
