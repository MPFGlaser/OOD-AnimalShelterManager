using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week5_Assignment.Models;

namespace OOD_Week5_Assignment.Classes
{
    public class Bird : Animal
    {
        private Size size;

        public Size Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public Bird(string name, int age, Gender gender, string notes, Size size) : base(name, age, gender, notes)
        {
            this.Size = size;
        }
    }
}
