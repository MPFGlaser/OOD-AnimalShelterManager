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

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public bool Adopted { get; set; }
        public string Notes { get; set; }

        public Animal(string name, int age, Gender gender, bool adopted, string notes)
        {
            name = this.name;
            age = this.age;
            gender = this.gender;
            adopted = this.adopted;
            notes = this.notes;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
