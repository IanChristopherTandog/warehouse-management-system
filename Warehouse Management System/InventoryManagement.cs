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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            
            btnInventory.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnInventory_Leave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCategory_Leave(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOrders_Leave(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomers_Leave(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
