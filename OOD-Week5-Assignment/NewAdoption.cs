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
    public partial class NewAdoption : Form
    {
        public NewAdoption(List<Customer> customers, List<Animal> animals)
        {
            InitializeComponent();
            if(customers != null || animals != null)
            {
                PopulateComboBoxCustomers(customers);
                PopulateComboBoxAnimals(animals);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateComboBoxCustomers(List<Customer> customers)
        {
            try
            {
                foreach (Customer c in customers)
                {
                    comboBoxCustomerName.Items.Add(c);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no customers in the system");
                throw;
            }
            
        }

        private void PopulateComboBoxAnimals(List<Animal> animals)
        {
            try
            {
                foreach (Animal a in animals)
                {
                    comboBoxAnimal1.Items.Add(a);
                    comboBoxAnimal2.Items.Add(a);
                    comboBoxAnimal3.Items.Add(a);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no animals in the system.");
                throw;
            }
            
        }
    }
}
