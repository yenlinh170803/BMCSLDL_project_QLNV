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
    public partial class frm_thongtindean : Form
    {
        public frm_thongtindean()
        {
            InitializeComponent();
            //Console.WriteLine("frm_thongtindean");
        }

        private void btn_loaddata__xtt_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectBLL deAnBLL = new ProjectBLL();

                List<ProjectDTO> deAnList = deAnBLL.GetAllProject();
                dtg_thongtindean.DataSource = deAnList;

                dtg_thongtindean.Columns["MADA"].HeaderText = "Mã DA";
                dtg_thongtindean.Columns["TENDA"].HeaderText = "Tên DA";
                dtg_thongtindean.Columns["NGAYBD"].HeaderText = "Ngày BĐ";
                dtg_thongtindean.Columns["MAPB"].HeaderText = "Mã PB";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_thongtindean_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
