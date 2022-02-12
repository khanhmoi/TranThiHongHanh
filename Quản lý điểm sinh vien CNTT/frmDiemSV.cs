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
    public partial class frmDiemSV : Form
    {
        private string text1;
        private string text2;
        private CommonConnect cc = new CommonConnect();

        public frmDiemSV(string text1, string text2)
        {
            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
        }

        public frmDiemSV()
        {
            
        }

        private void frmDiemSV_Load(object sender, EventArgs e)
        {
            cc.loaddatagridview(dataGridView1, "select * from tblKET_QUA where MaSv = '" + text1 + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dataGridView1);
        }
    }
}
