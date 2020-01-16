using GruntbackAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Repositories
{
    public class OrderRepository
    {
        public void AddOrder(Order order)
        {
            using (var db = new PartContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public Order GetOrder(int id)
        {
            using (var db = new PartContext())
            {
                return db.Orders.Where(x => x.ID.Equals(id)).FirstOrDefault();
            }
        }
    }
}
