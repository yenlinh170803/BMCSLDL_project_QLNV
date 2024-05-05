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
    public partial class frm_truongphong : Form
    {
        private Form activeForm;
        public frm_truongphong()
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
            lbl_tiltle.Text = btn_thongtinnhanvien.Text;
            OpenChildForm(new frm_thongtinnhanvien(), sender);
        }

        private void btn_thongtinphongban_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text = btn_thongtinphongban.Text;
            OpenChildForm(new frm_thongtinphongban(), sender);
        }

        private void btn_thongtindean_Click(object sender, EventArgs e)
        {

            lbl_tiltle.Text = btn_thongtindean.Text;
            OpenChildForm(new frm_thongtindean(), sender);
        }

        private void btn_thongtinphancong_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text = btn_thongtinphancong.Text;
            OpenChildForm(new frm_thongtinphancong(), sender);
        }

        private void btn_crud_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text=btn_crud.Text;
            OpenChildForm(new frm_crud_phancong(), sender);
        }
    }
}
