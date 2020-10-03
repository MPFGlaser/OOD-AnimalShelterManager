using OOD_Week5_Assignment.Classes;
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
        private ViewAnimal viewAnimal;
        private ViewCustomer viewCustomer;
        private ShelterManager shelterManager;

        #region Logic
        public Main()
        {
            InitializeComponent();
            shelterManager = new ShelterManager();
            UpdateListboxes();
        }

        // Updates the Adoptions and Animals listboxes, assuming there is data to populate them.
        private void UpdateListboxes()
        {
            if (shelterManager.Adoptions != null)
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

                if (checkBoxShowAdopted.Checked)
                {
                    foreach (Animal a in shelterManager.Animals)
                    {
                        if (a.Adopted)
                        {
                            listBoxAnimals.Items.Add(new { Text = a.ToString() + " [Adopted]", Value = a });
                        }
                        else
                        {
                            listBoxAnimals.Items.Add(new { Text = a.ToString(), Value = a });
                        }
                    }
                }
                else
                {
                    foreach (Animal a in shelterManager.Animals)
                    {
                        if (!a.Adopted)
                        {
                            listBoxAnimals.Items.Add(new { Text = a.ToString(), Value = a });
                        }
                    }
                }
            }
        }

        // Shows a dialog with data fields to add a new animal to the system
        private void CreateAnimal()
        {
            newAnimal = new NewAnimal();
            if (newAnimal.ShowDialog() == DialogResult.OK)
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

        // Shows a dialog with data fields to add a new customer to the system
        private void CreateCustomer()
        {
            newCustomer = new NewCustomer();
            if (newCustomer.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddCustomer(newCustomer.CustomerName, newCustomer.Address, newCustomer.ZipCode, newCustomer.City);
            }
            UpdateListboxes();
        }

        // Shows a dialog with data fields to add a new adoption to the system
        private void CreateAdoption()
        {
            newAdoption = new NewAdoption(shelterManager.Customers, shelterManager.Animals);
            if (newAdoption.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddAdoption(newAdoption.AdoptedAnimals, newAdoption.AdoptionCustomer, newAdoption.AdoptionMoment, newAdoption.AdoptionFee);
            }
            UpdateListboxes();
        }

        // Loads the shelter data from a binary file
        private void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "../../";
                openFileDialog.Filter = "Shelter files (*.bin)|*.bin";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                        bf = new BinaryFormatter();
                        shelterManager = (ShelterManager)(bf.Deserialize(fs));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    }
                    UpdateListboxes();
                }
            }
        }

        // Saves the shelter data to a binary file
        private void SaveData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "../../";
            saveFileDialog1.Filter = "Shelter files (*.bin)|*.bin";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
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
        }

        // Shows a popup window with information about the adoption selected in the listbox
        private void ShowAdoptionInfo()
        {
            if (listBoxAdoptions.SelectedIndex != -1)
            {
                viewAdoption = new ViewAdoption((listBoxAdoptions.SelectedItem as dynamic).Value);
                viewAdoption.ShowDialog();
            }
        }

        // Shows a popup window with information about the animal selected in the listbox
        private void ShowAnimalInfo()
        {
            if (listBoxAnimals.SelectedIndex != -1)
            {
                viewAnimal = new ViewAnimal((listBoxAnimals.SelectedItem as dynamic).Value);
                viewAnimal.ShowDialog();
            }
        }
        #endregion

        #region Control event handlers
        private void buttonNewAnimal_Click(object sender, EventArgs e)
        {
            CreateAnimal();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }

        private void buttonNewAdoption_Click(object sender, EventArgs e)
        {
            CreateAdoption();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void buttonAdoptionInfo_Click(object sender, EventArgs e)
        {
            ShowAdoptionInfo();
        }

        private void buttonAnimalInfo_Click(object sender, EventArgs e)
        {
            ShowAnimalInfo();
        }

        private void checkBoxShowAdopted_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListboxes();
        }
        #endregion
    }
}
