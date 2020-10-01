using OOD_Week5_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    public class ShelterManager
    {
        private List<Adoption> adoptions;
        private List<Animal> animals;
        private List<Customer> customers;

        public ShelterManager()
        {

        }

        public void SaveData()
        {

        }

        public void LoadData()
        {

        }

        public void AddDog(string name, int age, Gender gender, bool adopted, string notes)
        {
            Animal a = new Dog(name, age, gender, adopted, notes);
            if(1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddCat(string name, int age, Gender gender, bool adopted, string notes)
        {
            Animal a = new Cat(name, age, gender, adopted, notes);
            if (1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddBird(string name, int age, Gender gender, bool adopted, string notes, Size size)
        {
            Animal a = new Bird(name, age, gender, adopted, notes, size);
            if (1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddAdoption()
        {
            Adoption a = new Adoption();
            if(1 == 1)
            {
                adoptions.Add(a);
            }
        }

        public void AddCustomer()
        {
            Customer c = new Customer();
            if(1 == 1)
            {
                customers.Add(c);
            }
        }
    }
}
