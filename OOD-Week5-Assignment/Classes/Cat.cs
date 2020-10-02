using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week5_Assignment.Models;

namespace OOD_Week5_Assignment.Classes
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender,  string notes) : base(name, age, gender, notes)
        {

        }

        public override string ToString()
        {
            return "[Cat]" + base.ToString();
        }
    }
}
