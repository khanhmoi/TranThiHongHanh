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
    public partial class rpDiemTK : Form
    {
        public rpDiemTK()
        {
            InitializeComponent();
        }

        private void rpDiemTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSDiemTK.tblKET_QUA' table. You can move, or remove it, as needed.
            this.tblKET_QUATableAdapter.Fill(this.DSDiemTK.tblKET_QUA);

            this.reportViewer1.RefreshReport();
        }
    }
}
