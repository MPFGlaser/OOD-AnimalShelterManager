using OOD_Week5_Assignment.Classes;
using OOD_Week5_Assignment.Models;
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
        public List<Animal> adoptedAnimals;
        private double calculatedFee = 0;

        public NewAdoption(List<Customer> customers, List<Animal> animals)
        {
            InitializeComponent();
            adoptedAnimals = new List<Animal>();
            if (customers != null || animals != null)
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
            adoptedAnimals.Add((comboBoxAnimal1.SelectedItem as dynamic).Value);

            if (comboBoxAnimal2.Enabled == true)
            {
                adoptedAnimals.Add((Animal)comboBoxAnimal2.SelectedItem);
            }
            if (comboBoxAnimal3.Enabled == true)
            {
                adoptedAnimals.Add((Animal)comboBoxAnimal3.SelectedItem);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CalculateAdoptionFee()
        {
            calculatedFee = 0;

            if (comboBoxAnimal1.Enabled)
            {
                Animal animal1 = (comboBoxAnimal1.SelectedItem as dynamic).Value;
                if (animal1.GetType() == typeof(Dog))
                {
                    calculatedFee += 29.99;
                }
                else if (animal1.GetType() == typeof(Cat))
                {
                    if (animal1.Age < 10)
                    {
                        calculatedFee += 15;
                    }
                    else
                    {
                        calculatedFee += 10;
                    }
                }
                else if (animal1.GetType() == typeof(Bird))
                {
                    if (((Bird)animal1).Size == Models.Size.Small)
                    {
                        calculatedFee += 5.50;
                    }
                    else if (((Bird)animal1).Size == Models.Size.Medium)
                    {
                        calculatedFee += 11;
                    }
                    else if (((Bird)animal1).Size == Models.Size.Large)
                    {
                        calculatedFee += 16.50;
                    }
                }
            }

            if (comboBoxAnimal2.Enabled)
            {
                Animal animal2 = (comboBoxAnimal2.SelectedItem as dynamic).Value;
                if (animal2.GetType() == typeof(Dog))
                {
                    calculatedFee += 29.99;
                }
                else if (animal2.GetType() == typeof(Cat))
                {
                    if (animal2.Age < 10)
                    {
                        calculatedFee += 15;
                    }
                    else
                    {
                        calculatedFee += 10;
                    }
                }
                else if (animal2.GetType() == typeof(Bird))
                {
                    if (((Bird)animal2).Size == Models.Size.Small)
                    {
                        calculatedFee += 5.50;
                    }
                    else if (((Bird)animal2).Size == Models.Size.Medium)
                    {
                        calculatedFee += 11;
                    }
                    else if (((Bird)animal2).Size == Models.Size.Large)
                    {
                        calculatedFee += 16.50;
                    }
                }
            }

            if (comboBoxAnimal3.Enabled)
            {
                Animal animal3 = (comboBoxAnimal3.SelectedItem as dynamic).Value;
                if (animal3.GetType() == typeof(Dog))
                {
                    calculatedFee += 29.99;
                }
                else if (animal3.GetType() == typeof(Cat))
                {
                    if (animal3.Age < 10)
                    {
                        calculatedFee += 15;
                    }
                    else
                    {
                        calculatedFee += 10;
                    }
                }
                else if (animal3.GetType() == typeof(Bird))
                {
                    if (((Bird)animal3).Size == Models.Size.Small)
                    {
                        calculatedFee += 5.50;
                    }
                    else if (((Bird)animal3).Size == Models.Size.Medium)
                    {
                        calculatedFee += 11;
                    }
                    else if (((Bird)animal3).Size == Models.Size.Large)
                    {
                        calculatedFee += 16.50;
                    }
                }
            }

            // Applies a discount if more than 1 animal was selected for adoption
            // Is this a cumulative discount (so 10% per animal, stacking) or not? Wasn't entirely sure.
            if(comboBoxAnimal2.Enabled && comboBoxAnimal3.Enabled)
            {
                calculatedFee = calculatedFee * 0.8;
            }
            else if (comboBoxAnimal2.Enabled)
            {
                calculatedFee = calculatedFee * 0.9;
            }

            // Rounds the price to two decimal places and updates the label
            calculatedFee = Math.Round(calculatedFee, 2);
            labelTotalAdoptionFee.Text = "€" + calculatedFee.ToString();
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

        // Method to add animals to the comboBoxes.
        private void PopulateComboBoxAnimals(List<Animal> animals)
        {
            comboBoxAnimal1.DisplayMember = "Text";
            comboBoxAnimal1.ValueMember = "Value";
            comboBoxAnimal2.DisplayMember = "Text";
            comboBoxAnimal2.ValueMember = "Value";
            comboBoxAnimal3.DisplayMember = "Text";
            comboBoxAnimal3.ValueMember = "Value";
            try
            {
                foreach (Animal a in animals)
                {
                    comboBoxAnimal1.Items.Add(new { Text = a.Name, Value = a });
                    comboBoxAnimal2.Items.Add(new { Text = a.Name, Value = a });
                    comboBoxAnimal3.Items.Add(new { Text = a.Name, Value = a });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no animals in the system.");
                throw;
            }

        }

        // Method to add new comboboxes for extra animals, if desired.
        private void buttonNewAnimalComboBox_Click(object sender, EventArgs e)
        {
            if (comboBoxAnimal2.Visible == true)
            {
                comboBoxAnimal3.Visible = true;
                comboBoxAnimal3.Enabled = true;
                buttonRemoveAnimal3.Visible = true;
                buttonRemoveAnimal2.Visible = false;
                buttonNewAnimalComboBox.Enabled = false;
            }
            else if (comboBoxAnimal2.Visible == true && comboBoxAnimal3.Visible == true)
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

        // Method to remove comboBoxAnimal2
        private void buttonRemoveAnimal2_Click(object sender, EventArgs e)
        {
            buttonRemoveAnimal2.Visible = false;
            comboBoxAnimal2.Visible = false;
            comboBoxAnimal2.Enabled = false;
            labelAnimal.Text = "Animal:";
            CalculateAdoptionFee();
        }

        // Method to remove comboBoxAnimal3
        private void buttonRemoveAnimal3_Click(object sender, EventArgs e)
        {
            buttonNewAnimalComboBox.Enabled = true;
            comboBoxAnimal3.Visible = false;
            comboBoxAnimal3.Enabled = false;
            buttonRemoveAnimal3.Visible = false;
            buttonRemoveAnimal2.Visible = true;
            CalculateAdoptionFee();
        }

        // Multiple methods to call for recalculation of the adoption fee when a different animal is selected.
        private void comboBoxAnimal1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAdoptionFee();
        }

        private void comboBoxAnimal2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAdoptionFee();
        }

        private void comboBoxAnimal3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAdoptionFee();
        }
    }
}
