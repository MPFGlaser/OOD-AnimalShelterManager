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
            comboBoxAnimal2.Visible = false;
            comboBoxAnimal2.Enabled = false;
            buttonRemoveAnimal2.Visible = false;
            comboBoxAnimal3.Visible = false;
            comboBoxAnimal3.Enabled = false;
            buttonRemoveAnimal3.Visible = false;
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
                    comboBoxCustomerName.Items.Add(c.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no customers in the system");
                this.Close();
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

        private void buttonNewAnimalComboBox_Click(object sender, EventArgs e)
        {
            if(comboBoxAnimal2.Visible == true)
            {
                comboBoxAnimal3.Visible = true;
                comboBoxAnimal3.Enabled = true;
                buttonRemoveAnimal3.Visible = true;
                buttonRemoveAnimal2.Visible = false;
                buttonNewAnimalComboBox.Enabled = false;
            }
            else if(comboBoxAnimal2.Visible == true && comboBoxAnimal3.Visible == true)
            {
                buttonNewAnimalComboBox.Enabled = false;
            }
            else
            {
                comboBoxAnimal2.Visible = true;
                comboBoxAnimal2.Enabled = true;
                buttonRemoveAnimal2.Visible = true;
                labelAnimal.Text = "Animals: ";
            }
        }

        private void buttonRemoveAnimal2_Click(object sender, EventArgs e)
        {
            buttonRemoveAnimal2.Visible = false;
            comboBoxAnimal2.Visible = false;
            labelAnimal.Text = "Animal:";
        }

        private void buttonRemoveAnimal3_Click(object sender, EventArgs e)
        {
            buttonNewAnimalComboBox.Enabled = true;
            comboBoxAnimal3.Visible = false;
            buttonRemoveAnimal3.Visible = false;
            buttonRemoveAnimal2.Visible = true;
        }
    }
}
