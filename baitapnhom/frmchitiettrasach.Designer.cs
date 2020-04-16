namespace baitapnhom
{
    partial class frmchitiettrasach
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
            this.lblmatra = new System.Windows.Forms.Label();
            this.txtmatra = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lblmasach = new System.Windows.Forms.Label();
            this.txtmavipham = new System.Windows.Forms.TextBox();
            this.lblmavipham = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mavipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.lbltukhoa = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimmathue = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.txttinhtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatra
            // 
            this.lblmatra.AutoSize = true;
            this.lblmatra.Location = new System.Drawing.Point(18, 18);
            this.lblmatra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatra.Name = "lblmatra";
            this.lblmatra.Size = new System.Drawing.Size(58, 20);
            this.lblmatra.TabIndex = 0;
            this.lblmatra.Text = "Mã Trả";
            // 
            // txtmatra
            // 
            this.txtmatra.Location = new System.Drawing.Point(92, 18);
            this.txtmatra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatra.Name = "txtmatra";
            this.txtmatra.Size = new System.Drawing.Size(218, 26);
            this.txtmatra.TabIndex = 1;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(92, 80);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(218, 26);
            this.txtmasach.TabIndex = 3;
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(10, 85);
            this.lblmasach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(69, 20);
            this.lblmasach.TabIndex = 2;
            this.lblmasach.Text = "Mã sách";
            // 
            // txtmavipham
            // 
            this.txtmavipham.Location = new System.Drawing.Point(418, 18);
            this.txtmavipham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmavipham.Name = "txtmavipham";
            this.txtmavipham.Size = new System.Drawing.Size(256, 26);
            this.txtmavipham.TabIndex = 5;
            // 
            // lblmavipham
            // 
            this.lblmavipham.AutoSize = true;
            this.lblmavipham.Location = new System.Drawing.Point(315, 23);
            this.lblmavipham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmavipham.Name = "lblmavipham";
            this.lblmavipham.Size = new System.Drawing.Size(89, 20);
            this.lblmavipham.TabIndex = 4;
            this.lblmavipham.Text = "Mã vi phạm";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(418, 80);
            this.txtthanhtien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(256, 26);
            this.txtthanhtien.TabIndex = 7;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(321, 85);
            this.lblthanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(84, 20);
            this.lblthanhtien.TabIndex = 6;
            this.lblthanhtien.Text = "Thành tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matra,
            this.masach,
            this.mavipham,
            this.thanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(15, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(666, 355);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // matra
            // 
            this.matra.DataPropertyName = "matra";
            this.matra.HeaderText = "Mã trả";
            this.matra.MinimumWidth = 8;
            this.matra.Name = "matra";
            this.matra.Width = 150;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 8;
            this.masach.Name = "masach";
            this.masach.Width = 150;
            // 
            // mavipham
            // 
            this.mavipham.DataPropertyName = "mavipham";
            this.mavipham.HeaderText = "Mã vi phạm";
            this.mavipham.MinimumWidth = 8;
            this.mavipham.Name = "mavipham";
            this.mavipham.Width = 150;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 150;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(710, 338);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 102);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(710, 448);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 35);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(873, 403);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 35);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(873, 338);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(112, 35);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(873, 448);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 35);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(770, 14);
            this.txttukhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(256, 26);
            this.txttukhoa.TabIndex = 15;
            // 
            // lbltukhoa
            // 
            this.lbltukhoa.AutoSize = true;
            this.lbltukhoa.Location = new System.Drawing.Point(690, 18);
            this.lbltukhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltukhoa.Name = "lbltukhoa";
            this.lbltukhoa.Size = new System.Drawing.Size(66, 20);
            this.lbltukhoa.TabIndex = 14;
            this.lbltukhoa.Text = "Từ khóa";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(826, 54);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 35);
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nhập vào mã thuê";
            // 
            // txttimmathue
            // 
            this.txttimmathue.Location = new System.Drawing.Point(760, 129);
            this.txttimmathue.Name = "txttimmathue";
            this.txttimmathue.Size = new System.Drawing.Size(238, 26);
            this.txttimmathue.TabIndex = 24;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(760, 170);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(202, 55);
            this.btnhienthi.TabIndex = 23;
            this.btnhienthi.Text = "Hiển thị các sách chưa trả";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(760, 231);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(85, 39);
            this.btntinhtien.TabIndex = 26;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // txttinhtien
            // 
            this.txttinhtien.Location = new System.Drawing.Point(760, 289);
            this.txttinhtien.Name = "txttinhtien";
            this.txttinhtien.Size = new System.Drawing.Size(158, 26);
            this.txttinhtien.TabIndex = 27;
            // 
            // frmchitiettrasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 522);
            this.Controls.Add(this.txttinhtien);
            this.Controls.Add(this.btntinhtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimmathue);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.lbltukhoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.txtmavipham);
            this.Controls.Add(this.lblmavipham);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lblmasach);
            this.Controls.Add(this.txtmatra);
            this.Controls.Add(this.lblmatra);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmchitiettrasach";
            this.Text = "Chi tiết trả sách";
            this.Load += new System.EventHandler(this.frmchitiettrasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatra;
        private System.Windows.Forms.TextBox txtmatra;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.TextBox txtmavipham;
        private System.Windows.Forms.Label lblmavipham;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matra;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label lbltukhoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimmathue;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.TextBox txttinhtien;
    }
}