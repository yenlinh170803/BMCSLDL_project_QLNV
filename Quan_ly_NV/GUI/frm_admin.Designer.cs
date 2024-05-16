namespace Quan_ly_NV
{
    partial class frm_admin
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
            this.panel_show_enter = new System.Windows.Forms.Panel();
            this.panel_show = new System.Windows.Forms.Panel();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_tiltle = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_show_formchild = new System.Windows.Forms.Panel();
            this.btn_phanquyen = new System.Windows.Forms.Button();
            this.btn_crud = new System.Windows.Forms.Button();
            this.btn_quyen = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_show_enter.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show_enter
            // 
            this.panel_show_enter.BackColor = System.Drawing.Color.White;
            this.panel_show_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show_enter.Controls.Add(this.panel_show);
            this.panel_show_enter.Controls.Add(this.pnl_name);
            this.panel_show_enter.Controls.Add(this.pnl_menu);
            this.panel_show_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show_enter.Location = new System.Drawing.Point(0, 0);
            this.panel_show_enter.Name = "panel_show_enter";
            this.panel_show_enter.Size = new System.Drawing.Size(1064, 561);
            this.panel_show_enter.TabIndex = 1;
            this.panel_show_enter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_show_Paint);
            // 
            // panel_show
            // 
            this.panel_show.Location = new System.Drawing.Point(287, 85);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(777, 476);
            this.panel_show.TabIndex = 2;
            // 
            // pnl_name
            // 
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.pnl_name.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.pnl_name.Controls.Add(this.lbl_tiltle);
            this.pnl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_name.Location = new System.Drawing.Point(289, 0);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(775, 81);
            this.pnl_name.TabIndex = 1;
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.AutoSize = true;
            this.lbl_tiltle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiltle.Location = new System.Drawing.Point(364, 29);
            this.lbl_tiltle.Name = "lbl_tiltle";
            this.lbl_tiltle.Size = new System.Drawing.Size(72, 30);
            this.lbl_tiltle.TabIndex = 0;
            this.lbl_tiltle.Text = "Home";
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu.Controls.Add(this.panel2);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(289, 561);
            this.pnl_menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnl_show_formchild);
            this.panel2.Controls.Add(this.btn_phanquyen);
            this.panel2.Controls.Add(this.btn_crud);
            this.panel2.Controls.Add(this.btn_quyen);
            this.panel2.Controls.Add(this.btn_danhsach);
            this.panel2.Location = new System.Drawing.Point(4, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 485);
            this.panel2.TabIndex = 1;
            // 
            // pnl_show_formchild
            // 
            this.pnl_show_formchild.Location = new System.Drawing.Point(283, 10);
            this.pnl_show_formchild.Name = "pnl_show_formchild";
            this.pnl_show_formchild.Size = new System.Drawing.Size(776, 474);
            this.pnl_show_formchild.TabIndex = 4;
            // 
            // btn_phanquyen
            // 
            this.btn_phanquyen.AutoEllipsis = true;
            this.btn_phanquyen.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_phanquyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phanquyen.FlatAppearance.BorderSize = 0;
            this.btn_phanquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phanquyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phanquyen.Location = new System.Drawing.Point(-1, 252);
            this.btn_phanquyen.Name = "btn_phanquyen";
            this.btn_phanquyen.Size = new System.Drawing.Size(284, 80);
            this.btn_phanquyen.TabIndex = 3;
            this.btn_phanquyen.Text = "Phân quyền";
            this.btn_phanquyen.UseVisualStyleBackColor = true;
            this.btn_phanquyen.Click += new System.EventHandler(this.btn_phanquyen_Click);
            // 
            // btn_crud
            // 
            this.btn_crud.AutoEllipsis = true;
            this.btn_crud.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_crud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crud.FlatAppearance.BorderSize = 0;
            this.btn_crud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crud.Location = new System.Drawing.Point(-1, 169);
            this.btn_crud.Name = "btn_crud";
            this.btn_crud.Size = new System.Drawing.Size(284, 80);
            this.btn_crud.TabIndex = 2;
            this.btn_crud.Text = "Thêm, sửa xóa user/role";
            this.btn_crud.UseVisualStyleBackColor = true;
            this.btn_crud.Click += new System.EventHandler(this.btn_crud_Click);
            // 
            // btn_quyen
            // 
            this.btn_quyen.AutoEllipsis = true;
            this.btn_quyen.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_quyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quyen.FlatAppearance.BorderSize = 0;
            this.btn_quyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quyen.Location = new System.Drawing.Point(-1, 87);
            this.btn_quyen.Name = "btn_quyen";
            this.btn_quyen.Size = new System.Drawing.Size(284, 80);
            this.btn_quyen.TabIndex = 1;
            this.btn_quyen.Text = "Quyền của user/role";
            this.btn_quyen.UseVisualStyleBackColor = true;
            this.btn_quyen.Click += new System.EventHandler(this.btn_quyen_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_danhsach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_danhsach.FlatAppearance.BorderSize = 0;
            this.btn_danhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_danhsach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhsach.Location = new System.Drawing.Point(0, 12);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(284, 80);
            this.btn_danhsach.TabIndex = 0;
            this.btn_danhsach.Text = "Danh sách user";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 81);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(37, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(202, 48);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Đăng xuất";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panel_show_enter);
            this.Name = "frm_admin";
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.panel_show_enter.ResumeLayout(false);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_show_enter;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_tiltle;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_quyen;
        private System.Windows.Forms.Button btn_crud;
        private System.Windows.Forms.Button btn_phanquyen;
        private System.Windows.Forms.Panel pnl_show_formchild;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Button btn_Exit;
    }
}