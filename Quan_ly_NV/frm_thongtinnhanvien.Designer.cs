namespace Quan_ly_NV
{
    partial class frm_thongtinnhanvien
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
            this.tb_thongtinnhanvien = new System.Windows.Forms.TabControl();
            this.tb_xemthongtin = new System.Windows.Forms.TabPage();
            this.tb_capnhatthongtin = new System.Windows.Forms.TabPage();
            this.dtg_xemthongtin = new System.Windows.Forms.DataGridView();
            this.clb_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_vaitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_maql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_phg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loaddata__xtt = new System.Windows.Forms.Button();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.dtP_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.tb_thongtinnhanvien.SuspendLayout();
            this.tb_xemthongtin.SuspendLayout();
            this.tb_capnhatthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemthongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_thongtinnhanvien
            // 
            this.tb_thongtinnhanvien.Controls.Add(this.tb_xemthongtin);
            this.tb_thongtinnhanvien.Controls.Add(this.tb_capnhatthongtin);
            this.tb_thongtinnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_thongtinnhanvien.Location = new System.Drawing.Point(0, 0);
            this.tb_thongtinnhanvien.Name = "tb_thongtinnhanvien";
            this.tb_thongtinnhanvien.SelectedIndex = 0;
            this.tb_thongtinnhanvien.Size = new System.Drawing.Size(800, 450);
            this.tb_thongtinnhanvien.TabIndex = 0;
            // 
            // tb_xemthongtin
            // 
            this.tb_xemthongtin.Controls.Add(this.btn_loaddata__xtt);
            this.tb_xemthongtin.Controls.Add(this.dtg_xemthongtin);
            this.tb_xemthongtin.Location = new System.Drawing.Point(4, 22);
            this.tb_xemthongtin.Name = "tb_xemthongtin";
            this.tb_xemthongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tb_xemthongtin.Size = new System.Drawing.Size(792, 424);
            this.tb_xemthongtin.TabIndex = 0;
            this.tb_xemthongtin.Text = "Xem thông tin";
            this.tb_xemthongtin.UseVisualStyleBackColor = true;
            // 
            // tb_capnhatthongtin
            // 
            this.tb_capnhatthongtin.Controls.Add(this.btn_capnhat);
            this.tb_capnhatthongtin.Controls.Add(this.txt_sdt);
            this.tb_capnhatthongtin.Controls.Add(this.lbl_sdt);
            this.tb_capnhatthongtin.Controls.Add(this.txt_diachi);
            this.tb_capnhatthongtin.Controls.Add(this.lbl_diachi);
            this.tb_capnhatthongtin.Controls.Add(this.dtP_ngaysinh);
            this.tb_capnhatthongtin.Controls.Add(this.lbl_ngaysinh);
            this.tb_capnhatthongtin.Location = new System.Drawing.Point(4, 22);
            this.tb_capnhatthongtin.Name = "tb_capnhatthongtin";
            this.tb_capnhatthongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tb_capnhatthongtin.Size = new System.Drawing.Size(792, 424);
            this.tb_capnhatthongtin.TabIndex = 1;
            this.tb_capnhatthongtin.Text = "Cập nhật thông tin";
            this.tb_capnhatthongtin.UseVisualStyleBackColor = true;
            // 
            // dtg_xemthongtin
            // 
            this.dtg_xemthongtin.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_xemthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_xemthongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clb_manv,
            this.clb_tennv,
            this.clb_phai,
            this.clb_ngaysinh,
            this.clb_diachi,
            this.clb_sodt,
            this.clb_luong,
            this.clb_phucap,
            this.clb_vaitro,
            this.clb_maql,
            this.clb_phg});
            this.dtg_xemthongtin.Location = new System.Drawing.Point(5, 75);
            this.dtg_xemthongtin.Name = "dtg_xemthongtin";
            this.dtg_xemthongtin.Size = new System.Drawing.Size(787, 341);
            this.dtg_xemthongtin.TabIndex = 0;
            // 
            // clb_manv
            // 
            this.clb_manv.HeaderText = "Mã NV";
            this.clb_manv.Name = "clb_manv";
            // 
            // clb_tennv
            // 
            this.clb_tennv.HeaderText = "Tên NV";
            this.clb_tennv.Name = "clb_tennv";
            // 
            // clb_phai
            // 
            this.clb_phai.HeaderText = "Phái";
            this.clb_phai.Name = "clb_phai";
            // 
            // clb_ngaysinh
            // 
            this.clb_ngaysinh.HeaderText = "Ngày sinh";
            this.clb_ngaysinh.Name = "clb_ngaysinh";
            // 
            // clb_diachi
            // 
            this.clb_diachi.HeaderText = "Địa chỉ";
            this.clb_diachi.Name = "clb_diachi";
            // 
            // clb_sodt
            // 
            this.clb_sodt.HeaderText = "Số ĐT";
            this.clb_sodt.Name = "clb_sodt";
            // 
            // clb_luong
            // 
            this.clb_luong.HeaderText = "Lương";
            this.clb_luong.Name = "clb_luong";
            // 
            // clb_phucap
            // 
            this.clb_phucap.HeaderText = "Phụ cấp";
            this.clb_phucap.Name = "clb_phucap";
            // 
            // clb_vaitro
            // 
            this.clb_vaitro.HeaderText = "Vai trò";
            this.clb_vaitro.Name = "clb_vaitro";
            // 
            // clb_maql
            // 
            this.clb_maql.HeaderText = "Mã QL";
            this.clb_maql.Name = "clb_maql";
            // 
            // clb_phg
            // 
            this.clb_phg.HeaderText = "PHG";
            this.clb_phg.Name = "clb_phg";
            // 
            // btn_loaddata__xtt
            // 
            this.btn_loaddata__xtt.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_loaddata__xtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loaddata__xtt.FlatAppearance.BorderSize = 0;
            this.btn_loaddata__xtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaddata__xtt.Location = new System.Drawing.Point(592, 33);
            this.btn_loaddata__xtt.Name = "btn_loaddata__xtt";
            this.btn_loaddata__xtt.Size = new System.Drawing.Size(116, 25);
            this.btn_loaddata__xtt.TabIndex = 1;
            this.btn_loaddata__xtt.Text = "Load data";
            this.btn_loaddata__xtt.UseVisualStyleBackColor = true;
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(161, 87);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbl_ngaysinh.TabIndex = 0;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // dtP_ngaysinh
            // 
            this.dtP_ngaysinh.Location = new System.Drawing.Point(270, 82);
            this.dtP_ngaysinh.Name = "dtP_ngaysinh";
            this.dtP_ngaysinh.Size = new System.Drawing.Size(243, 20);
            this.dtP_ngaysinh.TabIndex = 1;
            this.dtP_ngaysinh.Value = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(161, 167);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(40, 13);
            this.lbl_diachi.TabIndex = 2;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(270, 149);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(243, 60);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(270, 256);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(243, 32);
            this.txt_sdt.TabIndex = 5;
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(161, 263);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(70, 13);
            this.lbl_sdt.TabIndex = 4;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_capnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_capnhat.FlatAppearance.BorderSize = 0;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Location = new System.Drawing.Point(314, 339);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(116, 25);
            this.btn_capnhat.TabIndex = 6;
            this.btn_capnhat.Text = "Cập nhật ";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // frm_thongtinnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_thongtinnhanvien);
            this.Name = "frm_thongtinnhanvien";
            this.Text = "frm_thongtinnhanvien";
            this.tb_thongtinnhanvien.ResumeLayout(false);
            this.tb_xemthongtin.ResumeLayout(false);
            this.tb_capnhatthongtin.ResumeLayout(false);
            this.tb_capnhatthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemthongtin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_thongtinnhanvien;
        private System.Windows.Forms.TabPage tb_xemthongtin;
        private System.Windows.Forms.DataGridView dtg_xemthongtin;
        private System.Windows.Forms.TabPage tb_capnhatthongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_vaitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_maql;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_phg;
        private System.Windows.Forms.Button btn_loaddata__xtt;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.DateTimePicker dtP_ngaysinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
    }
}