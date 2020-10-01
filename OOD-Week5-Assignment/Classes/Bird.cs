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
        public Bird(string name, int age, Gender gender, bool adopted, string notes, Size size) : base(name, age, gender, adopted, notes)
        {
            size = this.size;
        }
    }
}
