using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.BLL
{
    internal class RoleBLL
    {
        private static RoleDAL _roleDAL;
        public RoleBLL()
        {
            _roleDAL = new RoleDAL();
        }
        public RoleDTO[] LoadRoleCbx()
        {
            return _roleDAL.GetAllRole();
        }
        public string GetRoleFromRoleId(string roleId)
        {
            return _roleDAL.GetRoleFromRoleId(roleId);
        }
    }
}
