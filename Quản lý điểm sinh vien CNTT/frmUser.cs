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

        private void frmUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cc.loaddatagridview2("select * from tblKET_QUA where MaSV = '" + username + "'");
            cc.loadcombobox(cbbMonHoc, "select * from tblMON", 0);

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cc.loaddatagridview2("select * from tblKET_QUA where MaSV = '" + username + "' and MaMon = '"+cbbMonHoc.Text+"'");
        }
    }
}
