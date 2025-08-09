using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Orders : Form
    {
        
        public Orders()
        {
            InitializeComponent();
            LoadInventoryData();
            LoadOrders();
            ProductDataGrid.SelectionChanged += ProductDataGrid_SelectionChanged;
            OrdersDataGrid.SelectionChanged += OrderDataGrid_SelectionChanged;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            // Check if the customer name is empty
            if (string.IsNullOrWhiteSpace(IProductName.Text) || string.IsNullOrWhiteSpace(DescTxtBox.Text) || string.IsNullOrWhiteSpace(InventoryCategoryComboBox.Text) || string.IsNullOrWhiteSpace(PriceTxtBox.Text))
            {
                MessageBox.Show("Please choose a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding
            }
            else if (string.IsNullOrWhiteSpace(CustomerNameTxtBox.Text))
            {
                MessageBox.Show("Please enter a customer name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding
            }
            else if (QuantityInventoryNumericUpDown1.Value == 0)
            {
                MessageBox.Show("Please enter the quantity of your order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding
            }
            string customerName = CustomerNameTxtBox.Text.Trim();
            string productName = IProductName.Text;
            string category = InventoryCategoryComboBox.Text;
            int price = Convert.ToInt32(PriceTxtBox.Text);
            int quantity = Convert.ToInt32(QuantityInventoryNumericUpDown1.Value);

            // Calculate the total
            int total = price * quantity;

            // Check if there is enough stock
            int availableStock = GetProductStock(productName);
            if (quantity > availableStock)
            {
                MessageBox.Show($"Not enough stock for product {productName}. Available stock: {availableStock}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method since there is not enough stock
            }

            // Check if the same customer has already ordered the same product
            if (OrderExists(customerName, productName))
            {
                // Update the order quantity for the same customer and product
                UpdateOrderQuantity(customerName, productName, quantity);
            }
            else
            {
                // Update the product quantity in the ProductDatagrid
                UpdateProductQuantity(productName, availableStock - quantity);

                // Insert order into the database
                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Orders (CustomerName, ProductName, Category, Price, Quantity, Total) VALUES (@CustomerName, @ProductName, @Category, @Price, @Quantity, @Total)", con))
                    {
                        insertCommand.Parameters.AddWithValue("@CustomerName", customerName);
                        insertCommand.Parameters.AddWithValue("@ProductName", productName);
                        insertCommand.Parameters.AddWithValue("@Category", category);
                        insertCommand.Parameters.AddWithValue("@Price", price);
                        insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertCommand.Parameters.AddWithValue("@Total", total);

                        insertCommand.ExecuteNonQuery();
                    }
                }
            }

            LoadOrders();
            LoadInventoryData();
            ClearOrderFields();

            // Show a message indicating that the order for the customer is added
            MessageBox.Show($"Order for customer {customerName} added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool OrderExists(string customerName, string productName)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE CustomerName = @CustomerName AND ProductName = @ProductName", con))
                {
                    selectCommand.Parameters.AddWithValue("@CustomerName", customerName);
                    selectCommand.Parameters.AddWithValue("@ProductName", productName);

                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void UpdateOrderQuantity(string customerName, string productName, int additionalQuantity)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand updateCommand = new SqlCommand("UPDATE Orders SET Quantity = Quantity + @AdditionalQuantity WHERE CustomerName = @CustomerName AND ProductName = @ProductName", con))
                {
                    updateCommand.Parameters.AddWithValue("@AdditionalQuantity", additionalQuantity);
                    updateCommand.Parameters.AddWithValue("@CustomerName", customerName);
                    updateCommand.Parameters.AddWithValue("@ProductName", productName);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }


        private int GetProductStock(string productName)
        {
            int stock = 0;

            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT Quantity FROM Inventory WHERE ProductName = @ProductName", con))
                {
                    selectCommand.Parameters.AddWithValue("@ProductName", productName);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        stock = reader.GetInt32(0);
                    }

                    reader.Close();
                }
            }

            return stock;
        }

        private void UpdateProductQuantity(string productName, int newQuantity)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand updateCommand = new SqlCommand("UPDATE Inventory SET Quantity = @Quantity WHERE ProductName = @ProductName", con))
                {
                    updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                    updateCommand.Parameters.AddWithValue("@ProductName", productName);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }



        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (OrdersDataGrid.SelectedRows.Count > 0)
            {
                // Get the order ID from the selected row
                int orderId = Convert.ToInt32(OrdersDataGrid.SelectedRows[0].Cells["OrderId"].Value);

                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed, proceed with deletion
                    using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                    {
                        con.Open();

                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Orders WHERE OrderId = @OrderId", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@OrderId", orderId);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }

                    LoadOrders();
                    ClearOrderFields();
                }
                // If the user clicks No, do nothing
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }


        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            string searchKeyword = OrderSearchBox.Text.Trim();

            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT OrderId, CustomerName, ProductName, Category, Price, Quantity, Quantity * Price AS Total FROM Orders WHERE CustomerName LIKE @CustomerName", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", "%" + searchKeyword + "%");

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    OrdersDataGrid.DataSource = DT;
                }
            }
        }

        private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT OrderId, CustomerName, ProductName, Category, Price, Quantity, Quantity * Price AS Total FROM Orders", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    OrdersDataGrid.DataSource = DT;
                }
            }
        }

        private void LoadInventoryData()
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT ProductName, Quantity, Price,Description, Category FROM Inventory", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    ProductDataGrid.DataSource = DT;
                }
            }
        }
        /*
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
        */
        private void Orders_Load(object sender, EventArgs e)
        {
       //     LoadInventoryData();
        }

        private void OrdersQuantityNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Recalculate the total when the quantity changes
        //    int price = Convert.ToInt32(PriceTxtBox.Text);
        //    int quantity = Convert.ToInt32(OrdersQuantityNumericUpDown1.Value);
         //   int total = price * quantity;

          //TotalBox1.Text = total.ToString();
    //       UpdateTotal();
        }
        /*
        private void OrderDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGrid.SelectedRows[0];

                // Assuming you have columns named "CustomerName", "ProductName", "Category", "Price", "Quantity", "Total" in your DataGridView
                string customerName = selectedRow.Cells["CustomerName"].Value?.ToString();
                string productName = selectedRow.Cells["ProductName"].Value?.ToString();
                string category = selectedRow.Cells["Category"].Value?.ToString();
                int price = Convert.ToInt32(selectedRow.Cells["Price"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                // Populate the textboxes
                CustomerNameTxtBox.Text = customerName;
             //   ProductName.Text = productName;
            //    CategoryComboBox1.Text = category;
            //    PriceTxtBox.Text = price.ToString();
           //     OrdersQuantityNumericUpDown1.Value = quantity;

                // Calculate and display the total
                int total = price * quantity;
              //  TotalBox1.Text = total.ToString();
            }
        }
        */

        private void ClearOrderFields()
        {
            // Clear the textboxes and numeric up-down
            CustomerNameTxtBox.Clear();
            IProductName.Clear();
            QuantityInventoryNumericUpDown1.Text = "";
            PriceTxtBox.Clear();
            DescTxtBox.Clear();
            InventoryCategoryComboBox.Text = "";
            //TotalBox1.Clear();
        }
        private void PriceTxtBox_TextChanged(object sender, EventArgs e)
    {
        // Recalculate the total when the price changes
       // UpdateTotal();
    }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                string searchKeyword = ProdSearchBox.Text.Trim();

                // Search by Product Name or Category
                using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, Quantity, Price, Description, Category FROM Inventory WHERE ProductName LIKE @SearchKeyword OR Category LIKE @SearchKeyword", con))
                {
                    cmd.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    ProductDataGrid.DataSource = DT;
                }
            }
        }


        private void RefreshStocks_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            LoadOrders();   
        }
        private void ProductDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGrid.SelectedRows[0];

                IProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString();



                PriceTxtBox.Text = selectedRow.Cells["Price"].Value?.ToString();
                DescTxtBox.Text = selectedRow.Cells["Description"].Value?.ToString();
                InventoryCategoryComboBox.Text = selectedRow.Cells["Category"].Value?.ToString();
            }
        }

        private void OrderDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (OrdersDataGrid.SelectedRows.Count > 0)
            {
                int totalQuantity = 0;
                decimal totalPrice = 0;

                foreach (DataGridViewRow selectedRow in OrdersDataGrid.SelectedRows)
                {
                    // Assuming your columns are named "Quantity" and "Price"
                    int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                    totalQuantity += quantity;
                    totalPrice += quantity * price;
                }

                // Set the textboxes with the total quantities and total prices
                // You can adjust the names as needed based on your actual textbox names
                TotalQuantity.Text = totalQuantity.ToString() + " pc(s)";  // Set the text property of the textbox
                TotalPrice.Text = "₱ " + totalPrice.ToString();
            }
        }
        private void btnUpdateOrde_Click(object sender, EventArgs e)
        {

        }

        private void RefreshOrders_Click_1(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
