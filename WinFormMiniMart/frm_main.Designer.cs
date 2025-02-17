namespace WinFormMiniMart
{
    partial class frm_main
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
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(137, 70);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(342, 123);
            txtDescription.TabIndex = 12;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(440, 23);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(327, 27);
            txtCategoryName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Enabled = false;
            txtCategoryID.Location = new Point(137, 19);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(153, 27);
            txtCategoryID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "รายละเอียด";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 23);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 26);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 7;
            label1.Text = "รหัสประเภทสินค้า";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(528, 70);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 58);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(528, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 58);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frm_main
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 215);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_main";
            Text = "เพิ่ม / ปรับปรุง ข้อมูลหมวดหมู่สินค้า";
            Load += frm_main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}