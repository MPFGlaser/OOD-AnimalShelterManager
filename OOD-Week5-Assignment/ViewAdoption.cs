using OOD_Week5_Assignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Week5_Assignment
{
    public partial class ViewAdoption : Form
    {
        private Adoption adoption;

        public ViewAdoption(Adoption adoption)
        {
            InitializeComponent();
            this.adoption = adoption;
            ShowDetails();
        }

        private void ShowDetails()
        {
            labelCustomerName.Text = adoption.Customer.Name;
            labelCustomerAddress.Text = adoption.Customer.Address;
            labelCustomerZipcode.Text = adoption.Customer.Zipcode;
            labelCustomerCity.Text = adoption.Customer.City;
            labelAdoptionDateTime.Text = adoption.AdoptionMoment.ToString();
            foreach(Animal a in adoption.Animals)
            {
                listBoxAdoptedAnimals.Items.Add(a.ToString());
            }
        }
    }
}
