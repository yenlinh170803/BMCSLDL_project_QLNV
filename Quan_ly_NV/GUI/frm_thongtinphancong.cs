using Quan_ly_NV.BLL;
using Quan_ly_NV.DTO;
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
    public partial class frm_thongtinphancong : Form
    {
        public frm_thongtinphancong()
        {
            InitializeComponent();
        }

        private void btn_loaddata__xtt_Click(object sender, EventArgs e)
        {
            try
            {
                AssignTaskBLL phancongBLL = new AssignTaskBLL();

                List<AssignTaskDTO> phancongList = phancongBLL.GetAllAssignTask();
                dtg_thongtinphancong.DataSource = phancongList;

                dtg_thongtinphancong.Columns["MADA"].HeaderText = "Mã DA";
                dtg_thongtinphancong.Columns["MANV"].HeaderText = "Mã NV";
                dtg_thongtinphancong.Columns["THOIGIAN"].HeaderText = "Thời Gian";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_thongtinphancong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
