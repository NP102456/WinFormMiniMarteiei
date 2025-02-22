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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //menuStrip4.Visible = true;
            //menuStrip3.Visible = false;
            //menuStrip1.Visible = false;
            ShowHideMenu(true, false, false);
        }
        void ShowHideMenu(Boolean start, Boolean mgeMenu, Boolean saleMenu)
        {
            menuStrip4.Visible = start;
            menuStrip3.Visible = mgeMenu;
            menuStrip1.Visible = saleMenu;
        }
        private void จดการToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void พนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void สนคToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void คำนวนสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPos frm = new frmPos();
            //frm.MdiParent = this;
            frm.Show();
        }



        private void จดการขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.Show();
        }

        private void เขาสระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
            if (f.employeeID == 0)
            {
                return;
            }

            this.Text = "ชื่อผู้ใช้ :" + f.empName + "ตำแหน่ง :" + f.Position;
            if (f.Position == "Sale Manager")
            {
                ShowHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                ShowHideMenu(false, false, true);
            }
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ออกจากระบบToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           frmCategories frmCategories = new frmCategories();
            frmCategories.ShowDialog();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideMenu(true, false, false);
        }

        private void จดการขอมลสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            frm.Show();
        }

        private void ออกจากระบบToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบMini Mart";
        }
    }
}
