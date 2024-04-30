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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtindean)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loaddata__xtt
            // 
            this.btn_loaddata__xtt.BackgroundImage = global::Quan_ly_NV.Properties.Resources.backgroud;
            this.btn_loaddata__xtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loaddata__xtt.FlatAppearance.BorderSize = 0;
            this.btn_loaddata__xtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaddata__xtt.Location = new System.Drawing.Point(629, 46);
            this.btn_loaddata__xtt.Name = "btn_loaddata__xtt";
            this.btn_loaddata__xtt.Size = new System.Drawing.Size(116, 25);
            this.btn_loaddata__xtt.TabIndex = 3;
            this.btn_loaddata__xtt.Text = "Load data";
            this.btn_loaddata__xtt.UseVisualStyleBackColor = true;
            // 
            // dtg_thongtindean
            // 
            this.dtg_thongtindean.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtindean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtindean.Location = new System.Drawing.Point(0, 95);
            this.dtg_thongtindean.Name = "dtg_thongtindean";
            this.dtg_thongtindean.Size = new System.Drawing.Size(806, 355);
            this.dtg_thongtindean.TabIndex = 4;
            // 
            // frm_thongtindean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_thongtindean);
            this.Controls.Add(this.btn_loaddata__xtt);
            this.Name = "frm_thongtindean";
            this.Text = "frm_thongtindean";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtindean)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loaddata__xtt;
        private System.Windows.Forms.DataGridView dtg_thongtindean;
    }
}