using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DAL
{
    internal class RoleDAL
    {
        private static DataHelper _helper;
        public RoleDAL()
        {
            _helper = new DataHelper();
        }
        public RoleDTO GetRoleFromDataRow(DataRow row)
        {
            RoleDTO roleDTO = new RoleDTO();
            roleDTO.RoleId = row["MAVT"].ToString();
            roleDTO.RoleName = row["TENVT"].ToString();
            return roleDTO;
        }
        public string GetRoleFromRoleId(string roleId)
        {
            DataTable dataTable = new DataTable();
            string query = string.Format("SELECT TENVT FROM VAITRO WHERE MAVT='{0}'", roleId);
            dataTable = _helper.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["TENVT"].ToString();
            }
            return null;
        }
        public RoleDTO[] GetAllRole()
        {
            int n = 0;
            DataTable dataTable = new DataTable();
            dataTable = _helper.ExecuteQuery("SELECT * FROM VAITRO");
            n = dataTable.Rows.Count;
            RoleDTO[] roleDTOs = new RoleDTO[n];
            if (n == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    roleDTOs[i] = new RoleDTO();
                    roleDTOs[i] = GetRoleFromDataRow(dataTable.Rows[i]);
                }
            }
            return roleDTOs;
        }
    }
}
