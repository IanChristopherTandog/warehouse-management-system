using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPassword.UseSystemPasswordChar = true;
        }

      /*  private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignUp signUp = new SignUp();
            signUp.Show();
            
        } */

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = lblUserName.Text;
            string password = lblPassword.Text;

            // Check if the username and password are correct
            if (userName == "Admin" && password == "admin")
            {
                MessageBox.Show("Log in Successful", "Confirmation");

                // Clear the input fields
                lblUserName.Clear();
                lblPassword.Clear();

                // Close the login form
                this.Hide();

                // Open the InventoryManagement form
                WarehouseManagement inventory = new WarehouseManagement();
                inventory.Show();
            }
            
            else
            {
                // Display a message box for incorrect credentials
                MessageBox.Show("Incorrect/Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the input fields
                lblUserName.Clear();
                lblPassword.Clear();
            }
        }





        private void lblUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
