using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week5_Assignment.Classes
{
    public class Adoption
    {
        #region Fields and properties
        private List<Animal> animals;
        private Customer customer;
        private DateTime adoptionMoment;
        private double adoptionFee;

        public List<Animal> Animals
        {
            get { return this.animals; }
        }

        public Customer Customer
        {
            get { return this.customer; }
        }

        public DateTime AdoptionMoment
        {
            get { return this.adoptionMoment; }
        }

        public double AdoptionFee
        {
            get { return this.adoptionFee; }
        }
        #endregion

        public Adoption(List<Animal> animals, Customer customer, DateTime adoptionMoment, double adoptionFee)
        {
            this.animals = animals;
            this.customer = customer;
            this.adoptionMoment = adoptionMoment;
            this.adoptionFee = adoptionFee;

            // Sets the Adopted bool in the animal class to true
            foreach(Animal a in animals)
            {
                a.Adopted = true;
            }
        }
    }
}
