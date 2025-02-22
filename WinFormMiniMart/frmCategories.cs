using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace WinFormMiniMart
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
            this.Load += FrmCategories_Load;
            dgvCategories.CellMouseUp += DgvCategories_CellMouseUp;
        }

        private void DgvCategories_CellMouseUp(object? sender, DataGridViewCellMouseEventArgs e)
        {
             dgvCategories.CurrentRow.Cells["CategoryID"].Value.ToString();
            dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
            dgvCategories.CurrentRow.Cells["Description"].Value.ToString();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void FrmCategories_Load(object? sender, EventArgs e)
        {
            conn = connDB.ConnectMinimart();
            showdata();
            
        }

        private void showdata()
        {
            string sql = "Select * from Categories";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvCategories.DataSource = dataSet.Tables[0];
        }

       

        private void btninsert_Click(object sender, EventArgs e)
        {
            frm_main addCategoryForm = new frm_main();
            addCategoryForm.status = "insert"; // กำหนดให้เป็นโหมดเพิ่ม
            addCategoryForm.ShowDialog(); // เปิดฟอร์มใหม่แบบ Modal
            showdata(); // โหลดข้อมูลใหม่หลังจากปิดฟอร์ม

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบข้อมูลนี้?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            foreach (DataGridViewRow row in dgvCategories.SelectedRows)
            {
                string categoryID = row.Cells["CategoryID"].Value.ToString();
                string sql = "DELETE FROM Categories WHERE CategoryID = @categoryID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata(); // โหลดข้อมูลใหม่
        }






        private void dgvCategories_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_main f = new frm_main();
            f.status = "update";
            var dgv = dgvCategories.CurrentRow.Cells;
            f.categoryID = Convert.ToInt16(dgv["categoryID"].Value);
            f.categoryName = dgv["categoryName"].Value.ToString();
            f.description = dgv["description"].Value.ToString();
            f.ShowDialog();
            showdata();
        }

        private void frmCategories_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
