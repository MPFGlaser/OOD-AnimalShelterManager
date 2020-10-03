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
        #region Fields and properties
        private List<Animal> adoptedAnimals;
        private Customer adoptionCustomer;
        private double calculatedFee = 0;
        private DateTime adoptionMoment;
        private bool customerCorrect = false;
        private bool animalsCorrect = false;

        public List<Animal> AdoptedAnimals
        {
            get { return this.adoptedAnimals; }
        }

        public Customer AdoptionCustomer
        {
            get { return adoptionCustomer; }
            private set { adoptionCustomer = value; }
        }

        public DateTime AdoptionMoment
        {
            get { return adoptionMoment; }
            private set { adoptionMoment = value; }
        }

        public double AdoptionFee
        {
            get { return calculatedFee; }
            private set { calculatedFee = value; }
        }
        #endregion

        #region Logic
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
            buttonConfirm.Enabled = false;
        }

        // Calculates the adoption fee based on the currently selected animals, and, if applicable, their properties.
        private void CalculateAdoptionFee()
        {
            calculatedFee = 0;

            // Calculates the fee for the animal selected in comboBoxAnimal1
            if (comboBoxAnimal1.Enabled && comboBoxAnimal1.SelectedIndex != -1)
            {
                //animalsCorrect = true;
                //ConfirmButtonEnabler(); 

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

            // Calculates the fee for the animal selected in comboBoxAnimal2
            if (comboBoxAnimal2.Enabled && comboBoxAnimal2.SelectedIndex != -1)
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

            // Calculates the fee for the animal selected in comboBoxAnimal3
            if (comboBoxAnimal3.Enabled && comboBoxAnimal3.SelectedIndex != -1)
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
                calculatedFee *= 0.8;
            }
            else if (comboBoxAnimal2.Enabled)
            {
                calculatedFee *= 0.9;
            }

            // Rounds the price to two decimal places and updates the label
            calculatedFee = Math.Round(calculatedFee, 2);
            labelTotalAdoptionFee.Text = "€" + calculatedFee.ToString();
        }

        /// <summary>
        /// Checks if all fields are filled in, and if that is the case, it enables the confirm button.
        /// </summary>
        private void ConfirmButtonEnabler()
        {
            if (customerCorrect && animalsCorrect)
            {
                buttonConfirm.Enabled = true;
            }
            else
            {
                buttonConfirm.Enabled = false;
            }
        }

        private void Confirm()
        {
            if (comboBoxAnimal1.Enabled && comboBoxAnimal1.SelectedIndex != -1)
            {
                adoptedAnimals.Add((comboBoxAnimal1.SelectedItem as dynamic).Value);
            }

            if (comboBoxAnimal2.Enabled && comboBoxAnimal2.SelectedIndex != -1)
            {
                adoptedAnimals.Add((comboBoxAnimal2.SelectedItem as dynamic).Value);
            }

            if (comboBoxAnimal3.Enabled && comboBoxAnimal3.SelectedIndex != -1)
            {
                adoptedAnimals.Add((comboBoxAnimal3.SelectedItem as dynamic).Value);
            }

            if (comboBoxCustomerName.SelectedIndex != -1)
            {
                AdoptionCustomer = (comboBoxCustomerName.SelectedItem as dynamic).Value;
            }

            AdoptionMoment = dateTimePickerAdoptionMoment.Value;

            CalculateAdoptionFee();

            this.DialogResult = DialogResult.OK;
        }

        // Method to add new comboboxes for extra animals, if desired.
        private void NewAnimalComboBox()
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
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        // Method to remove comboBoxAnimal2
        private void RemoveComboBoxAnimal2()
        {
            buttonRemoveAnimal2.Visible = false;
            comboBoxAnimal2.Visible = false;
            comboBoxAnimal2.Enabled = false;
            comboBoxAnimal2.SelectedIndex = -1;
            labelAnimal.Text = "Animal:";
            labelAnimal2AlreadyChosen.Visible = false;
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        // Method to remove comboBoxAnimal3
        private void RemoveComboBoxAnimal3()
        {
            buttonNewAnimalComboBox.Enabled = true;
            comboBoxAnimal3.Visible = false;
            comboBoxAnimal3.Enabled = false;
            comboBoxAnimal3.SelectedIndex = -1;
            buttonRemoveAnimal3.Visible = false;
            buttonRemoveAnimal2.Visible = true;
            labelAnimal3AlreadyChosen.Visible = false;
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        private void CustomerNameChanged()
        {
            if (comboBoxCustomerName.SelectedIndex != -1)
            {
                customerCorrect = true;
                ConfirmButtonEnabler();
            }
            else
            {
                customerCorrect = false;
                ConfirmButtonEnabler();
            }
        }
        #endregion

        #region Control event handlers
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonNewAnimalComboBox_Click(object sender, EventArgs e)
        {
            NewAnimalComboBox();
        }

        private void buttonRemoveAnimal2_Click(object sender, EventArgs e)
        {
            RemoveComboBoxAnimal2();
        }

        private void buttonRemoveAnimal3_Click(object sender, EventArgs e)
        {
            RemoveComboBoxAnimal3();
        }

        // Multiple methods to call for recalculation of the adoption fee when a different animal is selected.
        private void comboBoxAnimal1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        private void comboBoxAnimal2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        private void comboBoxAnimal3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxAnimals();
            CalculateAdoptionFee();
            ConfirmButtonEnabler();
        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerNameChanged();
        }
        #endregion

        #region Form control source data methods
        // Method to add customers to the combobox
        private void PopulateComboBoxCustomers(List<Customer> customers)
        {
            comboBoxCustomerName.DisplayMember = "Text";
            comboBoxCustomerName.ValueMember = "Value";
            try
            {
                foreach (Customer c in customers)
                {
                    comboBoxCustomerName.Items.Add(new { Text = c.Name, Value = c });
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
                    if (!a.Adopted)
                    {
                        comboBoxAnimal1.Items.Add(new { Text = a.ToString(), Value = a });
                        comboBoxAnimal2.Items.Add(new { Text = a.ToString(), Value = a });
                        comboBoxAnimal3.Items.Add(new { Text = a.ToString(), Value = a });
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no animals in the system.");
                throw;
            }

        }

        // Method to prevent selection of already selected animals
        private void UpdateComboBoxAnimals()
        {
            // Idea is to eventually remove the animals from the next listboxes if its already chosen, but for now disabling the confirm button as well as showing a warning will have to do.
            // Looks a bit shoddy, but it works!
            animalsCorrect = true;
            try
            {
                if ((comboBoxAnimal2.SelectedItem as dynamic).Value == (comboBoxAnimal1.SelectedItem as dynamic).Value)
                {
                    labelAnimal2AlreadyChosen.Visible = true;
                    animalsCorrect = false;
                }
                else
                {
                    labelAnimal2AlreadyChosen.Visible = false;
                    animalsCorrect = true;
                }
            }
            catch (Exception) { }

            try
            {
                if ((comboBoxAnimal3.SelectedItem as dynamic).Value == (comboBoxAnimal2.SelectedItem as dynamic).Value)
                {
                    labelAnimal3AlreadyChosen.Visible = true;
                    animalsCorrect = false;
                }
                else
                {
                    labelAnimal3AlreadyChosen.Visible = false;
                    animalsCorrect = true;
                }
            }
            catch (Exception) { }

            try
            {
                if((comboBoxAnimal3.SelectedItem as dynamic).Value == (comboBoxAnimal1.SelectedItem as dynamic).Value)
                {
                    labelAnimal3AlreadyChosen.Visible = true;
                    animalsCorrect = false;
                }
                else
                {
                    labelAnimal3AlreadyChosen.Visible = false;
                    animalsCorrect = true;
                }
            }
            catch (Exception) { }
        }
        #endregion
    }
}
