namespace Warehouse_Management_System
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IProductName = new System.Windows.Forms.TextBox();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.DescTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InventoryCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityInventoryNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInventoryNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearchProd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ProdSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProd.Image = global::Warehouse_Management_System.Properties.Resources.icons8_search_26;
            this.btnSearchProd.Location = new System.Drawing.Point(665, 4);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(132, 38);
            this.btnSearchProd.TabIndex = 3;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchProd.UseVisualStyleBackColor = false;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Warehouse_Management_System.Properties.Resources.icons8_exit_30;
            this.button1.Location = new System.Drawing.Point(949, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdSearchBox
            // 
            this.ProdSearchBox.Location = new System.Drawing.Point(378, 10);
            this.ProdSearchBox.Name = "ProdSearchBox";
            this.ProdSearchBox.Size = new System.Drawing.Size(270, 22);
            this.ProdSearchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Inventory";
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            this.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(115, 281);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersWidth = 51;
            this.ProductDataGrid.RowTemplate.Height = 24;
            this.ProductDataGrid.Size = new System.Drawing.Size(780, 223);
            this.ProductDataGrid.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name:";
            // 
            // IProductName
            // 
            this.IProductName.Location = new System.Drawing.Point(157, 72);
            this.IProductName.Name = "IProductName";
            this.IProductName.Size = new System.Drawing.Size(214, 22);
            this.IProductName.TabIndex = 18;
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(157, 157);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(214, 22);
            this.PriceTxtBox.TabIndex = 20;
            // 
            // DescTxtBox
            // 
            this.DescTxtBox.Location = new System.Drawing.Point(555, 63);
            this.DescTxtBox.Name = "DescTxtBox";
            this.DescTxtBox.Size = new System.Drawing.Size(214, 22);
            this.DescTxtBox.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 12);
            this.panel2.TabIndex = 23;
            // 
            // InventoryCategoryComboBox
            // 
            this.InventoryCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InventoryCategoryComboBox.FormattingEnabled = true;
            this.InventoryCategoryComboBox.Items.AddRange(new object[] {
            "Phone",
            "Laptop and Computers",
            "Phone Accesssories",
            "Computer Accessories",
            "Home Entertainment",
            ""});
            this.InventoryCategoryComboBox.Location = new System.Drawing.Point(555, 114);
            this.InventoryCategoryComboBox.Name = "InventoryCategoryComboBox";
            this.InventoryCategoryComboBox.Size = new System.Drawing.Size(242, 24);
            this.InventoryCategoryComboBox.TabIndex = 24;
            // 
            // QuantityInventoryNumericUpDown1
            // 
            this.QuantityInventoryNumericUpDown1.AutoSize = true;
            this.QuantityInventoryNumericUpDown1.Location = new System.Drawing.Point(157, 114);
            this.QuantityInventoryNumericUpDown1.Name = "QuantityInventoryNumericUpDown1";
            this.QuantityInventoryNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.QuantityInventoryNumericUpDown1.TabIndex = 25;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = global::Warehouse_Management_System.Properties.Resources.icons8_delete_24;
            this.btnDeleteProduct.Location = new System.Drawing.Point(553, 220);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(117, 42);
            this.btnDeleteProduct.TabIndex = 17;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Image = global::Warehouse_Management_System.Properties.Resources.icons8_update_24;
            this.btnUpdateProduct.Location = new System.Drawing.Point(435, 220);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(112, 42);
            this.btnUpdateProduct.TabIndex = 16;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProduct.Image = global::Warehouse_Management_System.Properties.Resources.icons8_add_24;
            this.btnInsertProduct.Location = new System.Drawing.Point(326, 220);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(103, 42);
            this.btnInsertProduct.TabIndex = 4;
            this.btnInsertProduct.Text = "Insert";
            this.btnInsertProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertProduct.UseVisualStyleBackColor = false;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.warehouse1;
            this.ClientSize = new System.Drawing.Size(1056, 620);
            this.Controls.Add(this.QuantityInventoryNumericUpDown1);
            this.Controls.Add(this.InventoryCategoryComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DescTxtBox);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.IProductName);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnInsertProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInventoryNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.TextBox ProdSearchBox;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox IProductName;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox DescTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox InventoryCategoryComboBox;
        private System.Windows.Forms.NumericUpDown QuantityInventoryNumericUpDown1;
    }
}