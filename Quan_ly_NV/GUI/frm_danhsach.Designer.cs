﻿namespace Quan_ly_NV
{
    partial class frm_danhsach
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
            this.dtg_danhsach = new System.Windows.Forms.DataGridView();
            this.clb_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clb_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_danhsach
            // 
            this.dtg_danhsach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_danhsach.CausesValidation = false;
            this.dtg_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clb_username,
            this.clb_userid,
            this.clb_created});
            this.dtg_danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_danhsach.Location = new System.Drawing.Point(0, 0);
            this.dtg_danhsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtg_danhsach.Name = "dtg_danhsach";
            this.dtg_danhsach.RowHeadersWidth = 51;
            this.dtg_danhsach.Size = new System.Drawing.Size(1067, 554);
            this.dtg_danhsach.TabIndex = 0;
            // 
            // clb_username
            // 
            this.clb_username.HeaderText = "USERNAME";
            this.clb_username.MinimumWidth = 6;
            this.clb_username.Name = "clb_username";
            this.clb_username.Width = 125;
            // 
            // clb_userid
            // 
            this.clb_userid.HeaderText = "USERID";
            this.clb_userid.MinimumWidth = 6;
            this.clb_userid.Name = "clb_userid";
            this.clb_userid.Width = 125;
            // 
            // clb_created
            // 
            this.clb_created.HeaderText = "CREATED";
            this.clb_created.MinimumWidth = 6;
            this.clb_created.Name = "clb_created";
            this.clb_created.Width = 125;
            // 
            // frm_danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtg_danhsach);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_danhsach";
            this.Text = "frm_danhsach";
            this.Load += new System.EventHandler(this.frm_danhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_danhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clb_created;
    }
}