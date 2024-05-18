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

namespace Quan_ly_NV
{
    public partial class frm_thongtinnhanvien : Form
    {
        private EmployeeBLL _employeeBLL;
        private string _selectedMaNV;
        public frm_thongtinnhanvien()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            dtg_xemthongtin.CellClick += dtg_xemthongtin_CellClick;
        }

        private void btn_loaddata__xtt_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            try
            {
                var employees = _employeeBLL.GetAllEmployees();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã NV");
                dt.Columns.Add("Tên NV");
                dt.Columns.Add("Phái");
                dt.Columns.Add("Ngày sinh");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số ĐT");
                dt.Columns.Add("Lương");
                dt.Columns.Add("Phụ cấp");
                dt.Columns.Add("Vai trò");
                dt.Columns.Add("Mã QL");
                dt.Columns.Add("PHG");
                foreach (var employee in employees)
                {
                    dt.Rows.Add(employee.MaNV, employee.HoTenNV, employee.GioiTinh, employee.NgaySinh,
                        employee.DiaChi, employee.SoDT, employee.Luong, employee.PhuCap, employee.VaiTro,
                        employee.MaNQL, employee.MaPB);
                }
                dtg_xemthongtin.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu:" + ex.Message);
            }
        }
        private void dtg_xemthongtin_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_xemthongtin.Rows[e.RowIndex];
                _selectedMaNV = row.Cells["Mã NV"].Value.ToString();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            /*string maNV =;*/
            if (string.IsNullOrEmpty(_selectedMaNV))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên từ danh sách");
                return;
            }
            DateTime ngaySinh = dtP_ngaysinh.Value;
            string diaChi = txt_diachi.Text;
            string soDT = txt_sdt.Text;
            try
            {
                bool result = _employeeBLL.UpdateEmployeeInfo(_selectedMaNV, ngaySinh, diaChi, soDT);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin nhân viên:" + ex.Message);
            }
        }
    }
}
