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
        private string name;
        private string address;
        private string zipcode;
        private string city;

        public NewCustomer()
        {
            InitializeComponent();
        }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCity { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.name = textBoxName.Text;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            this.address = textBoxAddress.Text;
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            this.zipcode = textBoxZipCode.Text;
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            this.city = textBoxCity.Text;
        }
    }
}
