using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week5_Assignment.Models;

namespace OOD_Week5_Assignment.Classes
{
    [Serializable]
    public abstract class Animal
    {
        public int Id
        {
            get { return this.Id; }
        }

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int Age
        {
            get { return this.Age; }
            set { this.Age = value; }
        }

        public Gender Gender
        {
            get { return this.Gender; }
            set { this.Gender = value; }
        }

        public bool Adopted
        {
            get { return this.Adopted; }
            set { this.Adopted = value; }
        }

        public string Notes
        {
            get { return this.Notes; }
            set { this.Notes = value; }
        }

        public Animal(string name, int age, Gender gender, bool adopted, string notes)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Adopted = adopted;
            this.Notes = notes;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
