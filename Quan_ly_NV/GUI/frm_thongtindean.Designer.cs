namespace Quan_ly_NV
{
    partial class frm_thongtindean
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
            this.btn_loaddata__xtt = new System.Windows.Forms.Button();
            this.dtg_thongtindean = new System.Windows.Forms.DataGridView();
            this.clb_mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_tende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtindean)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loaddata__xtt
            // 
            this.btn_loaddata__xtt.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_loaddata__xtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loaddata__xtt.FlatAppearance.BorderSize = 0;
            this.btn_loaddata__xtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaddata__xtt.Location = new System.Drawing.Point(839, 57);
            this.btn_loaddata__xtt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loaddata__xtt.Name = "btn_loaddata__xtt";
            this.btn_loaddata__xtt.Size = new System.Drawing.Size(155, 31);
            this.btn_loaddata__xtt.TabIndex = 3;
            this.btn_loaddata__xtt.Text = "Load data";
            this.btn_loaddata__xtt.UseVisualStyleBackColor = true;
            this.btn_loaddata__xtt.Click += new System.EventHandler(this.btn_loaddata__xtt_Click);
            // 
            // dtg_thongtindean
            // 
            this.dtg_thongtindean.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtindean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtindean.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clb_mada,
            this.clb_tende,
            this.clb_ngaybd,
            this.clb_phong});
            this.dtg_thongtindean.GridColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtindean.Location = new System.Drawing.Point(0, 117);
            this.dtg_thongtindean.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_thongtindean.Name = "dtg_thongtindean";
            this.dtg_thongtindean.RowHeadersWidth = 51;
            this.dtg_thongtindean.Size = new System.Drawing.Size(1075, 437);
            this.dtg_thongtindean.TabIndex = 4;
            this.dtg_thongtindean.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_thongtindean_CellContentClick);
            // 
            // clb_mada
            // 
            this.clb_mada.HeaderText = "MADA";
            this.clb_mada.MinimumWidth = 6;
            this.clb_mada.Name = "clb_mada";
            this.clb_mada.Width = 125;
            // 
            // clb_tende
            // 
            this.clb_tende.HeaderText = "TENDA";
            this.clb_tende.MinimumWidth = 6;
            this.clb_tende.Name = "clb_tende";
            this.clb_tende.Width = 125;
            // 
            // clb_ngaybd
            // 
            this.clb_ngaybd.HeaderText = "NGAYBD";
            this.clb_ngaybd.MinimumWidth = 6;
            this.clb_ngaybd.Name = "clb_ngaybd";
            this.clb_ngaybd.Width = 125;
            // 
            // clb_phong
            // 
            this.clb_phong.HeaderText = "PHONG";
            this.clb_phong.MinimumWidth = 6;
            this.clb_phong.Name = "clb_phong";
            this.clb_phong.Width = 125;
            // 
            // frm_thongtindean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtg_thongtindean);
            this.Controls.Add(this.btn_loaddata__xtt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongtindean";
            this.Text = "frm_thongtindean";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtindean)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loaddata__xtt;
        private System.Windows.Forms.DataGridView dtg_thongtindean;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_tende;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_phong;
    }
}