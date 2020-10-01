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
            TestUpdateListboxes();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            newCustomer = new NewCustomer();
            if(newCustomer.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddCustomer(newCustomer.Name, newCustomer.Address, newCustomer.ZipCode, newCustomer.City) ;
            }
            TestUpdateListboxes();
        }

        private void buttonNewAdoption_Click(object sender, EventArgs e)
        {
            newAdoption = new NewAdoption(shelterManager.GetCustomers(), shelterManager.GetAnimals());
            if(newAdoption.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            shelterManager.LoadData();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            shelterManager.SaveData();
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

        private void TestUpdateListboxes()
        {
            if(shelterManager.GetCustomers() != null)
            {
                listBoxAdoptions.Items.Clear();
                foreach(Customer c in shelterManager.GetCustomers())
                {
                    listBoxAdoptions.Items.Add(c.Name);
                }
            }

            if (shelterManager.GetAnimals() != null)
            {
                listBoxAnimals.Items.Clear();
                foreach(Animal a in shelterManager.GetAnimals())
                {
                    string type = a.GetType().ToString().Split('.').Last();
                    listBoxAnimals.Items.Add(type + " " + a.Name + " Age: " + a.Age.ToString());
                }
            }
        }
    }
}
