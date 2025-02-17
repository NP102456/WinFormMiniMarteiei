namespace WinFormMiniMart
{
    partial class frmPos
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtProductID = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lsvProduct = new ListView();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblNetPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(100, 45);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(125, 27);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(344, 48);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(125, 27);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(6, 56);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 2;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lsvProduct);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 342);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 33);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 15;
            label7.Text = "รวม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 33);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "จำนวน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 33);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 32);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 11;
            label3.Text = "รหัสสินค้า";
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(6, 100);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(602, 236);
            lsvProduct.TabIndex = 7;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.DoubleClick += lsvProduct_DoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(520, 56);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(88, 27);
            txtTotal.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(413, 56);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(92, 27);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(293, 56);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(114, 27);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += textBox3_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(151, 56);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(673, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 52);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(673, 245);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 50);
            btnClear.TabIndex = 5;
            btnClear.Text = "ล้าง";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(673, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 48);
            btnSave.TabIndex = 6;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(673, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 41);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "ยกเลิกรายการ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = SystemColors.AppWorkspace;
            lblNetPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(532, 27);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(256, 48);
            lblNetPrice.TabIndex = 8;
            lblNetPrice.Text = "0.00";
            lblNetPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 9;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "ชื่อ-สกุล";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNetPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtProductID;
        private GroupBox groupBox1;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private ListView lsvProduct;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNetPrice;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}