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
    public partial class frm_crud_nhanvien : Form
    {
        private EmployeeBLL _employeeBLL;

        public frm_crud_nhanvien()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maNV = txt_themmanv.Text;
            string tenNV = txt_themtennv.Text;
            string gioiTinh = cb_themphai.SelectedItem.ToString();
            DateTime ngaySinh = dtP_themngaysinh.Value;
            string diaChi = txt_themdiachi.Text;
            string soDT = txt_themsdt.Text;
            string vaiTro = cb_themvaitro.SelectedItem.ToString();
            string maNQL = cb_themnguoiql.SelectedItem.ToString();
            string maPB = cb_themphong.SelectedItem.ToString();
            try
            {
                NhanVienDTO newEmployee = new NhanVienDTO
                {
                    MaNV = maNV,
                    HoTenNV = tenNV,
                    GioiTinh = gioiTinh,
                    NgaySinh = ngaySinh,
                    DiaChi = diaChi,
                    SoDT = soDT,
                    VaiTro = vaiTro,
                    MaNQL = maNQL,
                    MaPB = maPB
                };
                bool result = _employeeBLL.AddEmployee(newEmployee);
                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên:" + ex.Message);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string maNV = txt_capnhatmanv.Text;
            string tenNV = txt_capnhattennv.Text;
            string gioiTinh = cb_capnhatphai.SelectedItem.ToString();
            DateTime ngaySinh = dtP_capnhatngaysinh.Value;
            string diaChi = txt_capnhatdiachi.Text;
            string soDT = txt_capnhatsdt.Text;
            string vaiTro = cb_capnhatvaitro.SelectedItem.ToString();
            string maNQL = cb_capnhatnguoiql.SelectedItem.ToString();
            string maPB = cb_capnhatphong.SelectedItem.ToString();
            try
            {
                NhanVienDTO updatedEmployee = new NhanVienDTO
                {
                    MaNV = maNV,
                    HoTenNV = tenNV,
                    GioiTinh = gioiTinh,
                    NgaySinh = ngaySinh,
                    DiaChi = diaChi,
                    SoDT = soDT,
                    VaiTro = vaiTro,
                    MaNQL = maNQL,
                    MaPB = maPB
                };
                bool result = _employeeBLL.UpdateEmployee(updatedEmployee);
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
