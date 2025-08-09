using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    
    // Inside the TestingCategories class
    public partial class TestingCategories : Form
    {
        public TestingCategories()
        {
            InitializeComponent();
            LoadCategories(testingCategoryComboBox);  // Load categories when the form is created
        }
        // Define LoadCategories method
        public void LoadCategories(ComboBox comboBox)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    // Clear existing items
                    comboBox.Items.Clear();

                    // Populate ComboBox with CategoryName values
                    foreach (DataRow row in DT.Rows)
                    {
                        comboBox.Items.Add(row["CategoryName"].ToString());
                    }
                }
            }
        }

        // Make testingCategorycomboBox1 public or internal
        public ComboBox testingCategoryComboBox // Change the property name
        {
            get { return testingCategorycomboBox1; }
            set { testingCategorycomboBox1 = value; }
        }

        // Other code...
    }
}
