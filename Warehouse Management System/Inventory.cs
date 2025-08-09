using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            LoadCategories(InventoryCategoryComboBox);  // Load categories when the form is created

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ProductDataGrid.SelectionChanged += ProductDataGrid_SelectionChanged;

            // Load initial data into the DataGridView
            LoadInventoryData();
        }
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
        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            

            string ProductName = IProductName.Text;
            string QuantityInventory = Convert.ToInt32(QuantityInventoryNumericUpDown1.Value).ToString();
            string Price = PriceTxtBox.Text;
            string Descr = DescTxtBox.Text;
            string Category = InventoryCategoryComboBox.Text;

            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                // Check if the product with the same name already exists
                using (SqlCommand checkCommand = new SqlCommand("SELECT ProductID, Quantity FROM Inventory WHERE ProductName = @ProductName", con))
                {
                    checkCommand.Parameters.AddWithValue("@ProductName", ProductName);

                    SqlDataReader reader = checkCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Product already exists, update the quantity
                        int existingProductID = reader.GetInt32(0);
                        int existingQuantity = reader.GetInt32(1);

                        int newQuantity = existingQuantity + Convert.ToInt32(QuantityInventoryNumericUpDown1.Value);

                        reader.Close();

                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Inventory SET Quantity = @Quantity WHERE ProductID = @ProductID", con))
                        {
                            updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                            updateCommand.Parameters.AddWithValue("@ProductID", existingProductID);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show($"Quantity of product {ProductName} updated.");
                        }
                    }
                    else
                    {
                        reader.Close();

                        // Product does not exist, inse rt a new product
                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Inventory (ProductName, Quantity, Price, Description, Category) VALUES (@ProductName, @Quantity, @Price, @Descr, @Category); SELECT SCOPE_IDENTITY()", con))
                        {
                            insertCommand.Parameters.AddWithValue("@ProductName", ProductName);
                            insertCommand.Parameters.AddWithValue("@Quantity", QuantityInventoryNumericUpDown1.Value);
                            
                            
                            if (int.TryParse(PriceTxtBox.Text, out int price))
                            {
                                insertCommand.Parameters.AddWithValue("@Price", price);
                            }
                            else
                            {
                                // Handle the case where the input is not a valid integer 
                                MessageBox.Show("Please enter a valid integer for the Price.");
                                return; // exit the method without executing the insert
                            }

                            insertCommand.Parameters.AddWithValue("@Descr", Descr);
                            insertCommand.Parameters.AddWithValue("@Category", Category);

                            int newProductID = Convert.ToInt32(insertCommand.ExecuteScalar());

                            MessageBox.Show($"Product {ProductName} with ID {newProductID} saved.");
                        }
                    }
                }

                // Reload data into the DataGridView
                using (SqlCommand selectCommand = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    
                      ProductDataGrid.DataSource = DT;
                }
            }

            // Clear input fields after saving
            IProductName.Clear();
            QuantityInventoryNumericUpDown1.Value = 0;
            PriceTxtBox.Clear();
            DescTxtBox.Clear();
            InventoryCategoryComboBox.Text = "";
        }
        /*
        private void ProductDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGrid.SelectedRows[0];

                IProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                QuantityInventoryNumericUpDown1.Value = Convert.ToDecimal(selectedRow.Cells["Quantity"].Value);
                PriceTxtBox.Text = selectedRow.Cells["Price"].Value?.ToString();
                DescTxtBox.Text = selectedRow.Cells["Description"].Value?.ToString();
                InventoryCategoryComboBox.Text = selectedRow.Cells["Category"].Value?.ToString();
            }
        }
        */
        private void ProductDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGrid.SelectedRows[0];

                IProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString();

                // Check if the "Quantity" cell value is not DBNull before converting
                object quantityCellValue = selectedRow.Cells["Quantity"].Value;

                if (quantityCellValue != DBNull.Value && quantityCellValue != null)
                {
                    QuantityInventoryNumericUpDown1.Value = Convert.ToDecimal(quantityCellValue);
                }
                else
                {
                    QuantityInventoryNumericUpDown1.Value = 0; // or any other default value
                }

                PriceTxtBox.Text = selectedRow.Cells["Price"].Value?.ToString();
                DescTxtBox.Text = selectedRow.Cells["Description"].Value?.ToString();
                InventoryCategoryComboBox.Text = selectedRow.Cells["Category"].Value?.ToString();
            }
        }



        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(ProductDataGrid.SelectedRows[0].Cells["ProductID"].Value);

                // Get the updated values from the user input
                string updatedProductName = IProductName.Text;
                int updatedQuantity = Convert.ToInt32(QuantityInventoryNumericUpDown1.Value);

                // Use Convert.ToInt32 directly for Price
                int updatedPrice;
                if (int.TryParse(PriceTxtBox.Text, out updatedPrice))
                {
                    // Update the product in the database
                    using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                    {
                        con.Open();

                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Inventory SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price, Description = @Descr, Category = @Category WHERE ProductID = @ProductID", con))
                        {
                            updateCommand.Parameters.AddWithValue("@ProductName", updatedProductName);
                            updateCommand.Parameters.AddWithValue("@Quantity", updatedQuantity);
                            updateCommand.Parameters.AddWithValue("@Price", updatedPrice);
                            updateCommand.Parameters.AddWithValue("@Descr", DescTxtBox.Text);
                            updateCommand.Parameters.AddWithValue("@Category", InventoryCategoryComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@ProductID", productId);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show($"Product {updatedProductName} with ID {productId} updated.");
                        }

                        // Reload data into the DataGridView
                        using (SqlCommand selectCommand = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory", con))
                        {
                            SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                            DataTable DT = new DataTable();
                            DA.Fill(DT);

                            ProductDataGrid.DataSource = DT;
                        }
                    }

                    // Clear input fields after updating
                    IProductName.Clear();
                    QuantityInventoryNumericUpDown1.Value = 0;
                    PriceTxtBox.Clear();
                    DescTxtBox.Clear();
                    InventoryCategoryComboBox.Text = "";
                }
                else
                {
                    // Handle the case where the input is not a valid integer
                    MessageBox.Show("Please enter a valid integer for the Price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }




        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                // Assuming your primary key column in the database is named "ProductID"
                int productId = Convert.ToInt32(ProductDataGrid.SelectedRows[0].Cells["ProductID"].Value);

                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE ProductID = @ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.ExecuteNonQuery();
                    }

                    // Reload data into the DataGridView
                    using (SqlCommand selectCommand = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory", con))
                    {
                        SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                        DataTable DT = new DataTable();
                        DA.Fill(DT);

                        ProductDataGrid.DataSource = DT;
                    }
                }

                MessageBox.Show("Product Deleted");
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                string searchKeyword = ProdSearchBox.Text.Trim();

                // Check if the search keyword is numeric to determine whether it's a Product ID search
                if (int.TryParse(searchKeyword, out int productId))
                {
                    // Search by Product ID
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory WHERE ProductID = @ProductId", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataTable DT = new DataTable();
                        DA.Fill(DT);

                        ProductDataGrid.DataSource = DT;
                    }
                }
                else
                {
                    // Search by Product Name
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory WHERE ProductName LIKE @ProductName", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", "%" + searchKeyword + "%");

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataTable DT = new DataTable();
                        DA.Fill(DT);

                        ProductDataGrid.DataSource = DT;
                    }
                }
            }
        }
        private void LoadInventoryData()
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    ProductDataGrid.DataSource = DT;
                }
            }
        }
        public void SetCategoryComboBoxDataSource(DataTable dataSource)
        {
            InventoryCategoryComboBox.DataSource = dataSource;
            InventoryCategoryComboBox.DisplayMember = "CategoryName";
        }
    }
}