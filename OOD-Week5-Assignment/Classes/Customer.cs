﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    [Serializable]
    public class Customer 
    {
        #region Fields and properties
        private string name;
        private string address;
        private string zipcode;
        private string city;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Zipcode
        {
            get { return this.zipcode; }
            set { this.zipcode = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        #endregion

        public Customer(string name, string address, string zipcode, string city)
        {
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
        }
    }
}
