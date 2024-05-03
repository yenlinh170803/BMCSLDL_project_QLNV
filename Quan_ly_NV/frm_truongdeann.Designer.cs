namespace Quan_ly_NV
{
    partial class frm_truongdeann
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_of_leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_of_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_of_leader,
            this.Name_of_project,
            this.Start_day,
            this.End_day});
            this.dataGridView1.Location = new System.Drawing.Point(5, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name_of_leader
            // 
            this.Name_of_leader.HeaderText = "Trưởng đề án";
            this.Name_of_leader.MinimumWidth = 6;
            this.Name_of_leader.Name = "Name_of_leader";
            this.Name_of_leader.Width = 125;
            // 
            // Name_of_project
            // 
            this.Name_of_project.HeaderText = "Tên dề án";
            this.Name_of_project.MinimumWidth = 6;
            this.Name_of_project.Name = "Name_of_project";
            this.Name_of_project.Width = 125;
            // 
            // Start_day
            // 
            this.Start_day.HeaderText = "Ngày bắt đầu";
            this.Start_day.MinimumWidth = 6;
            this.Start_day.Name = "Start_day";
            this.Start_day.Width = 125;
            // 
            // End_day
            // 
            this.End_day.HeaderText = "Ngày kết thúc";
            this.End_day.MinimumWidth = 6;
            this.End_day.Name = "End_day";
            this.End_day.Width = 125;
            // 
            // frm_truongdeann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 259);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_truongdeann";
            this.Text = "frm_truongdean";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_of_leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_of_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_day;
    }
}