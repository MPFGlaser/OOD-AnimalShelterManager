﻿using OOD_Week5_Assignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOD_Week5_Assignment
{
    public partial class Main : Form
    {
        private NewAnimal newAnimal;
        private NewCustomer newCustomer;
        private NewAdoption newAdoption;
        private ViewAdoption viewAdoption;
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
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("../../ShelterData.txt", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                shelterManager = (ShelterManager)(bf.Deserialize(fs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
            UpdateListboxes();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Save data
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("../../ShelterData.txt", FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, shelterManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void buttonAdoptionInfo_Click(object sender, EventArgs e)
        {
            if(listBoxAdoptions.SelectedIndex != -1)
            {
                viewAdoption = new ViewAdoption((listBoxAdoptions.SelectedItem as dynamic).Value);
                viewAdoption.ShowDialog();
            }
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
