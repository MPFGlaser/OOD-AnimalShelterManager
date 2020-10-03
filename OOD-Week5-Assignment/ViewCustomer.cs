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
    public partial class ViewCustomer : Form
    {
        private Customer customer;

        public ViewCustomer(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            ShowDetails();
        }

        // Shows all relevant details about the adoption in the various labels.
        private void ShowDetails()
        {
            labelCustomerName.Text = customer.Name;
            labelCustomerAddress.Text = customer.Address;
            labelCustomerZipcode.Text = customer.Zipcode;
            labelCustomerCity.Text = customer.City;
        }
    }
}
