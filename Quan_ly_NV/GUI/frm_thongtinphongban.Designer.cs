namespace Quan_ly_NV
{
    partial class frm_thongtinphongban
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
            this.dtg_thongtinphongban = new System.Windows.Forms.DataGridView();
            this.clb_mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_trgphg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtinphongban)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loaddata__xtt
            // 
            this.btn_loaddata__xtt.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_loaddata__xtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loaddata__xtt.FlatAppearance.BorderSize = 0;
            this.btn_loaddata__xtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaddata__xtt.Location = new System.Drawing.Point(835, 53);
            this.btn_loaddata__xtt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loaddata__xtt.Name = "btn_loaddata__xtt";
            this.btn_loaddata__xtt.Size = new System.Drawing.Size(155, 31);
            this.btn_loaddata__xtt.TabIndex = 2;
            this.btn_loaddata__xtt.Text = "Load data";
            this.btn_loaddata__xtt.UseVisualStyleBackColor = true;
            this.btn_loaddata__xtt.Click += new System.EventHandler(this.btn_loaddata__xtt_Click);
            // 
            // dtg_thongtinphongban
            // 
            this.dtg_thongtinphongban.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtinphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtinphongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clb_mapb,
            this.clb_tenpb,
            this.clb_trgphg});
            this.dtg_thongtinphongban.Location = new System.Drawing.Point(13, 125);
            this.dtg_thongtinphongban.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_thongtinphongban.Name = "dtg_thongtinphongban";
            this.dtg_thongtinphongban.RowHeadersWidth = 51;
            this.dtg_thongtinphongban.Size = new System.Drawing.Size(1069, 432);
            this.dtg_thongtinphongban.TabIndex = 3;
            this.dtg_thongtinphongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_thongtinphongban_CellContentClick);
            // 
            // clb_mapb
            // 
            this.clb_mapb.HeaderText = "Mã PB";
            this.clb_mapb.MinimumWidth = 6;
            this.clb_mapb.Name = "clb_mapb";
            this.clb_mapb.Width = 125;
            // 
            // clb_tenpb
            // 
            this.clb_tenpb.HeaderText = "Tên PB";
            this.clb_tenpb.MinimumWidth = 6;
            this.clb_tenpb.Name = "clb_tenpb";
            this.clb_tenpb.Width = 125;
            // 
            // clb_trgphg
            // 
            this.clb_trgphg.HeaderText = "TrPHG";
            this.clb_trgphg.MinimumWidth = 6;
            this.clb_trgphg.Name = "clb_trgphg";
            this.clb_trgphg.Width = 125;
            // 
            // frm_thongtinphongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtg_thongtinphongban);
            this.Controls.Add(this.btn_loaddata__xtt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongtinphongban";
            this.Text = "frm_thongtinphongban";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtinphongban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loaddata__xtt;
        private System.Windows.Forms.DataGridView dtg_thongtinphongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_trgphg;
    }
}