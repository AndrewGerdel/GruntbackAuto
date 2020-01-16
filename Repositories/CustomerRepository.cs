using GruntbackAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Repositories
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var db = new PartContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var db = new PartContext())
            {
                return db.Customers.Where(x => x.ID.Equals(id)).FirstOrDefault();
            }
        }
    }
}
