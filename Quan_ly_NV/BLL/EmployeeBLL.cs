using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.BLL
{
    internal class EmployeeBLL
    {
        private static EmployeeDAL _employeeDAL;
        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }
        public bool Login(string username, byte[] password, string roleid)
        {
            return _employeeDAL.VerifyLogin(username, password, roleid);
        }
        public List<NhanVienDTO> GetAllDepartmentLeads()
        {
            return _employeeDAL.GetAllDepartmentLeads();
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
    }
}
