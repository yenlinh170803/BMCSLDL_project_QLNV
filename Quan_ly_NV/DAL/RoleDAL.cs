using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool CreateRole(RoleDTO roleDTO)
        {
            string query_1 = string.Format("SELECT * FROM VAITRO WHERE TENVT=N'{0}'", roleDTO.RoleName);
            DataTable role = new DataTable();
            role = _helper.ExecuteQuery(query_1);
            if (role.Rows.Count == 0)
            {
                int n = _helper.ExecuteQuery("SELECT * FROM VAITRO").Rows.Count;
                if (n < 10)
                {
                    roleDTO.RoleId = "VT0" + (n+1).ToString();
                }
                else
                {
                    roleDTO.RoleId = "VT" + (n+1).ToString();
                }
                string query_2 = string.Format("INSERT VAITRO(MAVT, TENVT) VALUES ('{0}', N'{1}')", roleDTO.RoleId, roleDTO.RoleName);
                try
                {
                    _helper.ExecuteNonQuery(query_2);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        public DataTable GetAllPermission()
        {
            string query = "SELECT USER_NAME(dp.grantee_principal_id) AS [Grantee], " +
                "CASE WHEN dp.class = 0 THEN DB_NAME() ELSE o.name END AS [Object name], " +
                "CASE WHEN dp.minor_id = 0 THEN NULL ELSE COL_NAME(dp.major_id, dp.minor_id) END AS [Column], " +
                "CASE WHEN dp.state_desc = 'GRANT_WITH_GRANT_OPTION' THEN 'YES' ELSE 'NO' END AS [Grantable], " +
                "dp.permission_name AS [Type] " +
                "FROM sys.database_permissions dp " +
                "LEFT JOIN sys.objects o ON dp.major_id = o.object_id AND dp.class = 1 " +
                "WHERE USER_NAME(dp.grantee_principal_id) NOT LIKE 'NV%' AND USER_NAME(dp.grantee_principal_id) <> 'public'";
            DataTable permisionTable = new DataTable();
            permisionTable = _helper.ExecuteQuery(query);
            return permisionTable;
        }
    }
}
