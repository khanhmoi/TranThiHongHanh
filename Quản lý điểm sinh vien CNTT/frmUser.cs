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
    public partial class frmUser : Form
    {
        private CommonConnect cc = new CommonConnect();
        string username;
        string password;
        public frmUser(string user, string pass)
        {
            InitializeComponent();
            this.username = user;
            this.password = pass;
        }

        public frmUser()
        {
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = cc.loaddatagridview2("select * from tblKET_QUA where MaSV = '" + username + "'");
            //cc.loadcombobox(cbbMonHoc, "select * from tblMON", 0);
            tbMaSV.Text = username;
            cc.loadtextboxchiso(tbHoTenSV, "select * from tblSINH_VIEN where MaSv = '" + username + "'",1);
            cc.loadtextboxchiso(tbNamSinhSV, "select * from tblSINH_VIEN where MaSv = '" + username + "'", 2);
            cc.loadtextboxchiso(tbQueQuanSV, "select * from tblSINH_VIEN where MaSv = '" + username + "'", 4);
            cc.loadtextboxchiso(tbGioiTinhSV, "select * from tblSINH_VIEN where MaSv = '" + username + "'", 3);
            cc.loadtextboxchiso(tbSDTSV, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 5);
            cc.loadtextboxchiso(tbCMTND, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 6);
            cc.loadtextboxchiso(tbTP, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 7);
            cc.loadtextboxchiso(tbQH, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 8);
            cc.loadtextboxchiso(tbPX, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 9);
            cc.loadtextboxchiso(tbTX, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 10);
            cc.loadtextboxchiso(tbDT, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 11);
            cc.loadtextboxchiso(tbTG, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 12);
            cc.loadtextboxchiso(tbQT, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 13);
            cc.loadtextboxchiso(tbEmailSV, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 14);
            cc.loadtextboxchiso(tbNoiTru, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 15);
            cc.loadtextboxchiso(tbNgoaiTru, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 16);
            cc.loadtextboxchiso(tbHoTenBo, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 17);
            cc.loadtextboxchiso(tbNgaySinhBo, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 18);
            cc.loadtextboxchiso(tbSDTBo, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 19);
            cc.loadtextboxchiso(tbQueBo, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 20);
            cc.loadtextboxchiso(tbNgheBo, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 21);
            cc.loadtextboxchiso(tbHoTenMe, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 22);
            cc.loadtextboxchiso(tbNgaySinhMe, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 23);
            cc.loadtextboxchiso(tbSDTMe, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 24);
            cc.loadtextboxchiso(tbQueMe, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 25);
            cc.loadtextboxchiso(tbNgheMe, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'", 26);
            cc.loaddatagridview(dataGridViewTTSV, "select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'");




        }

        //private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = cc.loaddatagridview2("select * from tblKET_QUA where MaSV = '" + username + "' and MaMon = '"+cbbMonHoc.Text+"'");
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tblTT_CA_NHAN_SINH_VIEN set MaSv=N'" + tbMaSV.Text + "',HoTen=N'" + tbHoTenSV.Text + "',NamSinh=N'" + tbNamSinhSV.Text + "',NoiSinh=N'" + tbQueQuanSV.Text + "',GioiTinh=N'" + tbGioiTinhSV.Text + "',SDT=N'" + tbSDTSV.Text + "',CMTND=N'" + tbCMTND.Text + "',TP=N'" + tbTP.Text + "',QH=N'" + tbQH.Text + "',PX=N'" + tbPX.Text + "',TX=N'" + tbTX.Text + "',DanToc=N'" + tbDT.Text + "',TonGiao=N'" + tbTG.Text + "',QuocTich=N'" + tbQT.Text + "',Email=N'" + tbEmailSV.Text + "',DiaChiNoiTru=N'" + tbNoiTru.Text + "',DiaChiNgoaiTru=N'" + tbNgoaiTru.Text + "',HoTenBo=N'" + tbHoTenBo.Text + "',NgaySinhBo=N'" + tbNgaySinhBo.Text + "',SDTBo=N'" + tbSDTBo.Text + "',QueBo=N'" + tbQueBo.Text + "',NgheBo=N'" + tbNgheBo.Text + "',HoTenMe=N'" + tbHoTenMe.Text + "',NgaySinhMe=N'" + tbNgaySinhMe.Text + "',SDTMe=N'" + tbSDTMe.Text + "',QueMe=N'" + tbQueMe.Text + "',NgheMe=N'" + tbNgheMe.Text + "' where MaSv=N'" + tbMaSV.Text + "'";
                cc.thucthiketnoi(update);
                dataGridViewTTSV.DataSource = cc.loaddatagridview2("select * from tblTT_CA_NHAN_SINH_VIEN where MaSv = '" + username + "'");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng"+e);
            }
        }

        private void SVupdatePw_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau updatePw = new frmDoiMatKhau();

            updatePw.ShowDialog();
        }
    }
}
