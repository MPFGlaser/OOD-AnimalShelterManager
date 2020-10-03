using OOD_Week5_Assignment.Classes;
using OOD_Week5_Assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Week5_Assignment
{
    public partial class NewAnimal : Form
    {
        #region Fields and properties
        private bool nameCorrect;

        Regex regexName = new Regex(@"^([a-zA-Z]+\s?\b){1,}");

        public AnimalType Type { get; set; }
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public Models.Size AnimalSize { get; set; }
        public Gender AnimalGender { get; set; }
        public string Notes { get; set; }
        #endregion

        #region Logic
        public NewAnimal()
        {
            InitializeComponent();
            buttonConfirm.Enabled = false;
            labelSize.Visible = false;
            comboBoxSize.Visible = false;
            comboBoxAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            comboBoxSize.DataSource = Enum.GetValues(typeof(Models.Size));
            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
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

        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Sets all the properties to the appropriate values and exits with an OK result.
        private void Confirm()
        {
            this.Type = (AnimalType)comboBoxAnimalType.SelectedItem;
            this.AnimalName = textBoxName.Text;
            this.Age = Convert.ToInt32(numericUpDownAge.Value);
            this.AnimalSize = (Models.Size)comboBoxSize.SelectedItem;
            this.AnimalGender = (Gender)comboBoxGender.SelectedItem;
            this.Notes = richTextBoxNotes.Text;
            this.DialogResult = DialogResult.OK;
        }

        // Allows the user to select a size if the type of animal is Bird.
        private void AnimalTypeChanged()
        {
            if ((AnimalType)comboBoxAnimalType.SelectedItem == AnimalType.Bird)
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

        // Checks if the name entered conforms to the regex.
        private void NameChanged()
        {
            if (textBoxName.Text != "" && regexName.IsMatch(textBoxName.Text))
            {
                labelNameInvalid.Visible = false;
                this.AnimalName = textBoxName.Text;
                nameCorrect = true;
            }
            else
            {
                labelNameInvalid.Visible = true;
                nameCorrect = false;
            }
            ConfirmButtonEnabler();
        }
        #endregion

        #region Control event handlers
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void comboBoxAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalTypeChanged();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            NameChanged();
        }
        #endregion
    }
}
