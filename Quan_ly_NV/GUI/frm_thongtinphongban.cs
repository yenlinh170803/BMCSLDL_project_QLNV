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
    public partial class frm_thongtinphongban : Form
    {
        public frm_thongtinphongban()
        {
            InitializeComponent();
        }

        private void btn_loaddata__xtt_Click(object sender, EventArgs e)
        {
            DepartmentBLL phongBanBLL = new DepartmentBLL();

            List<DepartmentDTO> departments = phongBanBLL.GetAllDepartments();
            dtg_thongtinphongban.DataSource = departments;
            dtg_thongtinphongban.Columns["clb_mapb"].HeaderText = "Mã PB";
            dtg_thongtinphongban.Columns["clb_tenpb"].HeaderText = "Tên PB";
            dtg_thongtinphongban.Columns["clb_trgphg"].HeaderText = "TrPHG";
        }

        private void dtg_thongtinphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
