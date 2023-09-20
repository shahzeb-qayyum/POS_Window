using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Databaselayer;
using PointOfSale.Model;
using System.Windows.Forms;

namespace PointOfSale.Databaselayer
{
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool shouldSave = true;
            Customer mycustomer = new Customer();
            if (txtFirstName.Text == string.Empty)
            {

                MessageBox.Show("please enter firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else
            {
                mycustomer.Firstname = txtFirstName.Text;
            }
            if (txtLastName.Text == string.Empty)
            {

                MessageBox.Show("please enter lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else
            {
                mycustomer.Lastname = txtLastName.Text;
            }
            if (txtEmail.Text == string.Empty)
            {

                MessageBox.Show("please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else
            {
                mycustomer.Email = txtEmail.Text;
            }
            if (txtDateofbirth.Text == string.Empty)
            {

                MessageBox.Show("please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateofbirth.Focus();
            }
            else
            {
                mycustomer.Dateofbirth = txtDateofbirth.Text;
            }
            if (txtPhone.Text == string.Empty)
            {

                MessageBox.Show("please enter phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else
            {
                mycustomer.Phone = txtPhone.Text;
            }
            if (txtStreet.Text == string.Empty)
            {

                MessageBox.Show("please enter street", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
            }
            else
            {
                mycustomer.Street = txtStreet.Text;
            }
            if (txtCity.Text == string.Empty)
            {

                MessageBox.Show("please enter city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
            }
            else
            {
                mycustomer.City = txtCity.Text;
            }
            if (txtHouseno.Text == string.Empty)
            {

                MessageBox.Show("please enter House_no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
            }
            else
            {
                mycustomer.House_no = txtHouseno.Text;
            }
            if (shouldSave == true)
            {
                Clustomrrepository repo = new Clustomrrepository();
                bool result = repo.Insert(mycustomer);
                if (result)
                {
                    MessageBox.Show("customer data addded sucessfully", "Customer added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }




        }

        private void clearform()
        {
            this.txtFirstName.Text= string.Empty;
            this.txtLastName.Text= string.Empty;
            this.txtDateofbirth.Text= string.Empty;
            this.txtEmail.Text= string.Empty;
            this.txtHouseno.Text= string.Empty;
            this.txtStreet.Text= string.Empty;
            this.txtCity.Text= string.Empty;

        }
    }
   
    

}
