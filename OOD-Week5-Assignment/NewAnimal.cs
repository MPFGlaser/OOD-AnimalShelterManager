﻿using OOD_Week5_Assignment.Classes;
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
    public partial class NewAnimal : Form
    {
        private bool typeCorrect;
        private bool nameCorrect;

        public NewAnimal()
        {
            InitializeComponent();
            buttonConfirm.Enabled = false;
            labelSize.Visible = false;
            comboBoxSize.Visible = false;
            comboBoxAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            comboBoxSize.DataSource = Enum.GetValues(typeof(Models.Size));
        }

        public AnimalType Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Models.Size AnimalSize { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboBoxAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnimalType.SelectedItem.ToString() == "Bird")
            {
                labelSize.Visible = true;
                comboBoxSize.Visible = true;
            }
            else
            {
                labelSize.Visible = false;
                comboBoxSize.Visible = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ConfirmButtonEnabler();
            if (textBoxName.Text != null)
            {
                this.Name = textBoxName.Text;
                nameCorrect = true;
            }
            else
            {
                nameCorrect = false;
            }
        }

        /// <summary>
        /// Checks if all fields are filled in, and if that is the case, it enables the confirm button.
        /// </summary>
        private void ConfirmButtonEnabler()
        {
            if (nameCorrect)
            {
                buttonConfirm.Enabled = true;
            }
            else
            {
                buttonConfirm.Enabled = false;
            }
        }
    }
}
