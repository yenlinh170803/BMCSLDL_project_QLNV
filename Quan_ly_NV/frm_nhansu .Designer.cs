namespace Quan_ly_NV
{
    partial class frm_nhansu
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_show_formchild = new System.Windows.Forms.Panel();
            this.btn_thongtinnhansu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Label();
            this.panel_show_enter.SuspendLayout();
            this.panel_show.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show_enter
            // 
            this.panel_show_enter.BackColor = System.Drawing.Color.White;
            this.panel_show_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show_enter.Controls.Add(this.panel3);
            this.panel_show_enter.Controls.Add(this.panel_show);
            this.panel_show_enter.Controls.Add(this.pnl_menu);
            this.panel_show_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show_enter.Location = new System.Drawing.Point(0, 0);
            this.panel_show_enter.Margin = new System.Windows.Forms.Padding(4);
            this.panel_show_enter.Name = "panel_show_enter";
            this.panel_show_enter.Size = new System.Drawing.Size(758, 555);
            this.panel_show_enter.TabIndex = 2;
            // 
            // panel_show
            // 
            this.panel_show.Controls.Add(this.dataGridView1);
            this.panel_show.Location = new System.Drawing.Point(383, 105);
            this.panel_show.Margin = new System.Windows.Forms.Padding(4);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1036, 586);
            this.panel_show.TabIndex = 2;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu.Controls.Add(this.panel2);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(385, 555);
            this.pnl_menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnl_show_formchild);
            this.panel2.Controls.Add(this.btn_thongtinnhansu);
            this.panel2.Location = new System.Drawing.Point(5, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 597);
            this.panel2.TabIndex = 1;
            // 
            // pnl_show_formchild
            // 
            this.pnl_show_formchild.Location = new System.Drawing.Point(377, 12);
            this.pnl_show_formchild.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_show_formchild.Name = "pnl_show_formchild";
            this.pnl_show_formchild.Size = new System.Drawing.Size(1035, 583);
            this.pnl_show_formchild.TabIndex = 4;
            // 
            // btn_thongtinnhansu
            // 
            this.btn_thongtinnhansu.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_thongtinnhansu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thongtinnhansu.FlatAppearance.BorderSize = 0;
            this.btn_thongtinnhansu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtinnhansu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnhansu.Location = new System.Drawing.Point(0, 15);
            this.btn_thongtinnhansu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thongtinnhansu.Name = "btn_thongtinnhansu";
            this.btn_thongtinnhansu.Size = new System.Drawing.Size(379, 98);
            this.btn_thongtinnhansu.TabIndex = 0;
            this.btn_thongtinnhansu.Text = "Thông tin nhân sự";
            this.btn_thongtinnhansu.UseVisualStyleBackColor = true;
            this.btn_thongtinnhansu.Click += new System.EventHandler(this.btn_thongtinnhanvien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 100);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Salary,
            this.vitri});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 500;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 586);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Lương";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.Width = 125;
            // 
            // vitri
            // 
            this.vitri.HeaderText = "Vị trí";
            this.vitri.MinimumWidth = 6;
            this.vitri.Name = "vitri";
            this.vitri.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.Home);
            this.panel3.Location = new System.Drawing.Point(383, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 97);
            this.panel3.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(174, 38);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(78, 29);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_nhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 555);
            this.Controls.Add(this.panel_show_enter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_nhansu";
            this.Text = "frm_employee";
            this.Load += new System.EventHandler(this.frm_nhansu_Load);
            this.panel_show_enter.ResumeLayout(false);
            this.panel_show.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show_enter;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_show_formchild;
        private System.Windows.Forms.Button btn_thongtinnhansu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Home;
    }
}