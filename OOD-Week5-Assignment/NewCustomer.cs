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
    public partial class NewCustomer : Form
    {
        bool nameCorrect = false;
        bool addressCorrect = false;
        bool zipcodeCorrect = false;
        bool cityCorrect = false;

        public NewCustomer()
        {
            InitializeComponent();
            buttonConfirm.Enabled = false;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ConfirmButtonEnabler();
            if(textBoxName.Text != null)
            {
                this.Name = textBoxName.Text;
                nameCorrect = true;
            }
            else 
            { 
                nameCorrect = false;  
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            ConfirmButtonEnabler();
            if (textBoxAddress.Text != null)
            {
                this.Address = textBoxAddress.Text;
                addressCorrect = true;
            }
            else
            {
                addressCorrect = false;
            }
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            ConfirmButtonEnabler();
            if (textBoxZipCode.Text != null)
            {
                this.ZipCode = textBoxZipCode.Text;
                zipcodeCorrect = true;
            }
            else
            {
                zipcodeCorrect = false;
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            ConfirmButtonEnabler();
            if(textBoxCity.Text != null)
            {
                this.City = textBoxCity.Text;
                cityCorrect = true;
            }
            else
            {
                cityCorrect = false;
            }
        }

        private void ConfirmButtonEnabler()
        {
            if(nameCorrect && addressCorrect && zipcodeCorrect && cityCorrect)
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
