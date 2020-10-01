using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    public class Customer 
    {
        private string name;
        private string address;
        private string zipcode;
        private string city;

        public Customer(string name, string address, string zipcode, string city)
        {
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
    }
}
