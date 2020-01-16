using GruntbackAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Repositories
{
    public class AddressRepository
    {
        public void AddAddress(Address address)
        {
            using (var db = new PartContext())
            {
                db.Addresses.Add(address);
                db.SaveChanges();
            }
        }

        public Address GetAddress(int id)
        {
            using (var db = new PartContext())
            {
                return db.Addresses.Where(x => x.ID.Equals(id)).FirstOrDefault();
            }
        }
    }
}
