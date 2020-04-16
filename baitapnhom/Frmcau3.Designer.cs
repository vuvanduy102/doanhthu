namespace baitapnhom
{
    partial class Frmcau3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttimmathue = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nhập vào mã thuê";
            // 
            // txttimmathue
            // 
            this.txttimmathue.Location = new System.Drawing.Point(84, 59);
            this.txttimmathue.Name = "txttimmathue";
            this.txttimmathue.Size = new System.Drawing.Size(238, 26);
            this.txttimmathue.TabIndex = 21;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(84, 110);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(202, 55);
            this.btnhienthi.TabIndex = 20;
            this.btnhienthi.Text = "Hiển thị các sách chưa trả";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(611, 192);
            this.dataGridView1.TabIndex = 23;
            // 
            // Frmcau3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimmathue);
            this.Controls.Add(this.btnhienthi);
            this.Name = "Frmcau3";
            this.Text = "Frmcau3";
            this.Load += new System.EventHandler(this.Frmcau3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimmathue;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}