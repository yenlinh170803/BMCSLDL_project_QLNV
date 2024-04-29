namespace Quan_ly_NV
{
    partial class frm_quyen
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
            this.pnl_quyen = new System.Windows.Forms.DataGridView();
            this.cl_grantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_objectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_grantable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_quyen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_quyen
            // 
            this.pnl_quyen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pnl_quyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_quyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pnl_quyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_grantee,
            this.cl_objectname,
            this.cl_colum,
            this.cl_grantable,
            this.cl_type});
            this.pnl_quyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quyen.Location = new System.Drawing.Point(0, 0);
            this.pnl_quyen.Name = "pnl_quyen";
            this.pnl_quyen.Size = new System.Drawing.Size(800, 450);
            this.pnl_quyen.TabIndex = 0;
            // 
            // cl_grantee
            // 
            this.cl_grantee.HeaderText = "Grantee";
            this.cl_grantee.Name = "cl_grantee";
            // 
            // cl_objectname
            // 
            this.cl_objectname.HeaderText = "Object name";
            this.cl_objectname.Name = "cl_objectname";
            // 
            // cl_colum
            // 
            this.cl_colum.HeaderText = "Column";
            this.cl_colum.Name = "cl_colum";
            // 
            // cl_grantable
            // 
            this.cl_grantable.HeaderText = "Grantable";
            this.cl_grantable.Name = "cl_grantable";
            // 
            // cl_type
            // 
            this.cl_type.HeaderText = "Type";
            this.cl_type.Name = "cl_type";
            // 
            // frm_quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_quyen);
            this.Name = "frm_quyen";
            this.Text = "frm_quyen";
            ((System.ComponentModel.ISupportInitialize)(this.pnl_quyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pnl_quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_grantee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_objectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_grantable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_type;
    }
}