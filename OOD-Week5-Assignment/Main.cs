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
    public partial class Main : Form
    {
        private NewAnimal newAnimal;
        private NewCustomer newCustomer;
        private NewAdoption newAdoption;
        private ShelterManager shelterManager;

        public Main()
        {
            InitializeComponent();
            shelterManager = new ShelterManager();
            UpdateListboxes();
        }

        private void buttonNewAnimal_Click(object sender, EventArgs e)
        {
            newAnimal = new NewAnimal();
            if(newAnimal.ShowDialog() == DialogResult.OK)
            {
                switch (newAnimal.Type)
                {
                    case Models.AnimalType.Dog:
                        shelterManager.AddDog(newAnimal.Name, newAnimal.Age, newAnimal.AnimalGender, newAnimal.Notes);
                        break;
                    case Models.AnimalType.Cat:
                        shelterManager.AddCat(newAnimal.Name, newAnimal.Age, newAnimal.AnimalGender, newAnimal.Notes);
                        break;
                    case Models.AnimalType.Bird:
                        shelterManager.AddBird(newAnimal.Name, newAnimal.Age, newAnimal.AnimalGender, newAnimal.Notes, newAnimal.AnimalSize);
                        break;
                    default:
                        break;
                }
            }
            UpdateListboxes();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            newCustomer = new NewCustomer();
            if(newCustomer.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddCustomer(newCustomer.Name, newCustomer.Address, newCustomer.ZipCode, newCustomer.City) ;
            }
            UpdateListboxes();
        }

        private void buttonNewAdoption_Click(object sender, EventArgs e)
        {
            newAdoption = new NewAdoption(shelterManager.Customers, shelterManager.Animals);
            if(newAdoption.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddAdoption(newAdoption.AdoptedAnimals, newAdoption.AdoptionCustomer, newAdoption.AdoptionMoment, newAdoption.AdoptionFee);
            }
            UpdateListboxes();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            // Load data
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Save data
        }

        private void buttonAdoptionInfo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnimalInfo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAdoptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Updates the Adoptions and Animals listboxes, assuming there is data to populate them.
        private void UpdateListboxes()
        {
            if(shelterManager.Adoptions != null)
            {
                listBoxAdoptions.DisplayMember = "Text";
                listBoxAdoptions.ValueMember = "Value";
                listBoxAdoptions.Items.Clear();
                foreach (Adoption a in shelterManager.Adoptions)
                {
                    listBoxAdoptions.Items.Add(new { Text = a.ToString(), Value = a });
                }
            }

            if (shelterManager.Animals != null)
            {
                listBoxAnimals.DisplayMember = "Text";
                listBoxAnimals.ValueMember = "Value";
                listBoxAnimals.Items.Clear();

                foreach(Animal a in shelterManager.Animals)
                {
                    listBoxAnimals.Items.Add(new { Text = a.ToString(), Value = a });
                }
            }
        }
    }
}
