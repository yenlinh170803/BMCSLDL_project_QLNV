namespace Quan_ly_NV
{
    partial class frm_capnhattaichinh
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
            this.panel_show = new System.Windows.Forms.Panel();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lblPhucap = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.panel_show.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.SystemColors.Window;
            this.panel_show.Controls.Add(this.btnCapnhat);
            this.panel_show.Controls.Add(this.txtPhucap);
            this.panel_show.Controls.Add(this.txtLuong);
            this.panel_show.Controls.Add(this.cboMaNV);
            this.panel_show.Controls.Add(this.lblPhucap);
            this.panel_show.Controls.Add(this.lblMaNV);
            this.panel_show.Controls.Add(this.lblLuong);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 0);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(800, 450);
            this.panel_show.TabIndex = 3;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(272, 258);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 10;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtPhucap
            // 
            this.txtPhucap.Location = new System.Drawing.Point(244, 188);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(169, 20);
            this.txtPhucap.TabIndex = 9;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(243, 137);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(169, 20);
            this.txtLuong.TabIndex = 8;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(242, 80);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(171, 21);
            this.cboMaNV.TabIndex = 7;
            // 
            // lblPhucap
            // 
            this.lblPhucap.AutoSize = true;
            this.lblPhucap.Location = new System.Drawing.Point(140, 195);
            this.lblPhucap.Name = "lblPhucap";
            this.lblPhucap.Size = new System.Drawing.Size(47, 13);
            this.lblPhucap.TabIndex = 6;
            this.lblPhucap.Text = "Phụ cấp";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(140, 88);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(72, 13);
            this.lblMaNV.TabIndex = 5;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(140, 144);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 0;
            this.lblLuong.Text = "Lương";
            // 
            // frm_capnhattaichinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_show);
            this.Name = "frm_capnhattaichinh";
            this.Text = "frm_capnhattaichinh";
            this.Load += new System.EventHandler(this.frm_capnhattaichinh_Load);
            this.panel_show.ResumeLayout(false);
            this.panel_show.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label lblPhucap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblLuong;
    }
}