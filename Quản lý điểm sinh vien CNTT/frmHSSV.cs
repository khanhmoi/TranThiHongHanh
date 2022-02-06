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
    public partial class frmHSSV : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmHSSV()
        {
            InitializeComponent();
        }

        private void frmHSSV_Load(object sender, EventArgs e)
        {
            dgrHSSV.DataSource = cc.loaddatagridview2("select * from tblTT_CA_NHAN_SINH_VIEN");
            cc.loadcombobox(cbbMaSV, "select * from tblSINH_VIEN",0);

        }

        private void dgrHSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSV.Text = dgrHSSV.CurrentRow.Cells[0].Value.ToString();
            tbHoTenSV.Text = dgrHSSV.CurrentRow.Cells[1].Value.ToString();
            tbNamSinhSV.Text = dgrHSSV.CurrentRow.Cells[2].Value.ToString();
            tbQueQuanSV.Text = dgrHSSV.CurrentRow.Cells[3].Value.ToString();
            tbGioiTinhSV.Text = dgrHSSV.CurrentRow.Cells[4].Value.ToString();
            tbSDTSV.Text = dgrHSSV.CurrentRow.Cells[5].Value.ToString();
            tbCMTND.Text = dgrHSSV.CurrentRow.Cells[6].Value.ToString();
            tbTP.Text = dgrHSSV.CurrentRow.Cells[7].Value.ToString();
            tbQH.Text = dgrHSSV.CurrentRow.Cells[8].Value.ToString();
            tbPX.Text = dgrHSSV.CurrentRow.Cells[9].Value.ToString();
            tbTX.Text = dgrHSSV.CurrentRow.Cells[10].Value.ToString();
            tbDT.Text = dgrHSSV.CurrentRow.Cells[11].Value.ToString();
            tbTG.Text = dgrHSSV.CurrentRow.Cells[12].Value.ToString();
            tbQT.Text = dgrHSSV.CurrentRow.Cells[13].Value.ToString();
            tbEmailSV.Text = dgrHSSV.CurrentRow.Cells[14].Value.ToString();
            tbNoiTru.Text = dgrHSSV.CurrentRow.Cells[15].Value.ToString();
            tbNgoaiTru.Text = dgrHSSV.CurrentRow.Cells[16].Value.ToString();
            tbHoTenBo.Text = dgrHSSV.CurrentRow.Cells[17].Value.ToString();
            tbNgaySinhBo.Text = dgrHSSV.CurrentRow.Cells[18].Value.ToString();
            tbSDTBo.Text = dgrHSSV.CurrentRow.Cells[19].Value.ToString();
            tbQueBo.Text = dgrHSSV.CurrentRow.Cells[20].Value.ToString();
            tbNgheBo.Text = dgrHSSV.CurrentRow.Cells[21].Value.ToString();
            tbHoTenMe.Text = dgrHSSV.CurrentRow.Cells[22].Value.ToString();
            tbNgaySinhMe.Text = dgrHSSV.CurrentRow.Cells[23].Value.ToString();
            tbSDTMe.Text = dgrHSSV.CurrentRow.Cells[24].Value.ToString();
            tbQueMe.Text = dgrHSSV.CurrentRow.Cells[25].Value.ToString();
            tbNgheMe.Text = dgrHSSV.CurrentRow.Cells[26].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tblTT_CA_NHAN_SINH_VIEN set MaSv=N'" + cbbMaSV.Text + "',HoTen=N'" + tbHoTenSV.Text + "',NamSinh=N'" + tbNamSinhSV.Text + "',NoiSinh=N'" + tbQueQuanSV.Text + "',GioiTinh=N'" + tbGioiTinhSV.Text + "',SDT=N'" + tbSDTSV.Text + "',CMTND=N'" + tbCMTND.Text + "',TP=N'" + tbTP.Text + "',QH=N'" + tbQH.Text + "',PX=N'" + tbPX.Text + "',TX=N'" + tbTX.Text + "',DanToc=N'" + tbDT.Text + "',TonGiao=N'" + tbTG.Text + "',QuocTich=N'" + tbQT.Text + "',Email=N'" + tbEmailSV.Text + "',DiaChiNoiTru=N'" + tbNoiTru.Text + "',DiaChiNgoaiTru=N'" + tbNgoaiTru.Text + "',HoTenBo=N'" + tbHoTenBo.Text + "',NgaySinhBo=N'" + tbNgaySinhBo.Text + "',SDTBo=N'" + tbSDTBo.Text + "',QueBo=N'" + tbQueBo.Text + "',NgheBo=N'" + tbNgheBo.Text + "',HoTenMe=N'" + tbHoTenMe.Text + "',NgaySinhMe=N'" + tbNgaySinhMe.Text + "',SDTMe=N'" + tbSDTMe.Text + "',QueMe=N'" + tbQueMe.Text + "',NgheMe=N'" + tbNgheMe.Text + "' where MaSv=N'" + cbbMaSV.Text + "'";
                cc.thucthiketnoi(update);
                dgrHSSV.DataSource = cc.loaddatagridview2("select * from tblTT_CA_NHAN_SINH_VIEN");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng" + e);
            }
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cc.loadtextboxchiso(tbHoTenSV, "select * from tblSINH_VIEN where MaSv = '" + cbbMaSV.Text + "'", 1);
            cc.loadtextboxchiso(tbNamSinhSV, "select * from tblSINH_VIEN where MaSv = '" + cbbMaSV.Text + "'", 2);
            cc.loadtextboxchiso(tbGioiTinhSV, "select * from tblSINH_VIEN where MaSv = '" + cbbMaSV.Text + "'", 3);
            cc.loadtextboxchiso(tbQueQuanSV, "select * from tblSINH_VIEN where MaSv = '" + cbbMaSV.Text + "'", 4);
        }
    }
}
