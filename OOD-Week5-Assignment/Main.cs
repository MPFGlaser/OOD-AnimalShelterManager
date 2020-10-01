﻿using System;
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

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newAnimal = new NewAnimal();
            newAnimal.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newCustomer = new NewCustomer();
            newCustomer.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newAdoption = new NewAdoption();
            newAdoption.Show(this);
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {

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
