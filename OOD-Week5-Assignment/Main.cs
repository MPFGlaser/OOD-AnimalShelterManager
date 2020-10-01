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
    }
}
