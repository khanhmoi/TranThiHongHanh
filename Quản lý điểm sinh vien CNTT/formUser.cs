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
    public partial class formUser : Form
    {
        string text1;
        string text2;

        public formUser(string text1, string text2)
        {
            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
        }

        public formUser()
        {          
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser(lblMaSV.Text, lblMaSV.Text);
            user.ShowDialog();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            lblMaSV.Text = text1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btl2_Click(object sender, EventArgs e)
        {
            
            frmUser frmUser = new frmUser(lblMaSV.Text, lblMaSV.Text);
            frmUser.TopLevel = false;
            frmUser.AutoScroll = true;
            this.pnUser.Controls.Add(frmUser);
            frmUser.Show();
        }

        private void btl4_Click(object sender, EventArgs e)
        {
            frmBHYT frmBHYT = new frmBHYT(lblMaSV.Text, lblMaSV.Text);
            frmBHYT.TopLevel = false;
            frmBHYT.AutoScroll = true;
            this.pnUser.Controls.Add(frmBHYT);
            frmBHYT.Show();
        }

        private void btl3_Click(object sender, EventArgs e)
        {
            frmDiemSV frmDiemSV = new frmDiemSV(lblMaSV.Text, lblMaSV.Text);
            frmDiemSV.TopLevel = false;
            frmDiemSV.AutoScroll = true;
            this.pnUser.Controls.Add(frmDiemSV);
            frmDiemSV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.TopLevel = false;
            frmDoiMatKhau.AutoScroll = true;
            this.pnUser.Controls.Add(frmDoiMatKhau);
            frmDoiMatKhau.Show();
        }

        private void pnUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
