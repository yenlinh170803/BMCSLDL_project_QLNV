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
    public partial class frm_crud_phongban : Form
    {
        private EmployeeBLL _employeeBLL;
        private DepartmentBLL _phongBanBLL;
        public frm_crud_phongban()
        {
            _employeeBLL = new EmployeeBLL();
            _phongBanBLL = new DepartmentBLL();
            InitializeComponent();
            InitializeComboBoxTruongPhong();
            InitializeComboBoxMaPhongBan();
        }
        private void InitializeComboBoxTruongPhong()
        {
            // Get the list of department leads (VT02) from the BLL
            EmployeeDTO[] departmentLeads = _employeeBLL.GetAllDepartmentLead();

            // Populate the ComboBox with MaNV values
            cmb_truongphong.DataSource = departmentLeads;
            cmb_truongphong.DisplayMember = "MaNV"; // Display MaNV in the ComboBox
            cmb_truongphong.ValueMember = "MaNV"; // Use MaNV as the value

            cmb_update_truongphong.DataSource = departmentLeads;
            cmb_update_truongphong.DisplayMember = "MaNV"; // Display MaNV in the ComboBox
            cmb_update_truongphong.ValueMember = "MaNV";
        }

        private void InitializeComboBoxMaPhongBan()
        {
            // Get the list of MaPB from PhongBanDTO using the BLL
            List<DepartmentDTO> departments = _phongBanBLL.GetAllDepartments();

            // Populate the ComboBox with MaPB values
            cb_maphongban.DataSource = departments;
            cb_maphongban.DisplayMember = "MaPB"; // Display MaPB in the ComboBox
            cb_maphongban.ValueMember = "MaPB"; // Use MaPB as the value
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maPB = txt_addMaPB.Text;
            string tenPB = txt_addTenPB.Text;
            string maTrgPhg = cmb_truongphong.SelectedValue.ToString();
            _phongBanBLL.CreateNewDepartment(maPB, tenPB, maTrgPhg);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string maPBToUpdate = cb_maphongban.SelectedValue.ToString();
            string updatedTenPB = txt_update_tenPB.Text;
            string updatedMaTrgPhg = cmb_update_truongphong.SelectedValue.ToString();

            // Call the UpdateDepartment function from PhongBanBLL
            _phongBanBLL.UpdateDepartment(maPBToUpdate, updatedTenPB, updatedMaTrgPhg);
        }
    }
}
