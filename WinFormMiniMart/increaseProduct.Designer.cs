namespace WinFormMiniMart
{
    partial class increaseProduct
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
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            cmbCategoryID = new ComboBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            numUD_UnitPrice = new NumericUpDown();
            cmbDiscontinued = new ComboBox();
            numUD_UnitsInStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 192);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 13;
            label4.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 110);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 14;
            label3.Text = "ชื่อสินค้า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 192);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 16;
            label6.Text = "สถานะจำหน่าย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 192);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "จำนวน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 24);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 18;
            label2.Text = "ประเภทสินค้า";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 19;
            label1.Text = "รหัสสินค้า";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(395, 283);
            button2.Name = "button2";
            button2.Size = new Size(178, 61);
            button2.TabIndex = 11;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(595, 283);
            button1.Name = "button1";
            button1.Size = new Size(178, 61);
            button1.TabIndex = 12;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(235, 54);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(184, 45);
            cmbCategoryID.TabIndex = 10;
            cmbCategoryID.SelectedIndexChanged += cmbCategoryID_SelectedIndexChanged;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(28, 133);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(745, 43);
            txtProductName.TabIndex = 8;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(28, 56);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(171, 43);
            txtProductID.TabIndex = 9;
            // 
            // numUD_UnitPrice
            // 
            numUD_UnitPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitPrice.Location = new Point(28, 215);
            numUD_UnitPrice.Name = "numUD_UnitPrice";
            numUD_UnitPrice.Size = new Size(249, 43);
            numUD_UnitPrice.TabIndex = 20;
            // 
            // cmbDiscontinued
            // 
            cmbDiscontinued.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiscontinued.FormattingEnabled = true;
            cmbDiscontinued.Items.AddRange(new object[] { "พร้อมจำหน่าย", "เลิกจำหน่าย" });
            cmbDiscontinued.Location = new Point(570, 215);
            cmbDiscontinued.Name = "cmbDiscontinued";
            cmbDiscontinued.Size = new Size(203, 45);
            cmbDiscontinued.TabIndex = 10;
            // 
            // numUD_UnitsInStock
            // 
            numUD_UnitsInStock.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitsInStock.Location = new Point(302, 215);
            numUD_UnitsInStock.Name = "numUD_UnitsInStock";
            numUD_UnitsInStock.Size = new Size(250, 43);
            numUD_UnitsInStock.TabIndex = 20;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 357);
            Controls.Add(numUD_UnitsInStock);
            Controls.Add(numUD_UnitPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbDiscontinued);
            Controls.Add(cmbCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Name = "Form4";
            Text = "เพิ่ม/แก้ไขสินค้า";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox cmbCategoryID;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private NumericUpDown numUD_UnitPrice;
        private ComboBox cmbDiscontinued;
        private NumericUpDown numUD_UnitsInStock;
    }
}