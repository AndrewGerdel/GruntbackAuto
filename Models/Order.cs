using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Models
{
    public class Order
    {
        public Part Part { get; set; }
        public Customer Customer { get; set; }
        public int ID { get; set; }
    }
}
