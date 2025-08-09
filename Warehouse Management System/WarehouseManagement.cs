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
    public partial class WarehouseManagement : Form
    {
        public WarehouseManagement()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show(); 
           
        }
        /*
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();  
            customers.Show();
        }
        */
    }
}
