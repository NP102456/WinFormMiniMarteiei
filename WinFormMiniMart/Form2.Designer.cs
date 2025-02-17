namespace WinFormMiniMart
{
    partial class Form2
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtEmployeeID = new TextBox();
            cmbTitle = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(43, 64);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(171, 43);
            txtEmployeeID.TabIndex = 0;
            // 
            // cmbTitle
            // 
            cmbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "นาย", "นาง", "นางสาว" });
            cmbTitle.Location = new Point(43, 142);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(171, 45);
            cmbTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(241, 142);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 43);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(513, 142);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 43);
            txtLastName.TabIndex = 0;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(43, 223);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(448, 43);
            txtPosition.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(43, 306);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(353, 43);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox5_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(410, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(353, 43);
            txtPassword.TabIndex = 0;
            txtPassword.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(610, 373);
            button1.Name = "button1";
            button1.Size = new Size(178, 61);
            button1.TabIndex = 2;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(410, 373);
            button2.Name = "button2";
            button2.Size = new Size(178, 61);
            button2.TabIndex = 2;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "คำนำหน้า";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 119);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 3;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 119);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "สกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 200);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "ตำแหน่ง";
            label5.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 283);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 3;
            label6.Text = "ชื่อผู้ใช้";
            label6.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 283);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 3;
            label7.Text = "รหัสผ่าน";
            label7.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPosition);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeID);
            Name = "Form2";
            Text = "เพิ่ม/แก้ไขพนักงาน";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtEmployeeID;
        private ComboBox cmbTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPosition;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}