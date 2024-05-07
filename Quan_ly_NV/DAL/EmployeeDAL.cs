using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DAL
{
    internal class EmployeeDAL
    {
        private static DataHelper _helper;
        public EmployeeDAL()
        {
            _helper = new DataHelper();
        }
        public bool VerifyLogin(string username, byte[] password, string roleId)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@USERNAME", System.Data.SqlDbType.VarChar, 100);
            parameters[0].Value = username;
            parameters[1] = new SqlParameter("@PASSWORD", System.Data.SqlDbType.VarBinary, 8000);
            parameters[1].Value = password;
            parameters[2] = new SqlParameter("@ROLEID", System.Data.SqlDbType.VarChar, 20);
            parameters[2].Value = roleId;
            parameters[3] = new SqlParameter("@LOGINSTATUS", System.Data.SqlDbType.Int);
            parameters[3].Direction = System.Data.ParameterDirection.Output;
            _helper.ExecuteStoreProcedure("SP_LOGIN_NHANVIEN", parameters);
            if ((int)parameters[3].Value == 0 || (int)parameters[3].Value == 2)
            {
                return false;
            }
            return true;
        } 
    }
}
