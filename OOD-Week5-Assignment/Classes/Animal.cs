using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    public class Animal
    {
        private int id;
        private string name;
        private int age;
        private gender gender;
        private bool adopted;
        private string notes;

        Animal()
        {

        }

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public gender Gender { get; set; }
        public bool Adopted { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
