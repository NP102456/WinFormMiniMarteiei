namespace WinFormMiniMart
{
    partial class frmCategories
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategories = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btninsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClearForm = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(13, 268);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(776, 170);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellContentDoubleClick += dgvCategories_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสประเภทสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 22);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 69);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "รายละเอียด";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(143, 18);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(153, 27);
            txtCategoryID.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(446, 22);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(327, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(143, 66);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(342, 123);
            txtDescription.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(537, 68);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(106, 59);
            btninsert.TabIndex = 7;
            btninsert.Text = "เพิ่ม";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(537, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 59);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(667, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 59);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(667, 133);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(106, 59);
            btnClearForm.TabIndex = 10;
            btnClearForm.Text = "ล้างฟอร์ม";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(537, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 59);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnClearForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btninsert);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCategories);
            Name = "frmCategories";
            Text = "จัดการข้อมูลหมวดหมูสินค้า";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btninsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClearForm;
        private Button btnAdd;
    }
}
