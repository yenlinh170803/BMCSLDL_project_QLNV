﻿using System;
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
        private bool formOpened = false;
        public frm_nhansu()
        {
            InitializeComponent();
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


        private void btn_thongtinphongban_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_thongtinphongban.Text;
            OpenChildForm(new frm_thongtinphongban(), sender);

        }

        private void btn_thongtindean_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_thongtindean.Text;
            OpenChildForm(new frm_thongtindean(), sender);
        }

        private void btn_thongtinphancong_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_thongtinphancong.Text;
            OpenChildForm(new frm_thongtinphancong(), sender);
        }

        private void btn_thongtinnhanvien_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_thongtinnhanvien.Text;
            OpenChildForm(new frm_thongtinnhanvien(), sender);
        }

        private void btn_crud_phongban_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_crud_phongban.Text;
            OpenChildForm(new frm_crud_phongban(), sender);
        }

        private void btn_crud_nhanvien_Click(object sender, EventArgs e)
        {
            btn_home.Text = btn_crud_nhanvien.Text;
            OpenChildForm(new frm_crud_nhanvien(), sender);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login frm_Login = new frm_login();
            frm_Login.Show();
        }
    }
}
