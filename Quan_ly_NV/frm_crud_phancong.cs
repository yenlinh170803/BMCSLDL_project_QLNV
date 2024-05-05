using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class frm_crud_phancong : Form
    {
        public frm_crud_phancong()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.grpCapnhat = new System.Windows.Forms.GroupBox();
            this.lblCapnhat = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpXoa = new System.Windows.Forms.GroupBox();
            this.lblXoa = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpThem = new System.Windows.Forms.GroupBox();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpThoigian = new System.Windows.Forms.DateTimePicker();
            this.cboMaDA = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lblThoigian = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grpCapnhat.SuspendLayout();
            this.grpXoa.SuspendLayout();
            this.grpThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCapnhat
            // 
            this.grpCapnhat.Controls.Add(this.lblCapnhat);
            this.grpCapnhat.Controls.Add(this.btnCapnhat);
            this.grpCapnhat.Controls.Add(this.dateTimePicker1);
            this.grpCapnhat.Controls.Add(this.comboBox3);
            this.grpCapnhat.Controls.Add(this.comboBox4);
            this.grpCapnhat.Controls.Add(this.label2);
            this.grpCapnhat.Controls.Add(this.label5);
            this.grpCapnhat.Controls.Add(this.label6);
            this.grpCapnhat.Location = new System.Drawing.Point(528, 71);
            this.grpCapnhat.Name = "grpCapnhat";
            this.grpCapnhat.Size = new System.Drawing.Size(260, 301);
            this.grpCapnhat.TabIndex = 12;
            this.grpCapnhat.TabStop = false;
            this.grpCapnhat.Text = "CẬP NHẬT";
            // 
            // lblCapnhat
            // 
            this.lblCapnhat.AutoSize = true;
            this.lblCapnhat.Location = new System.Drawing.Point(99, 38);
            this.lblCapnhat.Name = "lblCapnhat";
            this.lblCapnhat.Size = new System.Drawing.Size(61, 13);
            this.lblCapnhat.TabIndex = 8;
            this.lblCapnhat.Text = "CẬP NHẬT";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(87, 187);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(127, 32);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(114, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(115, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(114, 72);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(115, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã đề án";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhân viên";
            // 
            // grpXoa
            // 
            this.grpXoa.Controls.Add(this.lblXoa);
            this.grpXoa.Controls.Add(this.btnXoa);
            this.grpXoa.Controls.Add(this.comboBox1);
            this.grpXoa.Controls.Add(this.comboBox2);
            this.grpXoa.Controls.Add(this.label3);
            this.grpXoa.Controls.Add(this.label4);
            this.grpXoa.Location = new System.Drawing.Point(260, 71);
            this.grpXoa.Name = "grpXoa";
            this.grpXoa.Size = new System.Drawing.Size(260, 301);
            this.grpXoa.TabIndex = 11;
            this.grpXoa.TabStop = false;
            this.grpXoa.Text = "XÓA";
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.Location = new System.Drawing.Point(99, 38);
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(29, 13);
            this.lblXoa.TabIndex = 8;
            this.lblXoa.Text = "XÓA";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(87, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã đề án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // grpThem
            // 
            this.grpThem.Controls.Add(this.lblThem);
            this.grpThem.Controls.Add(this.btnThem);
            this.grpThem.Controls.Add(this.dtpThoigian);
            this.grpThem.Controls.Add(this.cboMaDA);
            this.grpThem.Controls.Add(this.cboMaNV);
            this.grpThem.Controls.Add(this.lblThoigian);
            this.grpThem.Controls.Add(this.lblMaDA);
            this.grpThem.Controls.Add(this.lblMaNV);
            this.grpThem.Location = new System.Drawing.Point(-7, 68);
            this.grpThem.Name = "grpThem";
            this.grpThem.Size = new System.Drawing.Size(260, 301);
            this.grpThem.TabIndex = 10;
            this.grpThem.TabStop = false;
            this.grpThem.Text = "THÊM";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Location = new System.Drawing.Point(99, 38);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(38, 13);
            this.lblThem.TabIndex = 8;
            this.lblThem.Text = "THÊM";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(87, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 32);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dtpThoigian
            // 
            this.dtpThoigian.Location = new System.Drawing.Point(114, 137);
            this.dtpThoigian.Name = "dtpThoigian";
            this.dtpThoigian.Size = new System.Drawing.Size(120, 20);
            this.dtpThoigian.TabIndex = 6;
            // 
            // cboMaDA
            // 
            this.cboMaDA.FormattingEnabled = true;
            this.cboMaDA.Location = new System.Drawing.Point(114, 103);
            this.cboMaDA.Name = "cboMaDA";
            this.cboMaDA.Size = new System.Drawing.Size(115, 21);
            this.cboMaDA.TabIndex = 4;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(114, 72);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(115, 21);
            this.cboMaNV.TabIndex = 3;
            // 
            // lblThoigian
            // 
            this.lblThoigian.AutoSize = true;
            this.lblThoigian.Location = new System.Drawing.Point(18, 143);
            this.lblThoigian.Name = "lblThoigian";
            this.lblThoigian.Size = new System.Drawing.Size(51, 13);
            this.lblThoigian.TabIndex = 2;
            this.lblThoigian.Text = "Thời gian";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Location = new System.Drawing.Point(18, 111);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(53, 13);
            this.lblMaDA.TabIndex = 1;
            this.lblMaDA.Text = "Mã đề án";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(18, 75);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(72, 13);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // frm_crud_phancong
            // 
            this.ClientSize = new System.Drawing.Size(866, 666);
            this.Controls.Add(this.grpCapnhat);
            this.Controls.Add(this.grpXoa);
            this.Controls.Add(this.grpThem);
            this.Name = "frm_crud_phancong";
            this.grpCapnhat.ResumeLayout(false);
            this.grpCapnhat.PerformLayout();
            this.grpXoa.ResumeLayout(false);
            this.grpXoa.PerformLayout();
            this.grpThem.ResumeLayout(false);
            this.grpThem.PerformLayout();
            this.ResumeLayout(false);

        }

        private GroupBox grpCapnhat;
        private Label lblCapnhat;
        private Button btnCapnhat;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label2;
        private Label label5;
        private Label label6;
        private GroupBox grpXoa;
        private Label lblXoa;
        private Button btnXoa;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private GroupBox grpThem;
        private Label lblThem;
        private Button btnThem;
        private DateTimePicker dtpThoigian;
        private ComboBox cboMaDA;
        private ComboBox cboMaNV;
        private Label lblThoigian;
        private Label lblMaDA;
        private Label lblMaNV;
    }
}
