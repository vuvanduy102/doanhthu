using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class Frmcau3 : Form
    {
        public Frmcau3()
        {
            InitializeComponent();
        }

        private void Frmcau3_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select chitietthuesach.masach,chitietthuesach.mathue from chitietthuesach join trasach on trasach.mathue =chitietthuesach.mathue join chitiettrasach on trasach.matra=chitiettrasach.matra where chitietthuesach.mathue = '"+txttimmathue+"' and chitietthuesach.masach not in (select masach from chitiettrasach join trasach on chitiettrasach.matra = trasach.matra where trasach.mathue = '"+txttimmathue+"')";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitiettrasach = new DataTable();
            adp.Fill(tblchitiettrasach);
            dataGridView1.DataSource = tblchitiettrasach;
        }
    }
}
