using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string GetFullAddressString()
        {
            if (IsValid())
            {
                return String.Format("{0} {1} {2}, {3} {4}",
                Address1, Address2, City, State, Zip);
            }
            else
            {
                //for this demo project, let's blow up if required fields aren't missing.  Probably not what you would want to happen in a production app..
                throw new InvalidAddressException(ID);
            }
        }

        private bool IsValid()
        {
            if(Address1.Length == 0 || City.Length == 0 || State.Length == 0 || Zip.Length == 0)
                return false;
            return true;
        }

        public class InvalidAddressException : Exception
        {
            string _message = String.Empty;
            public InvalidAddressException(int ID)
            {
                _message = String.Format("Address [{0}] is invalid.", ID);
            }

            public override string Message
            {
                get
                {
                    return _message;
                }
            }

        }
    }
}
