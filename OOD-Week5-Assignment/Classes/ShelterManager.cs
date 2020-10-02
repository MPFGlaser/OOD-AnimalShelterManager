﻿using OOD_Week5_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    [Serializable]
    public class ShelterManager
    {
        private List<Adoption> adoptions;
        private List<Animal> animals;
        private List<Customer> customers;

        public ShelterManager()
        {
            adoptions = new List<Adoption>();
            animals = new List<Animal>();
            customers = new List<Customer>();
        }

        public void SaveData()
        {

        }

        public void LoadData()
        {

        }

        public void AddDog(string name, int age, Gender gender, string notes)
        {
            Animal a = new Dog(name, age, gender, notes);
            if(1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddCat(string name, int age, Gender gender, string notes)
        {
            Animal a = new Cat(name, age, gender, notes);
            if (1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddBird(string name, int age, Gender gender, string notes, Size size)
        {
            Animal a = new Bird(name, age, gender, notes, size);
            if (1 == 1)
            {
                animals.Add(a);
            }
        }

        public void AddAdoption(List<Animal> animals, Customer customer, DateTime adoptionMoment, double adoptionFee)
        {
            Adoption a = new Adoption(animals, customer, adoptionMoment, adoptionFee);
            if(1 == 1)
            {
                adoptions.Add(a);
            }
        }

        public void AddCustomer(string name, string address, string zipcode, string city)
        {
            Customer c = new Customer(name, address, zipcode, city);
            if(1 == 1)
            {
                customers.Add(c);
            }
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
