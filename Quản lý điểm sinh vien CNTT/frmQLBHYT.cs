using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    public partial class frmQLBHYT : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmQLBHYT()
        {
            InitializeComponent();
        }

        private void frmQLBHYT_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cc.loaddatagridview2("select * from tblBAO_HIEM");
            cc.loadcombobox(cbbMaSV, "select * from tblSINH_VIEN", 0);
            conn = cc.Connected();
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cc.loadtextboxchiso(textBox4, "select * from tblSINH_VIEN where MaSv = '" + cbbMaSV.Text + "'",1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string insert = "Insert Into tblBAO_HIEM(MBH,MaSv,NgayCap,NgayHetHan,GhiChu)" +
                "Values('" + txtMBH.Text + "','" + cbbMaSV.Text + "','" + txtNgayCap.Text + "','" +
                txtNgayHetHan.Text + "','" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");
                dataGridView1.DataSource = cc.loaddatagridview2("select * from tblBAO_HIEM");

                // Trả tài nguyên


                cmd.Dispose();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Lỗi !"+ex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "Update tblBAO_HIEM Set MBH='"+txtMBH.Text+"',NgayCap='"+txtNgayCap.Text+"',NgayHetHan='"+txtNgayHetHan.Text+"',GhiChu='"+txtGhiChu.Text+"' where MaSv='"+cbbMaSV.Text+"'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo!");
                dataGridView1.DataSource = cc.loaddatagridview2("select * from tblBAO_HIEM");

                // Trả tài nguyên


                cmd.Dispose();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Lỗi !" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMBH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbbMaSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNgayCap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNgayHetHan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                string delete = "delete from tblBAO_HIEM where MaSV='" + cbbMaSV.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                dataGridView1.DataSource = cc.loaddatagridview2("select * from tblBAO_HIEM");
            }
        }
    }
}
