
namespace Quản_lý_điểm_sinh_vien_CNTT
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.radioButtonMaLop = new System.Windows.Forms.RadioButton();
            this.radioButtonHvT = new System.Windows.Forms.RadioButton();
            this.radioButtonMaSV = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(34, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(706, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.radioButtonMaLop);
            this.groupBox1.Controls.Add(this.radioButtonHvT);
            this.groupBox1.Controls.Add(this.radioButtonMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_lý_điểm_sinh_vien_CNTT.Properties.Resources.timkiem;
            this.pictureBox1.Location = new System.Drawing.Point(35, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(386, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát    ";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(292, 32);
            this.textBoxTimKiem.MaximumSize = new System.Drawing.Size(277, 20);
            this.textBoxTimKiem.MinimumSize = new System.Drawing.Size(277, 20);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(277, 20);
            this.textBoxTimKiem.TabIndex = 1;
            this.textBoxTimKiem.Text = "Nhập vào từ khóa tìm kiếm";
            this.textBoxTimKiem.Click += new System.EventHandler(this.textBoxTimKiem_Click);
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // radioButtonMaLop
            // 
            this.radioButtonMaLop.AutoSize = true;
            this.radioButtonMaLop.Location = new System.Drawing.Point(513, 67);
            this.radioButtonMaLop.Name = "radioButtonMaLop";
            this.radioButtonMaLop.Size = new System.Drawing.Size(71, 19);
            this.radioButtonMaLop.TabIndex = 0;
            this.radioButtonMaLop.TabStop = true;
            this.radioButtonMaLop.Text = "CMTND";
            this.radioButtonMaLop.UseVisualStyleBackColor = true;
            this.radioButtonMaLop.CheckedChanged += new System.EventHandler(this.radioButtonMaLop_CheckedChanged);
            // 
            // radioButtonHvT
            // 
            this.radioButtonHvT.AutoSize = true;
            this.radioButtonHvT.Location = new System.Drawing.Point(410, 67);
            this.radioButtonHvT.Name = "radioButtonHvT";
            this.radioButtonHvT.Size = new System.Drawing.Size(72, 19);
            this.radioButtonHvT.TabIndex = 0;
            this.radioButtonHvT.TabStop = true;
            this.radioButtonHvT.Text = "Họ và tên";
            this.radioButtonHvT.UseVisualStyleBackColor = true;
            this.radioButtonHvT.CheckedChanged += new System.EventHandler(this.radioButtonHvT_CheckedChanged);
            // 
            // radioButtonMaSV
            // 
            this.radioButtonMaSV.AutoSize = true;
            this.radioButtonMaSV.Location = new System.Drawing.Point(298, 67);
            this.radioButtonMaSV.Name = "radioButtonMaSV";
            this.radioButtonMaSV.Size = new System.Drawing.Size(90, 19);
            this.radioButtonMaSV.TabIndex = 0;
            this.radioButtonMaSV.TabStop = true;
            this.radioButtonMaSV.Text = "Mã Sinh Viên";
            this.radioButtonMaSV.UseVisualStyleBackColor = true;
            this.radioButtonMaSV.CheckedChanged += new System.EventHandler(this.radioButtonMaSV_CheckedChanged);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.RadioButton radioButtonMaLop;
        private System.Windows.Forms.RadioButton radioButtonHvT;
        private System.Windows.Forms.RadioButton radioButtonMaSV;
    }
}