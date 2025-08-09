namespace Warehouse_Management_System
{
    partial class Categories
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
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriesSearchBox = new System.Windows.Forms.TextBox();
            this.CategoriesDatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnInsertCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 12);
            this.panel2.TabIndex = 39;
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(159, 66);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(214, 22);
            this.CategoryName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Category Name:";
            // 
            // CategoriesSearchBox
            // 
            this.CategoriesSearchBox.Location = new System.Drawing.Point(273, 10);
            this.CategoriesSearchBox.Name = "CategoriesSearchBox";
            this.CategoriesSearchBox.Size = new System.Drawing.Size(201, 22);
            this.CategoriesSearchBox.TabIndex = 1;
            // 
            // CategoriesDatagrid
            // 
            this.CategoriesDatagrid.AllowUserToAddRows = false;
            this.CategoriesDatagrid.AllowUserToDeleteRows = false;
            this.CategoriesDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CategoriesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDatagrid.Location = new System.Drawing.Point(410, 60);
            this.CategoriesDatagrid.Name = "CategoriesDatagrid";
            this.CategoriesDatagrid.ReadOnly = true;
            this.CategoriesDatagrid.RowHeadersWidth = 51;
            this.CategoriesDatagrid.RowTemplate.Height = 24;
            this.CategoriesDatagrid.Size = new System.Drawing.Size(361, 157);
            this.CategoriesDatagrid.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearchCategory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CategoriesSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 45);
            this.panel1.TabIndex = 24;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCategory.Image = global::Warehouse_Management_System.Properties.Resources.icons8_search_26;
            this.btnSearchCategory.Location = new System.Drawing.Point(512, 2);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(132, 38);
            this.btnSearchCategory.TabIndex = 3;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Warehouse_Management_System.Properties.Resources.icons8_exit_30;
            this.button1.Location = new System.Drawing.Point(779, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Image = global::Warehouse_Management_System.Properties.Resources.icons8_delete_24;
            this.btnDeleteCategory.Location = new System.Drawing.Point(254, 108);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(117, 42);
            this.btnDeleteCategory.TabIndex = 33;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Image = global::Warehouse_Management_System.Properties.Resources.icons8_update_24;
            this.btnUpdateCategory.Location = new System.Drawing.Point(136, 108);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(112, 42);
            this.btnUpdateCategory.TabIndex = 32;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsertCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCategory.Image = global::Warehouse_Management_System.Properties.Resources.icons8_add_24;
            this.btnInsertCategory.Location = new System.Drawing.Point(24, 108);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(106, 42);
            this.btnInsertCategory.TabIndex = 26;
            this.btnInsertCategory.Text = "Insert";
            this.btnInsertCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertCategory.UseVisualStyleBackColor = false;
            this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.warehouse1;
            this.ClientSize = new System.Drawing.Size(835, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnInsertCategory);
            this.Controls.Add(this.CategoriesDatagrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoriesSearchBox;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnInsertCategory;
        private System.Windows.Forms.DataGridView CategoriesDatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}