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
    public partial class frmBHYT : Form
    {
        private CommonConnect cc = new CommonConnect();
        private string text1;
        private string text2;

        public frmBHYT(string text1, string text2)
        {
            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
        }

        public frmBHYT()
        {
            
        }

        private void frmBHYT_Load(object sender, EventArgs e)
        {
            cc.loaddatagridview(dataGridView1, "select * from tblBAO_HIEM where MaSv = '"+text1+"'");
        }
    }
}
