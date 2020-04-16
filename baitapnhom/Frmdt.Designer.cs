namespace baitapnhom
{
    partial class Frmdt
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
            this.components = new System.ComponentModel.Container();
            this.txtdtt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdtt
            // 
            this.txtdtt.Location = new System.Drawing.Point(148, 88);
            this.txtdtt.Name = "txtdtt";
            this.txtdtt.Size = new System.Drawing.Size(100, 26);
            this.txtdtt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mời bạn nhập tháng";
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(148, 206);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(109, 47);
            this.btnhienthi.TabIndex = 3;
            this.btnhienthi.Text = "hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(148, 295);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(100, 26);
            this.txthienthi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mời bạn nhập năm";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(366, 88);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 26);
            this.txtnam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "doanh thu theo tháng của năm bạn vừa nhâp là";
            // 
            // Frmdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdtt);
            this.Name = "Frmdt";
            this.Text = "Frmdt";
            this.Load += new System.EventHandler(this.Frmdt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdtt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label3;
    }
}