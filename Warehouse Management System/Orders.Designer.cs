namespace Warehouse_Management_System
{
    partial class Orders
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderSearchBox = new System.Windows.Forms.TextBox();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.ProdSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.RefreshStocks = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Stocks = new System.Windows.Forms.Button();
            this.QuantityInventoryNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.InventoryCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DescTxtBox = new System.Windows.Forms.TextBox();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.IProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalQuantity = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInventoryNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 632);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 12);
            this.panel2.TabIndex = 39;
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(144, 369);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.CustomerNameTxtBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer Name:";
            // 
            // OrderSearchBox
            // 
            this.OrderSearchBox.Location = new System.Drawing.Point(715, 105);
            this.OrderSearchBox.Multiline = true;
            this.OrderSearchBox.Name = "OrderSearchBox";
            this.OrderSearchBox.Size = new System.Drawing.Size(279, 38);
            this.OrderSearchBox.TabIndex = 1;
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            this.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(12, 156);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersWidth = 51;
            this.ProductDataGrid.RowTemplate.Height = 24;
            this.ProductDataGrid.Size = new System.Drawing.Size(662, 207);
            this.ProductDataGrid.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 45);
            this.panel1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Warehouse_Management_System.Properties.Resources.icons8_exit_30;
            this.button1.Location = new System.Drawing.Point(1476, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrders.Image = global::Warehouse_Management_System.Properties.Resources.icons8_search_26;
            this.btnSearchOrders.Location = new System.Drawing.Point(1000, 105);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(132, 38);
            this.btnSearchOrders.TabIndex = 3;
            this.btnSearchOrders.Text = "Search";
            this.btnSearchOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchOrders.UseVisualStyleBackColor = false;
            this.btnSearchOrders.Click += new System.EventHandler(this.btnSearchOrders_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Image = global::Warehouse_Management_System.Properties.Resources.icons8_delete_24;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1143, 105);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(117, 42);
            this.btnDeleteOrder.TabIndex = 33;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOrder.Image = global::Warehouse_Management_System.Properties.Resources.icons8_add_24;
            this.btnInsertOrder.Location = new System.Drawing.Point(391, 385);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(148, 122);
            this.btnInsertOrder.TabIndex = 26;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertOrder.UseVisualStyleBackColor = false;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // ProdSearchBox
            // 
            this.ProdSearchBox.Location = new System.Drawing.Point(12, 112);
            this.ProdSearchBox.Multiline = true;
            this.ProdSearchBox.Name = "ProdSearchBox";
            this.ProdSearchBox.Size = new System.Drawing.Size(270, 38);
            this.ProdSearchBox.TabIndex = 47;
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProd.Image = global::Warehouse_Management_System.Properties.Resources.icons8_search_26;
            this.btnSearchProd.Location = new System.Drawing.Point(298, 112);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(132, 38);
            this.btnSearchProd.TabIndex = 48;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchProd.UseVisualStyleBackColor = false;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-19, -19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            this.OrdersDataGrid.AllowUserToResizeColumns = false;
            this.OrdersDataGrid.AllowUserToResizeRows = false;
            this.OrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.Location = new System.Drawing.Point(715, 149);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.ReadOnly = true;
            this.OrdersDataGrid.RowHeadersWidth = 51;
            this.OrdersDataGrid.RowTemplate.Height = 24;
            this.OrdersDataGrid.Size = new System.Drawing.Size(823, 304);
            this.OrdersDataGrid.TabIndex = 52;
            // 
            // RefreshStocks
            // 
            this.RefreshStocks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshStocks.Image = global::Warehouse_Management_System.Properties.Resources.icons8_refresh_24;
            this.RefreshStocks.Location = new System.Drawing.Point(452, 112);
            this.RefreshStocks.Name = "RefreshStocks";
            this.RefreshStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RefreshStocks.Size = new System.Drawing.Size(132, 38);
            this.RefreshStocks.TabIndex = 50;
            this.RefreshStocks.Text = "Refresh";
            this.RefreshStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshStocks.UseVisualStyleBackColor = false;
            this.RefreshStocks.Click += new System.EventHandler(this.RefreshStocks_Click);
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(1007, 52);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(225, 41);
            this.Order.TabIndex = 54;
            this.Order.Text = "Orders";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Stocks
            // 
            this.Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocks.Location = new System.Drawing.Point(236, 52);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(225, 41);
            this.Stocks.TabIndex = 55;
            this.Stocks.Text = "Stocks";
            this.Stocks.UseVisualStyleBackColor = true;
            this.Stocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // QuantityInventoryNumericUpDown1
            // 
            this.QuantityInventoryNumericUpDown1.AutoSize = true;
            this.QuantityInventoryNumericUpDown1.Location = new System.Drawing.Point(152, 456);
            this.QuantityInventoryNumericUpDown1.Name = "QuantityInventoryNumericUpDown1";
            this.QuantityInventoryNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.QuantityInventoryNumericUpDown1.TabIndex = 65;
            // 
            // InventoryCategoryComboBox
            // 
            this.InventoryCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InventoryCategoryComboBox.Enabled = false;
            this.InventoryCategoryComboBox.FormattingEnabled = true;
            this.InventoryCategoryComboBox.Items.AddRange(new object[] {
            "Phone",
            "Laptop and Computers",
            "Phone Accesssories",
            "Computer Accessories",
            "Home Entertainment",
            ""});
            this.InventoryCategoryComboBox.Location = new System.Drawing.Point(153, 582);
            this.InventoryCategoryComboBox.Name = "InventoryCategoryComboBox";
            this.InventoryCategoryComboBox.Size = new System.Drawing.Size(242, 24);
            this.InventoryCategoryComboBox.TabIndex = 64;
            // 
            // DescTxtBox
            // 
            this.DescTxtBox.Location = new System.Drawing.Point(152, 540);
            this.DescTxtBox.Name = "DescTxtBox";
            this.DescTxtBox.ReadOnly = true;
            this.DescTxtBox.Size = new System.Drawing.Size(214, 22);
            this.DescTxtBox.TabIndex = 63;
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(152, 498);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.ReadOnly = true;
            this.PriceTxtBox.Size = new System.Drawing.Size(120, 22);
            this.PriceTxtBox.TabIndex = 62;
            // 
            // IProductName
            // 
            this.IProductName.Location = new System.Drawing.Point(153, 418);
            this.IProductName.Name = "IProductName";
            this.IProductName.ReadOnly = true;
            this.IProductName.Size = new System.Drawing.Size(151, 22);
            this.IProductName.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Product Name:";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.Location = new System.Drawing.Point(847, 485);
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            this.TotalQuantity.Size = new System.Drawing.Size(100, 22);
            this.TotalQuantity.TabIndex = 66;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(847, 540);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(169, 22);
            this.TotalPrice.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Total Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(732, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Total Price:";
            // 
            // RefreshOrders
            // 
            this.RefreshOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshOrders.Image = global::Warehouse_Management_System.Properties.Resources.icons8_refresh_24;
            this.RefreshOrders.Location = new System.Drawing.Point(1266, 107);
            this.RefreshOrders.Name = "RefreshOrders";
            this.RefreshOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RefreshOrders.Size = new System.Drawing.Size(132, 38);
            this.RefreshOrders.TabIndex = 70;
            this.RefreshOrders.Text = "Refresh";
            this.RefreshOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshOrders.UseVisualStyleBackColor = false;
            this.RefreshOrders.Click += new System.EventHandler(this.RefreshOrders_Click_1);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.warehouse1;
            this.ClientSize = new System.Drawing.Size(1550, 644);
            this.Controls.Add(this.RefreshOrders);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalQuantity);
            this.Controls.Add(this.QuantityInventoryNumericUpDown1);
            this.Controls.Add(this.InventoryCategoryComboBox);
            this.Controls.Add(this.DescTxtBox);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.IProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Stocks);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.btnSearchOrders);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.RefreshStocks);
            this.Controls.Add(this.OrderSearchBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.ProdSearchBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomerNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDataGrid);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInventoryNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderSearchBox;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProdSearchBox;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.Button RefreshStocks;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Stocks;
        private System.Windows.Forms.NumericUpDown QuantityInventoryNumericUpDown1;
        private System.Windows.Forms.ComboBox InventoryCategoryComboBox;
        private System.Windows.Forms.TextBox DescTxtBox;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox IProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalQuantity;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RefreshOrders;
    }
}