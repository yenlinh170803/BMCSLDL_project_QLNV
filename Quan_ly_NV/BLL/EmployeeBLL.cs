using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV.BLL
{
    internal class EmployeeBLL
    {
        private static EmployeeDAL _employeeDAL;
        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }
        public int Login(EmployeeDTO employeeDTO)
        {
            return _employeeDAL.Login(employeeDTO);
        }
        public EmployeeDTO[] GetAllEmployee()
        {
             return _employeeDAL.GetAllEmployee();
        }
        public void SetStatus(EmployeeDTO employeeDTO)
        {
            bool result = _employeeDAL.SetStatusEmployee(employeeDTO);
            if(result)
            {
                MessageBox.Show("Bạn đã sửa trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Bạn đã sửa trạng thái thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public EmployeeDTO GetEmployeeFromEmployeeId(string employeeId)
        {
            return _employeeDAL.GetEmployeeFromEmployeeId(employeeId);
        }
        public EmployeeDTO[] GetAllDepartmentLead()
        {
            return _employeeDAL.GetAllDepartmentLead();
        }
        public void CreateAccountEmployee(EmployeeDTO employeeDTO)
        {
            DataTable account = new DataTable();
            account = _employeeDAL.GetEmployeeFromEmployeeUsername(employeeDTO.Username);
            if(account == null)
            {
                int n = GetAllEmployee().Length;
                if(n < 10)
                {
                    employeeDTO.EmployeeId = "NV0" + (n + 1).ToString();
                }
                else
                {
                    employeeDTO.EmployeeId = "NV" + (n+1).ToString();
                }
                _employeeDAL.CreateAccountEmployee(employeeDTO);
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại do tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
        }
        public void DeleteEmployee(string employeeId)
        {
            bool result = _employeeDAL.DeleteEmployeeFromEmployeeId(employeeId);
            if(result)
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại do không có tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public List<NhanVienDTO> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }
        public bool UpdateEmployeeInfo(string maNV, DateTime ngaySinh, string diaChi, string soDT)
        {
            // Gọi phương thức từ EmployeeDAL để thực hiện cập nhật thông tin nhân viên
            return _employeeDAL.UpdateEmployeeInfo(maNV, ngaySinh, diaChi, soDT);
        }
        public bool AddEmployee(NhanVienDTO newEmployee)
        {
            // Gọi phương thức từ EmployeeDAL để thực hiện thêm nhân viên mới
            return _employeeDAL.AddEmployee(newEmployee);
        }

        public bool UpdateEmployee(NhanVienDTO updatedEmployee)
        {
            // Gọi phương thức từ EmployeeDAL để thực hiện cập nhật thông tin nhân viên
            return _employeeDAL.UpdateEmployee(updatedEmployee);
        }

        public bool UpdateEmployeeFinancialInfo(NhanVienDTO updatedEmployee)
        {
            return _employeeDAL.UpdateEmployeeFinancialInfo(updatedEmployee);
        }
        public void AssignRoleToEmployee(EmployeeDTO employeeDTO, bool grantOption)
        {
            bool result = _employeeDAL.AssignRoleToEmployee(employeeDTO, grantOption);
            if (result)
            {
                MessageBox.Show("Cấp role cho nhân viên này thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Cấp role cho nhân viên này thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public void AssignPermissionToRole(string roleId, string permission, string obj, bool grantOption)
        {
            bool result = _employeeDAL.AssignPermissionToRole(roleId, permission, obj, grantOption);
            if (result)
            {
                MessageBox.Show("Cấp quyền truy cập cho role này thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Cấp quyền truy cập cho role này thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public void RevokePermissionToRole(string roleId, string permission, string obj)
        {
            bool result = _employeeDAL.RevokePermissionToRole(roleId, permission, obj);
            if (result)
            {
                MessageBox.Show("Tước quyền truy cập cho role này thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Tước quyền truy cập cho role này thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public void UpdatePassword(EmployeeDTO employeeDTO)
        {
            DataTable account = new DataTable();
            account = _employeeDAL.GetEmployeeFromEmployeeUsername(employeeDTO.Username);
            if (account != null)
            {
                _employeeDAL.UpdatePassword(employeeDTO);
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại do tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
        }
    }
}
