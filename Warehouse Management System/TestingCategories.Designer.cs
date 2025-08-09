namespace Warehouse_Management_System
{
    partial class TestingCategories
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
            this.testingCategorycomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // testingCategorycomboBox1
            // 
            this.testingCategorycomboBox1.FormattingEnabled = true;
            this.testingCategorycomboBox1.Location = new System.Drawing.Point(185, 109);
            this.testingCategorycomboBox1.Name = "testingCategorycomboBox1";
            this.testingCategorycomboBox1.Size = new System.Drawing.Size(121, 24);
            this.testingCategorycomboBox1.TabIndex = 0;
            // 
            // TestingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testingCategorycomboBox1);
            this.Name = "TestingCategories";
            this.Text = "TestingCategories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox testingCategorycomboBox1;
    }
}