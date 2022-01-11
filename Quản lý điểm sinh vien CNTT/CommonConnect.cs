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
using System.Diagnostics;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    class CommonConnect
    {
        //Phương thức kết nối chung 
     

 
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlCommand cmd1;
        private SqlDataReader reader1;
        private SqlCommand cmd2;
        private SqlDataReader reader2;
        DataSet ds = new DataSet();
        SqlDataAdapter sqlda;
        SqlCommand sqlcom;
        SqlConnection sqlcon;
        string strconnect = "Data Source=TIEUBACHDUONG\\SQLEXPRESS;Initial Catalog=Quanlydiem;Integrated Security=True";
        // Trả về đối tượng kết nối
        public  SqlConnection Connected()
        {
            string conect = SystemInformation.UserDomainName.ToString();

            string source = "Data Source="+ conect +"\\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";       
            conn = new SqlConnection(source);
            conn.Open();            
            return conn;   
        }
        public void loaddatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }
        void ketnoi()
        {
            sqlcon = new SqlConnection(strconnect);
            sqlcon.Open();
        }

        void ngatketnoi()
        {
            sqlcon.Close();
        }
        public void loadtextbox(TextBox tb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            reader = sqlcom.ExecuteReader();
            while (reader.Read())
            {
                tb.Lines[0] = (reader[chiso].ToString());
            }
            ngatketnoi();
        }
        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            reader = sqlcom.ExecuteReader();
            while (reader.Read())
            {
                cb.Items.Add(reader[chiso].ToString());
            }
            ngatketnoi();
        }
        public DataTable loaddatagridview2(string strselect)
        {
            DataTable data = new DataTable();
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            //sqlda.Fill(ds, "tenbang");
            sqlda.Fill(data);
            return data;
            //dg.DataSource = ds.Tables[0];
        }
        internal void loadtextbox(TextBox textBoxTimKiem, string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}

