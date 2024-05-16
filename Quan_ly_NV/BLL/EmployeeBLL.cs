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
    }
}
