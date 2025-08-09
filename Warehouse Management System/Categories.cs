using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            CategoriesDatagrid.SelectionChanged += CategoryDataGrid_SelectionChanged;
            LoadCategories();

        }
        public void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM Categories", con))
                {
                    SqlDataAdapter DA = new SqlDataAdapter(selectCommand);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    CategoriesDatagrid.DataSource = DT;
                }
            }
        }
        private void CategoryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (CategoriesDatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CategoriesDatagrid.SelectedRows[0];

                CategoryName.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
         
            }
        }
       
        //exit button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryName.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    // Check if the category already exists
                    using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Categories WHERE CategoryName = @CategoryName", con))
                    {
                        checkCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                        int existingCategoryCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCategoryCount > 0)
                        {
                            MessageBox.Show($"Category '{categoryName}' already exists. Please choose a different name.");
                            return; // Do not proceed with the insertion
                        }
                    }

                    // Insert the category if it doesn't exist
                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@CategoryName); SELECT SCOPE_IDENTITY()", con))
                    {
                        insertCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                        int newCategoryId = Convert.ToInt32(insertCommand.ExecuteScalar());

                        LoadCategories();
                        MessageBox.Show($"Category {categoryName} added with ID {newCategoryId}.");
                        CategoryName.Clear();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }


        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (CategoriesDatagrid.SelectedRows.Count > 0)
            {
                string currentCategoryName = CategoriesDatagrid.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                string newCategoryName = CategoryName.Text.Trim();

                if (!string.IsNullOrEmpty(newCategoryName))
                {
                    using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                    {
                        con.Open();

                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Categories SET CategoryName = @NewCategoryName WHERE CategoryName = @CurrentCategoryName", con))
                        {
                            updateCommand.Parameters.AddWithValue("@NewCategoryName", newCategoryName);
                            updateCommand.Parameters.AddWithValue("@CurrentCategoryName", currentCategoryName);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    LoadCategories(); 
                    MessageBox.Show($"Category {currentCategoryName} updated to {newCategoryName}.");

                    CategoryName.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a new category name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }


        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryName.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
                {
                    con.Open();

                    // Implement your delete logic here
                    using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Categories WHERE CategoryName = @CategoryName", con))
                    {
                        deleteCommand.Parameters.AddWithValue("@CategoryName", categoryName);

                        // Execute the delete query
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadCategories();
                            MessageBox.Show($"Category {categoryName} deleted successfully.");
                            CategoryName.Clear();
                        }
                        else
                        {
                            MessageBox.Show($"Category '{categoryName}' not found. No deletions were made.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }


        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string searchKeyword = CategoriesSearchBox.Text.Trim();

            using (SqlConnection con = new SqlConnection("data source = IAN\\SQLEXPRESS; database = Warehouse; integrated security = true"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories WHERE CategoryName LIKE @CategoryName OR CategoryID LIKE @CategoryID", con))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", "%" + searchKeyword + "%");
                    cmd.Parameters.AddWithValue("@CategoryID","%" + searchKeyword + "%");

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    CategoriesDatagrid.DataSource = DT;
                }
            }
        }
        //Ginamet lang to pan testing sa insert into InventoryCategoryombobox
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the TestingCategories form
          //  TestingCategories testingCategoriesForm = new TestingCategories();

            // Show the form as a dialog
          //  testingCategoriesForm.ShowDialog();
        }
    }
}
