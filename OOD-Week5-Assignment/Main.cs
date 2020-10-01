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

        private void button1_Click(object sender, EventArgs e)
        {
            newAnimal = new NewAnimal();
            newAnimal.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newCustomer = new NewCustomer();
            if(newCustomer.ShowDialog() == DialogResult.OK)
            {
                shelterManager.AddCustomer(newCustomer.CustomerName, newCustomer.CustomerAddress, newCustomer.CustomerZipCode, newCustomer.CustomerCity) ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newAdoption = new NewAdoption(shelterManager.GetCustomers(), shelterManager.GetAnimals());
            newAdoption.Show(this);
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
    }
}
