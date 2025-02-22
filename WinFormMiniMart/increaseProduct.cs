﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniMart
{
    public partial class increaseProduct : Form
    {
        public increaseProduct()
        {
            InitializeComponent();
        }

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public bool Discontinued { get; set; }
        public string status { get; set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();

            // กำหนดขอบเขตของ NumericUpDown
            numUD_UnitPrice.Minimum = 0;
            numUD_UnitPrice.Maximum = 1000000;
            numUD_UnitPrice.Value = 210;

            numUD_UnitsInStock.Minimum = 0;
            numUD_UnitsInStock.Maximum = 10000;
            numUD_UnitsInStock.Value = 100;

            // ดึงข้อมูลจากตาราง Categories
            LoadCategories();

            // Initializing form fields based on data passed
            txtProductID.Text = ProductID;
            txtProductName.Text = ProductName;
            numUD_UnitPrice.Value = UnitPrice;
            numUD_UnitsInStock.Value = UnitsInStock;
            cmbCategoryID.SelectedValue = CategoryID;  // Assuming CategoryID is set with a list of categories
            cmbDiscontinued.SelectedIndex = Discontinued ? 1 : 0;

            this.Text += "(" + status + ")";
            txtProductName.Focus();
        }

        private void LoadCategories()
        {
            // ดึงข้อมูลจากตาราง Categories
            string sql = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ตั้งค่า DataSource ให้กับ ComboBox
            cmbCategoryID.DataSource = dt;
            cmbCategoryID.DisplayMember = "CategoryName";  // แสดงชื่อหมวดหมู่ใน ComboBox
            cmbCategoryID.ValueMember = "CategoryID";  // เก็บค่า CategoryID ที่เลือกไว้
            cmbCategoryID.SelectedIndex = -1;  // ตั้งค่าเริ่มต้นให้ ComboBox ไม่มีการเลือกใดๆ
        }

        private void UpdateProduct()
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง");
                return;
            }

            // ปรับ SQL ให้สามารถอัปเดต ProductID ได้
            string sql = "Update Products set ProductName = @ProductName, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, CategoryID = @CategoryID, Discontinued = @Discontinued where ProductID = @ProductID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());  // ใช้ ProductID เป็น VARCHAR โดยตรง
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);  // Assumes CategoryID is selected from ComboBox
            cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);  // 0 = "พร้อมจำหน่าย", 1 = "เลิกจำหน่าย"
            cmd.ExecuteNonQuery();
            this.Close();
        }

       
        
            private void InsertProduct()
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง");
                    return;
                }

                // ตรวจสอบว่ามี ProductID อยู่แล้วหรือไม่
                string checkSql = "SELECT COUNT(*) FROM Products WHERE ProductID = @ProductID";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("รหัสสินค้านี้มีอยู่แล้วในระบบ กรุณาใช้รหัสสินค้าใหม่!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ถ้าไม่มี ProductID ซ้ำ ให้ทำการ Insert
                string sql = "INSERT INTO Products (ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, Discontinued) " +
                             "VALUES (@ProductID, @ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
                cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
                cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
                cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);

                cmd.ExecuteNonQuery();
                MessageBox.Show("เพิ่มสินค้าเรียบร้อยแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        private void button2_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                InsertProduct();
            }
            else if (status == "update")
            {
                UpdateProduct();
            }
        }

        private void cmbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
