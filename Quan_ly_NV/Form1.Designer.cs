namespace Quan_ly_NV
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ptb = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "teamwork.png");
            // 
            // ptb
            // 
            this.ptb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.ptb.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb.Image = global::Quan_ly_NV.Properties.Resources.teamwork;
            this.ptb.Location = new System.Drawing.Point(603, 0);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(461, 561);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.pnl_login.Controls.Add(this.cb_role);
            this.pnl_login.Controls.Add(this.lbl_role);
            this.pnl_login.Controls.Add(this.btn_Enter);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Controls.Add(this.lbl_password);
            this.pnl_login.Controls.Add(this.txt_username);
            this.pnl_login.Controls.Add(this.lbl_username);
            this.pnl_login.Controls.Add(this.lbl_welcome);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(399, 561);
            this.pnl_login.TabIndex = 1;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(132, 469);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(116, 44);
            this.btn_Enter.TabIndex = 5;
            this.btn_Enter.Text = "Đăng nhập";
            this.btn_Enter.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(48, 298);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(315, 44);
            this.txt_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_password.Location = new System.Drawing.Point(48, 251);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 25);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(48, 192);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(315, 44);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(48, 145);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(137, 25);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe Print", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(46, 42);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(328, 94);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "WELCOME";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_role.Location = new System.Drawing.Point(48, 369);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(67, 25);
            this.lbl_role.TabIndex = 6;
            this.lbl_role.Text = "Vai trò";
            // 
            // cb_role
            // 
            this.cb_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.cb_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_role.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_role.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(46, 413);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(316, 33);
            this.cb_role.TabIndex = 7;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.ptb);
            this.DoubleBuffered = true;
            this.Name = "frm_login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lbl_role;
    }
}