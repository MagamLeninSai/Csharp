using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Address
    {
        public int ID { get; set; }
        public String AddressLine { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address{ID=1,AddressLine="Bengaluru"},
                new Address{ID=2,AddressLine="Hyderabad"},
                new Address{ID=3,AddressLine="Secunderabad"},
                new Address{ID=4,AddressLine="Delhi"},
                new Address{ID=5,AddressLine="Chennai"},
                new Address{ID=6,AddressLine="Mumbai"},
                new Address{ID=7,AddressLine="Pune"},
                new Address{ID=8,AddressLine="Calcutta"}
            };

        }
    }
}
