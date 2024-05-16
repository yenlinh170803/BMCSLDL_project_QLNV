namespace Quan_ly_NV
{
    partial class frm_thongtinphancong
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
            this.dtg_thongtinphancong = new System.Windows.Forms.DataGridView();
            this.clb_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loaddata__xtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtinphancong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_thongtinphancong
            // 
            this.dtg_thongtinphancong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtinphancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtinphancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clb_manv,
            this.clb_mada,
            this.clb_thoigian});
            this.dtg_thongtinphancong.Location = new System.Drawing.Point(-4, 114);
            this.dtg_thongtinphancong.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_thongtinphancong.Name = "dtg_thongtinphancong";
            this.dtg_thongtinphancong.RowHeadersWidth = 51;
            this.dtg_thongtinphancong.Size = new System.Drawing.Size(1075, 437);
            this.dtg_thongtinphancong.TabIndex = 6;
            this.dtg_thongtinphancong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_thongtinphancong_CellContentClick);
            // 
            // clb_manv
            // 
            this.clb_manv.HeaderText = "MANV";
            this.clb_manv.MinimumWidth = 6;
            this.clb_manv.Name = "clb_manv";
            this.clb_manv.Width = 125;
            // 
            // clb_mada
            // 
            this.clb_mada.HeaderText = "MADA";
            this.clb_mada.MinimumWidth = 6;
            this.clb_mada.Name = "clb_mada";
            this.clb_mada.Width = 125;
            // 
            // clb_thoigian
            // 
            this.clb_thoigian.HeaderText = "THOIGIAN";
            this.clb_thoigian.MinimumWidth = 6;
            this.clb_thoigian.Name = "clb_thoigian";
            this.clb_thoigian.Width = 125;
            // 
            // btn_loaddata__xtt
            // 
            this.btn_loaddata__xtt.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_loaddata__xtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loaddata__xtt.FlatAppearance.BorderSize = 0;
            this.btn_loaddata__xtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaddata__xtt.Location = new System.Drawing.Point(835, 54);
            this.btn_loaddata__xtt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loaddata__xtt.Name = "btn_loaddata__xtt";
            this.btn_loaddata__xtt.Size = new System.Drawing.Size(155, 31);
            this.btn_loaddata__xtt.TabIndex = 5;
            this.btn_loaddata__xtt.Text = "Load data";
            this.btn_loaddata__xtt.UseVisualStyleBackColor = true;
            this.btn_loaddata__xtt.Click += new System.EventHandler(this.btn_loaddata__xtt_Click);
            // 
            // frm_thongtinphancong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtg_thongtinphancong);
            this.Controls.Add(this.btn_loaddata__xtt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongtinphancong";
            this.Text = "frm_thongtinphancong";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtinphancong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_thongtinphancong;
        private System.Windows.Forms.Button btn_loaddata__xtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_thoigian;
    }
}