using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace baitapnhom
{
    public partial class Frmbaocao1 : Form
    {
        public Frmbaocao1()
        {
            InitializeComponent();
        }

        private void Frmbaocao1_Load(object sender, EventArgs e)
        {
            DAO.connect();
            loaddata();
        }
        private void loaddata()
        {

            string sql = "select * from sachtruyen  where masach in (select masach from chitietthuesach where chitietthuesach.masach = sachtruyen.masach)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitietthuesach = new DataTable();
            adp.Fill(tblchitietthuesach);
            dataGridView1.DataSource = tblchitietthuesach;
        }
    }
}
