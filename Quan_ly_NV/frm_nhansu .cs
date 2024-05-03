using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class frm_nhansu : Form
    {
        private Form activeForm;
        public frm_nhansu()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_show.Controls.Add(childForm);
            this.panel_show.Tag = childForm;
            childForm.Show();

        }

        private void btn_thongtinnhanvien_Click(object sender, EventArgs e)
        {
            Home.Text = btn_thongtinnhansu.Text;
            OpenChildForm(new frm_thongtinnhanvien(), sender);

        }

        private void frm_nhansu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
