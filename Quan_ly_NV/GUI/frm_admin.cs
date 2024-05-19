using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class frm_admin : Form
    {
        private Form activeForm;
        private bool formOpened = false;
        public frm_admin()
        {
            InitializeComponent();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null && activeForm.GetType() != childForm.GetType())
            {
                activeForm.Close(); // Đóng form con hiện tại
                formOpened = false; // Đặt lại giá trị biến formOpened
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Loại bỏ form con hiện tại khỏi panel_show
            foreach (Control control in panel_show.Controls)
            {
                if (control.GetType() == childForm.GetType())
                {
                    panel_show.Controls.Remove(control);
                    break;
                }
            }

            this.panel_show.Controls.Add(childForm);
            this.panel_show.Tag = childForm;
            childForm.Show();
            formOpened = true; // Đặt giá trị formOpened là true khi form đã được mở
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text=btn_danhsach.Text;
            OpenChildForm(new frm_danhsach(), sender);
        }

        private void btn_quyen_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text = btn_quyen.Text;
            OpenChildForm(new frm_quyen(), sender);
        }

        private void btn_crud_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text = btn_crud.Text;
            OpenChildForm(new frm_crud_taikhoan(), sender);
        }

        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            lbl_tiltle.Text = btn_phanquyen.Text;
            OpenChildForm(new frm_phanquyen(), sender);
        }

        private void panel_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login frm_Login = new frm_login();
            frm_Login.Show();           
        }
    }
}
