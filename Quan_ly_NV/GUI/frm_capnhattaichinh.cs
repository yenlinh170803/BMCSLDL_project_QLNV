using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Quan_ly_NV.BLL;
using Quan_ly_NV.DTO;

namespace Quan_ly_NV
{
    public partial class frm_capnhattaichinh : Form
    {
        private EmployeeBLL _employeeBLL;
        public frm_capnhattaichinh()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void frm_capnhattaichinh_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
        private void LoadEmployeeList()
        {
            try
            {
                var employees = _employeeBLL.GetAllEmployees();
                cboMaNV.DisplayMember = "MaNV";
                cboMaNV.ValueMember = "MaNV";
                cboMaNV.DataSource = employees;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải danh sách nhân viên:" + ex.Message);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string selectedMaNV = cboMaNV.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedMaNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!");
                return;
            }
            double luong = 0;
            double phuCap = 0;
            if(!double.TryParse(txtLuong.Text, out luong) || !double.TryParse(txtPhucap.Text, out phuCap))
            {
                MessageBox.Show("Vui lòng nhập lương và phụ cấp hợp lệ!");
                return;
            }
            try
            {
                NhanVienDTO updatedEmployee = new NhanVienDTO
                {
                    MaNV = selectedMaNV,
                    Luong = luong,
                    PhuCap = phuCap
                };
                bool result = _employeeBLL.UpdateEmployeeFinancialInfo(updatedEmployee);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin tài chính cho nhân viên thành công!");
                    LoadEmployeeList();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin tài chính cho nhân viên thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin tài chính cho nhân viên:" + ex.Message);
            }
        }
    }
}
