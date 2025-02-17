using Microsoft.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();
            showdata();
        }

        private void showdata()
        {
            string sql = "Select * from Employees";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvEmployees.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.Trim();
            string filter = string.Format(
                   "Convert(EmployeeID, 'System.String') LIKE '%{0}%' OR " +
                   "Title LIKE '%{0}%' OR " +
                   "FirstName LIKE '%{0}%' OR " +
                   "LastName LIKE '%{0}%' OR " +
                   "Position LIKE '%{0}%' OR " +
                   "UserName LIKE '%{0}%'",
                   searchText
            );

            (dgvEmployees.DataSource as DataTable).DefaultView.RowFilter = filter;


        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f = new Form2();
            f.status = "update";
            var dgv = dgvEmployees.CurrentRow.Cells;
            f.EmployeeID = Convert.ToInt16(dgv["EmployeeID"].Value);
            f.Title = dgv["Title"].Value.ToString();
            f.FirstName = dgv["FirstName"].Value.ToString();
            f.LastName = dgv["LastName"].Value.ToString();
            f.Position = dgv["Position"].Value.ToString();
            f.UserName = dgv["UserName"].Value.ToString();
            f.Password = dgv["Password"].Value.ToString();
            f.ShowDialog();
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear(); // ล้างข้อความใน TextBox
            txtSearch.Focus(); // โฟกัสกลับไปที่ TextBox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void dgvEmployees_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเลือกแถวใน DataGridView หรือยัง
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการลบ");
                return;
            }

            // แสดงข้อความยืนยันก่อนลบ
            if (MessageBox.Show("ต้องการลบข้อมูลพนักงานนี้หรือไม่?", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // ดึง EmployeeID จากแถวที่เลือกใน DataGridView
            string employeeID = dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

            // สร้างคำสั่ง SQL สำหรับการลบข้อมูล
            string sql = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            try
            {
                // ดำเนินการลบข้อมูล
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ลบข้อมูลพนักงานเรียบร้อย");
                    showdata();  // รีเฟรชข้อมูลใน DataGridView
                }
                else
                {
                    MessageBox.Show("ไม่สามารถลบข้อมูลได้");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }

        }
    }
}
