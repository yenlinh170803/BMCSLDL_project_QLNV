namespace Quan_ly_NV
{
    partial class frm_phanquyen
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
            System.Windows.Forms.TabControl tb_quyen;
            this.tb_Capquyen = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Thuhoiquyen = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_quyendoituong = new System.Windows.Forms.RadioButton();
            this.btn_chinhsua_2 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            tb_quyen = new System.Windows.Forms.TabControl();
            tb_quyen.SuspendLayout();
            this.tb_Capquyen.SuspendLayout();
            this.tb_Thuhoiquyen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_quyen
            // 
            tb_quyen.Controls.Add(this.tb_Capquyen);
            tb_quyen.Controls.Add(this.tb_Thuhoiquyen);
            tb_quyen.Dock = System.Windows.Forms.DockStyle.Fill;
            tb_quyen.Location = new System.Drawing.Point(0, 0);
            tb_quyen.Margin = new System.Windows.Forms.Padding(4);
            tb_quyen.Name = "tb_quyen";
            tb_quyen.SelectedIndex = 0;
            tb_quyen.Size = new System.Drawing.Size(1293, 554);
            tb_quyen.TabIndex = 0;
            // 
            // tb_Capquyen
            // 
            this.tb_Capquyen.Controls.Add(this.checkBox3);
            this.tb_Capquyen.Controls.Add(this.button3);
            this.tb_Capquyen.Controls.Add(this.checkBox2);
            this.tb_Capquyen.Controls.Add(this.button2);
            this.tb_Capquyen.Controls.Add(this.radioButton3);
            this.tb_Capquyen.Controls.Add(this.comboBox12);
            this.tb_Capquyen.Controls.Add(this.label11);
            this.tb_Capquyen.Controls.Add(this.comboBox13);
            this.tb_Capquyen.Controls.Add(this.label12);
            this.tb_Capquyen.Controls.Add(this.radioButton2);
            this.tb_Capquyen.Controls.Add(this.comboBox9);
            this.tb_Capquyen.Controls.Add(this.label8);
            this.tb_Capquyen.Controls.Add(this.comboBox10);
            this.tb_Capquyen.Controls.Add(this.label9);
            this.tb_Capquyen.Controls.Add(this.comboBox11);
            this.tb_Capquyen.Controls.Add(this.label10);
            this.tb_Capquyen.Location = new System.Drawing.Point(4, 25);
            this.tb_Capquyen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Capquyen.Name = "tb_Capquyen";
            this.tb_Capquyen.Padding = new System.Windows.Forms.Padding(4);
            this.tb_Capquyen.Size = new System.Drawing.Size(1285, 525);
            this.tb_Capquyen.TabIndex = 0;
            this.tb_Capquyen.Text = "Cấp quyền";
            this.tb_Capquyen.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(729, 314);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 20);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.Text = "With grant option";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(635, 357);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 47);
            this.button3.TabIndex = 36;
            this.button3.Text = "Cấp role";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(191, 305);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 20);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "With grant option";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(250, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 47);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cấp quyền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(647, 46);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(133, 20);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cấp role cho user";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(640, 174);
            this.comboBox12.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(221, 24);
            this.comboBox12.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Role";
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(640, 124);
            this.comboBox13.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(221, 24);
            this.comboBox13.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "User";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(320, 45);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 20);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quyền đối tượng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "NHANVIEN",
            "DEAN",
            "PHANCONG",
            "PHONGBAN",
            "DATABASE"});
            this.comboBox9.Location = new System.Drawing.Point(314, 173);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(221, 24);
            this.comboBox9.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Đối tượng";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "DELETE",
            "UPDATE",
            "ALL"});
            this.comboBox10.Location = new System.Drawing.Point(314, 224);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(221, 24);
            this.comboBox10.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quyền";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(314, 123);
            this.comboBox11.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(221, 24);
            this.comboBox11.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "User/ Role";
            // 
            // tb_Thuhoiquyen
            // 
            this.tb_Thuhoiquyen.Controls.Add(this.panel2);
            this.tb_Thuhoiquyen.Location = new System.Drawing.Point(4, 25);
            this.tb_Thuhoiquyen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Thuhoiquyen.Name = "tb_Thuhoiquyen";
            this.tb_Thuhoiquyen.Padding = new System.Windows.Forms.Padding(4);
            this.tb_Thuhoiquyen.Size = new System.Drawing.Size(1285, 525);
            this.tb_Thuhoiquyen.TabIndex = 1;
            this.tb_Thuhoiquyen.Text = "Thu hồi quyền";
            this.tb_Thuhoiquyen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_quyendoituong);
            this.panel2.Controls.Add(this.btn_chinhsua_2);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 517);
            this.panel2.TabIndex = 1;
            // 
            // rb_quyendoituong
            // 
            this.rb_quyendoituong.AutoSize = true;
            this.rb_quyendoituong.Location = new System.Drawing.Point(563, 47);
            this.rb_quyendoituong.Margin = new System.Windows.Forms.Padding(4);
            this.rb_quyendoituong.Name = "rb_quyendoituong";
            this.rb_quyendoituong.Size = new System.Drawing.Size(125, 20);
            this.rb_quyendoituong.TabIndex = 19;
            this.rb_quyendoituong.TabStop = true;
            this.rb_quyendoituong.Text = "Quyền đối tượng";
            this.rb_quyendoituong.UseVisualStyleBackColor = true;
            // 
            // btn_chinhsua_2
            // 
            this.btn_chinhsua_2.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_chinhsua_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chinhsua_2.FlatAppearance.BorderSize = 0;
            this.btn_chinhsua_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chinhsua_2.Location = new System.Drawing.Point(551, 327);
            this.btn_chinhsua_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chinhsua_2.Name = "btn_chinhsua_2";
            this.btn_chinhsua_2.Size = new System.Drawing.Size(159, 46);
            this.btn_chinhsua_2.TabIndex = 18;
            this.btn_chinhsua_2.Text = "Chỉnh sửa";
            this.btn_chinhsua_2.UseVisualStyleBackColor = true;
            this.btn_chinhsua_2.Click += new System.EventHandler(this.btn_chinhsua_2_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "NHANVIEN",
            "DEAN",
            "PHANCONG",
            "PHONGBAN",
            "DATABASE"});
            this.comboBox6.Location = new System.Drawing.Point(592, 186);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(289, 24);
            this.comboBox6.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đối tượng";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "DELETE",
            "UPDATE",
            "ALL"});
            this.comboBox4.Location = new System.Drawing.Point(592, 236);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(289, 24);
            this.comboBox4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quyền";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(592, 135);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(289, 24);
            this.comboBox5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "User/ Role";
            // 
            // frm_phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 554);
            this.Controls.Add(tb_quyen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_phanquyen";
            this.Text = "frm_phanquyen";
            this.Load += new System.EventHandler(this.frm_phanquyen_Load);
            tb_quyen.ResumeLayout(false);
            this.tb_Capquyen.ResumeLayout(false);
            this.tb_Capquyen.PerformLayout();
            this.tb_Thuhoiquyen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TabPage tb_Thuhoiquyen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_quyendoituong;
        private System.Windows.Forms.Button btn_chinhsua_2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tb_Capquyen;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label10;
    }
}