using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    public partial class frmTimKiem : Form
    {
        CommonConnect conn = new CommonConnect();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        int i = 0;

        private void radioButtonMaSV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButtonHvT_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButtonMaLop_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if ((textBoxTimKiem.Text == "") || (textBoxTimKiem.Text == "Nhập vào từ khóa tìm kiếm"))
        //        {
        //            MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        }
        //        else
        //        {
        //            if (i == 1)
        //            {
        //                conn.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where MaNV=N'" + textBoxTimKiem.Text + "'");
        //            }
        //            if (i == 2)
        //            {
        //                conn.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where HoTen=N'" + textBoxTimKiem.Text + "'");
        //            }
        //            if (i == 3)
        //            {
        //                conn.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where CMTND=N'" + textBoxTimKiem.Text + "'");
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Tìm kiếm sai");
        //    }

        //}

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            radioButtonMaSV.Checked = true;
            conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq");
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if ((textBoxTimKiem.Text == "") || (textBoxTimKiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq");
                }
                else
                {

                    if (i == 1)
                    {
                        conn.loadtextbox(textBoxTimKiem, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaSV like N'" + textBoxTimKiem.Text + "%'", 2);
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaSV like N'" + textBoxTimKiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        conn.loadtextbox(textBoxTimKiem, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaSV like N'" + textBoxTimKiem.Text + "%'", 3);
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where HoTen like N'" + textBoxTimKiem.Text + "%'");
                    }
                    if (i == 3)
                    {
                        conn.loadtextbox(textBoxTimKiem, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaSV like N'" + textBoxTimKiem.Text + "%'", 8);
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaLop like N'" + textBoxTimKiem.Text + "%'");
                    }
                }
            }
            catch
            {
                //MessageBox.Show("tìm kiếm sai");
            }
        }

        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập vào từ khóa tìm kiếm")
            {
                textBoxTimKiem.Text = "";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxTimKiem.Text == "") || (textBoxTimKiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MASV=N'" + textBoxTimKiem.Text + "'");
                    }
                    if (i == 2)
                    {
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where HoTen=N'" + textBoxTimKiem.Text + "'");
                    }
                    if (i == 3)
                    {
                        conn.loaddatagridview(dataGridView1, "select kq.MaSV, kq.HoTen, kq.MaLop, kq.MaMon, kq.DiemTB, kq.DiemTongKet, kq.HanhKiem, kq.HocKi, kq.GhiChu from tblKET_QUA kq where MaLop=N'" + textBoxTimKiem.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
