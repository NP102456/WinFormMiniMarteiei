namespace WinFormMiniMart
{
    partial class Form50
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnok = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(160, 87);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(195, 40);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 188);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(195, 35);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnok
            // 
            btnok.Location = new Point(242, 275);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 51);
            btnok.TabIndex = 2;
            btnok.Text = "ตกลง";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(365, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 51);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 87);
            label1.Name = "label1";
            label1.Size = new Size(109, 50);
            label1.TabIndex = 4;
            label1.Text = "ชื่อผู้ใช้";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 173);
            label2.Name = "label2";
            label2.Size = new Size(125, 50);
            label2.TabIndex = 5;
            label2.Text = "รหัสผ่าน";
            // 
            // Form50
            // 
            AcceptButton = btnok;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnok);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            IsMdiContainer = true;
            Name = "Form50";
            Text = "Form50";
            Load += Form50_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnok;
        private Button btnCancel;
        private Label label1;
        private Label label2;
    }
}