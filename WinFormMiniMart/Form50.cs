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
    public partial class Form50 : Form
    {
        public Form50()
        {
            InitializeComponent();
        }
        public int employeeID { get; set; }
        public string empName { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }
        public object EmployeeID { get; internal set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
     

        private void Form50_Load(object sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employeeID = 0;
            empName = string.Empty;
            Position = string.Empty;
            UserName = string.Empty;
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string sql = "select EmployeeID, EmpName = Title + FirstName + ' ' + LastName, Position, UserName from Employees where UserName = @username and Password = @password";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                employeeID = Convert.ToInt32(ds.Tables[0].Rows[0]["EmployeeID"]);
                empName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                Position = ds.Tables[0].Rows[0]["Position"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                MessageBox.Show("ยินดีต้อนรับคุณ" + empName, "Welcome");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "Error");
                employeeID = 0;
                empName = string.Empty;
                Position = string.Empty;
                UserName = string.Empty;
            }
            this.Close();
        }

    }

}
