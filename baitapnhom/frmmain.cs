using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void chiTiếtThuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietthuesach frm = new frmchitietthuesach();
            frm.Show();
        }

        private void sáchTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsachtruyen1 frm = new frmsachtruyen1();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.Show();
        }

        private void chiTiếtTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitiettrasach frm = new frmchitiettrasach();
            frm.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrasach frm = new frmtrasach();
            frm.Show();
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaLam frm = new frmCaLam();
            frm.Show();
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViPham frm = new frmViPham();
            frm.Show();
        }

        private void thuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthuesach frm = new frmthuesach();
            frm.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhaxuatban frm = new frmnhaxuatban();
            frm.Show();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlinhvuc frm = new frmlinhvuc();
            frm.Show();
        }

        private void danhSáchSáchThuêChưaTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbaocao1 frm = new Frmbaocao1();
            frm.Show();
        }

        private void sáchChưaTrảTheoMãThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcau3 frm = new Frmcau3();
            frm.Show();
        }

        private void doanhThuTheoThaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdt frm = new Frmdt();
            frm.Show();
        }
    }
}
