using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT CustomerID, CustomerName, ContactNo FROM Customers", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    CategoriesDatagrid.DataSource = DT;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTxtBox.Text.Trim();
            string contactNoText = ContactNoTxtBox.Text.Trim();

            if (!string.IsNullOrEmpty(customerName) && int.TryParse(contactNoText, out int contactNo))
            {
                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Customers (CustomerName, ContactNo) VALUES (@CustomerName, @ContactNo); SELECT SCOPE_IDENTITY()", con))
                    {
                        insertCommand.Parameters.AddWithValue("@CustomerName", customerName);
                        insertCommand.Parameters.AddWithValue("@ContactNo", contactNo);

                        int newCustomerId = Convert.ToInt32(insertCommand.ExecuteScalar());

                        MessageBox.Show($"Customer {customerName} added with ID {newCustomerId}.");
                    }
                }

                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Please enter valid customer name and contact number.");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (CategoriesDatagrid.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(CategoriesDatagrid.SelectedRows[0].Cells["CustomerID"].Value);
                string currentCustomerName = CategoriesDatagrid.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                string newCustomerName = CustomerNameTxtBox.Text.Trim();
                string contactNoText = ContactNoTxtBox.Text.Trim();

                if (!string.IsNullOrEmpty(newCustomerName) && int.TryParse(contactNoText, out int contactNo))
                {
                    using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                    {
                        con.Open();

                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Customers SET CustomerName = @NewCustomerName, ContactNo = @ContactNo WHERE CustomerID = @CustomerID", con))
                        {
                            updateCommand.Parameters.AddWithValue("@NewCustomerName", newCustomerName);
                            updateCommand.Parameters.AddWithValue("@ContactNo", contactNo);
                            updateCommand.Parameters.AddWithValue("@CustomerID", customerId);

                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    LoadCustomers();
                    MessageBox.Show($"Customer {currentCustomerName} updated to {newCustomerName}.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid new customer name and contact number.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (CategoriesDatagrid.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(CategoriesDatagrid.SelectedRows[0].Cells["CustomerID"].Value);
                string customerName = CategoriesDatagrid.SelectedRows[0].Cells["CustomerName"].Value.ToString();

                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", con))
                    {
                        deleteCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                LoadCustomers();
                MessageBox.Show($"Customer {customerName} with ID {customerId} deleted.");
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string searchKeyword = CustomerSearchBox.Text.Trim();

            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT CustomerID, CustomerName, ContactNo FROM Customers WHERE CustomerName LIKE @CustomerName", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", "%" + searchKeyword + "%");

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    CategoriesDatagrid.DataSource = DT;
                }
            }
        }
    }
}
