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
    internal class RoleBLL
    {
        private static RoleDAL _roleDAL;
        public RoleBLL()
        {
            _roleDAL = new RoleDAL();
        }
        public RoleDTO[] GetAllRole()
        {
            return _roleDAL.GetAllRole();
        }
        public string GetRoleFromRoleId(string roleId)
        {
            return _roleDAL.GetRoleFromRoleId(roleId);
        }
        public void InsertRole(RoleDTO roleDTO)
        {
            bool result = _roleDAL.CreateRole(roleDTO);
            if(result)
            {
                MessageBox.Show("Thêm vai trò thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Thêm vai trò thất bại do đã có vai trò này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public DataTable GetAllPermission()
        {
            return _roleDAL.GetAllPermission();
        }
    }
}
