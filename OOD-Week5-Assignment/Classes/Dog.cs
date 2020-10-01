﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week5_Assignment.Models;

namespace OOD_Week5_Assignment.Classes
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender, bool adopted, string notes) : base(name, age, gender, adopted, notes)
        {
            
        }
    }
}
