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
        private int id;
        private string name;
        private int age;
        private Gender gender;
        private bool adopted;
        private string notes;

        public int Id
        {
            get { return this.Id; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public bool Adopted
        {
            get { return this.adopted; }
            set { this.adopted = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public Animal(string name, int age, Gender gender, string notes)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Adopted = false;
            this.Notes = notes;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
