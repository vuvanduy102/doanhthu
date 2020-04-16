namespace baitapnhom
{
    partial class frmchitietthuesach
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
            this.lblmathue = new System.Windows.Forms.Label();
            this.txtmathue = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lblmasach = new System.Windows.Forms.Label();
            this.txtmatinhtrang = new System.Windows.Forms.TextBox();
            this.lblmatinhtrang = new System.Windows.Forms.Label();
            this.txtdatra = new System.Windows.Forms.TextBox();
            this.lbldatra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.so = new System.Windows.Forms.Label();
            this.btnslcon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmathue
            // 
            this.lblmathue.AutoSize = true;
            this.lblmathue.Location = new System.Drawing.Point(62, 20);
            this.lblmathue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmathue.Name = "lblmathue";
            this.lblmathue.Size = new System.Drawing.Size(67, 20);
            this.lblmathue.TabIndex = 0;
            this.lblmathue.Text = "Mã thuê";
            // 
            // txtmathue
            // 
            this.txtmathue.Location = new System.Drawing.Point(147, 20);
            this.txtmathue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmathue.Name = "txtmathue";
            this.txtmathue.Size = new System.Drawing.Size(199, 26);
            this.txtmathue.TabIndex = 1;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(147, 78);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(199, 26);
            this.txtmasach.TabIndex = 3;
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(62, 78);
            this.lblmasach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(69, 20);
            this.lblmasach.TabIndex = 2;
            this.lblmasach.Text = "Mã sách";
            // 
            // txtmatinhtrang
            // 
            this.txtmatinhtrang.Location = new System.Drawing.Point(531, 20);
            this.txtmatinhtrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatinhtrang.Name = "txtmatinhtrang";
            this.txtmatinhtrang.Size = new System.Drawing.Size(193, 26);
            this.txtmatinhtrang.TabIndex = 5;
            // 
            // lblmatinhtrang
            // 
            this.lblmatinhtrang.AutoSize = true;
            this.lblmatinhtrang.Location = new System.Drawing.Point(418, 20);
            this.lblmatinhtrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatinhtrang.Name = "lblmatinhtrang";
            this.lblmatinhtrang.Size = new System.Drawing.Size(102, 20);
            this.lblmatinhtrang.TabIndex = 4;
            this.lblmatinhtrang.Text = "Mã tình trạng";
            // 
            // txtdatra
            // 
            this.txtdatra.Location = new System.Drawing.Point(531, 78);
            this.txtdatra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatra.Name = "txtdatra";
            this.txtdatra.Size = new System.Drawing.Size(193, 26);
            this.txtdatra.TabIndex = 7;
            // 
            // lbldatra
            // 
            this.lbldatra.AutoSize = true;
            this.lbldatra.Location = new System.Drawing.Point(446, 78);
            this.lbldatra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatra.Name = "lbldatra";
            this.lbldatra.Size = new System.Drawing.Size(53, 20);
            this.lbldatra.TabIndex = 6;
            this.lbldatra.Text = "Đã trả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathue,
            this.masach,
            this.matinhtrang,
            this.datra});
            this.dataGridView1.Location = new System.Drawing.Point(66, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(660, 286);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mathue
            // 
            this.mathue.DataPropertyName = "mathue";
            this.mathue.HeaderText = "Mã thuê";
            this.mathue.MinimumWidth = 8;
            this.mathue.Name = "mathue";
            this.mathue.Width = 150;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 8;
            this.masach.Name = "masach";
            this.masach.Width = 150;
            // 
            // matinhtrang
            // 
            this.matinhtrang.DataPropertyName = "matinhtrang";
            this.matinhtrang.HeaderText = "Mã tình trạng";
            this.matinhtrang.MinimumWidth = 8;
            this.matinhtrang.Name = "matinhtrang";
            this.matinhtrang.Width = 150;
            // 
            // datra
            // 
            this.datra.DataPropertyName = "datra";
            this.datra.HeaderText = "Đã trả";
            this.datra.MinimumWidth = 8;
            this.datra.Name = "datra";
            this.datra.Width = 150;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(66, 515);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 35);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(192, 515);
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
            this.btnsua.Location = new System.Drawing.Point(333, 515);
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
            this.btnlammoi.Location = new System.Drawing.Point(470, 515);
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
            this.btnthoat.Location = new System.Drawing.Point(614, 515);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 35);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(147, 142);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(199, 26);
            this.txttimkiem.TabIndex = 14;
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.Location = new System.Drawing.Point(64, 142);
            this.lbltimkiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(71, 20);
            this.lbltimkiem.TabIndex = 15;
            this.lbltimkiem.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(69, 175);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 35);
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(556, 169);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(193, 26);
            this.txtsoluong.TabIndex = 18;
            
            // 
            // so
            // 
            this.so.AutoSize = true;
            this.so.Location = new System.Drawing.Point(401, 175);
            this.so.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(137, 20);
            this.so.TabIndex = 17;
            this.so.Text = "số lượng sách còn";
            // 
            // btnslcon
            // 
            this.btnslcon.Location = new System.Drawing.Point(422, 127);
            this.btnslcon.Name = "btnslcon";
            this.btnslcon.Size = new System.Drawing.Size(116, 35);
            this.btnslcon.TabIndex = 19;
            this.btnslcon.Text = "Hiện sl còn";
            this.btnslcon.UseVisualStyleBackColor = true;
            this.btnslcon.Click += new System.EventHandler(this.btnslcon_Click);
            // 
            // frmchitietthuesach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.btnslcon);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.so);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbltimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdatra);
            this.Controls.Add(this.lbldatra);
            this.Controls.Add(this.txtmatinhtrang);
            this.Controls.Add(this.lblmatinhtrang);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lblmasach);
            this.Controls.Add(this.txtmathue);
            this.Controls.Add(this.lblmathue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmchitietthuesach";
            this.Text = "Chi tiết thuê sách";
            this.Load += new System.EventHandler(this.frmchitietthuesach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmathue;
        private System.Windows.Forms.TextBox txtmathue;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.TextBox txtmatinhtrang;
        private System.Windows.Forms.Label lblmatinhtrang;
        private System.Windows.Forms.TextBox txtdatra;
        private System.Windows.Forms.Label lbldatra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn datra;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label so;
        private System.Windows.Forms.Button btnslcon;
    }
}

