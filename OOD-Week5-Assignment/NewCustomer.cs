using OOD_Week5_Assignment.Classes;
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
    public partial class NewCustomer : Form
    {
        #region Fields and properties
        bool nameCorrect = false;
        bool addressCorrect = false;
        bool zipcodeCorrect = false;
        bool cityCorrect = false;

        // Based on the Dutch formats (https://murani.nl/blog/2015-09-28/nederlandse-reguliere-expressies/)
        Regex regexName = new Regex(@"^([a-zA-Z]+\s?\b){2,}");
        Regex regexAddress = new Regex(@"^([1-9][e][\s])*([a-zA-Z]+(([\.][\s])|([\s]))?)+[1-9][0-9]*(([-][1-9][0-9]*)|([\s]?[a-zA-Z]+))?$");
        Regex regexZipCode = new Regex(@"^[1-9][0-9]{3}[\s]?[A-Za-z]{2}$");
        Regex regexCity = new Regex(@"^([a-zA-Z]+\s?\b){1,}");

        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        #endregion

        #region Logic
        public NewCustomer()
        {
            InitializeComponent();
            buttonConfirm.Enabled = false;
        }

        /// <summary>
        /// Checks if all fields are filled in, and if that is the case, it enables the confirm button.
        /// </summary>
        private void ConfirmButtonEnabler()
        {
            if (nameCorrect && addressCorrect && zipcodeCorrect && cityCorrect)
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

        private void Confirm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        // Checks if the name entered in the textbox confirms to the regex and lets the user know if that is not the case.
        private void NameChanged()
        {
            if (textBoxName.Text != "" && regexName.IsMatch(textBoxName.Text))
            {
                this.CustomerName = textBoxName.Text;
                labelNameInvalid.Visible = false;
                nameCorrect = true;
            }
            else
            {
                labelNameInvalid.Visible = true;
                nameCorrect = false;
            }
            ConfirmButtonEnabler();
        }

        // Checks if the address entered in the textbox confirms to the regex and lets the user know if that is not the case.
        private void AddressChanged()
        {
            if (textBoxAddress.Text != "" && regexAddress.IsMatch(textBoxAddress.Text))
            {
                labelAddressInvalid.Visible = false;
                this.Address = textBoxAddress.Text;
                addressCorrect = true;
            }
            else
            {
                labelAddressInvalid.Visible = true;
                addressCorrect = false;
            }
            ConfirmButtonEnabler();
        }

        // Checks if the zipcode entered in the textbox confirms to the regex and lets the user know if that is not the case.
        private void ZipCodeChanged()
        {
            if (textBoxZipCode.Text != "" && regexZipCode.IsMatch(textBoxZipCode.Text))
            {
                labelZipCodeInvalid.Visible = false;
                this.ZipCode = textBoxZipCode.Text;
                zipcodeCorrect = true;
            }
            else
            {
                labelZipCodeInvalid.Visible = true;
                zipcodeCorrect = false;
            }
            ConfirmButtonEnabler();
        }

        // Checks if the city entered in the textbox confirms to the regex and lets the user know if that is not the case.
        private void CityChanged()
        {
            if (textBoxCity.Text != "" && regexCity.IsMatch(textBoxCity.Text))
            {
                labelCityInvalid.Visible = false;
                this.City = textBoxCity.Text;
                cityCorrect = true;
            }
            else
            {
                labelCityInvalid.Visible = true;
                cityCorrect = false;
            }
            ConfirmButtonEnabler();
        }
        #endregion

        #region Control event handlers
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            NameChanged();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            AddressChanged();
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            ZipCodeChanged();
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            CityChanged();
        }
        #endregion
    }
}
