using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DAL
{
    internal class AssignTaskDAL
    {
        private static DataHelper _helper;

        public AssignTaskDAL()
        {
            _helper = new DataHelper();
        }

        public List<AssignTaskDTO> GetAllAssignTask()
        {
            DataTable assigntaskTable = _helper.ExecuteQuery("SELECT * FROM PHANCONG");

            List<AssignTaskDTO> assigntask = new List<AssignTaskDTO>();
            foreach (DataRow row in assigntaskTable.Rows)
            {
                assigntask.Add(new AssignTaskDTO
                {
                    MaDA = row["MADA"].ToString(),
                    MaNV = row["MANV"].ToString(),
                    ThoiGian = row["THOIGIAN"].ToString(),
                  
                });
            }

            return assigntask;
        }

        public void CreateNewAssignTask(string maDA, string maNV, string thoigian)
        {
            string query = $"INSERT INTO PHANCONG (MADA, TENDA, NGAYBD, MAPB) VALUES ('{maDA}', N'{maNV}', '{thoigian}')";
            _helper.ExecuteNonQuery(query);
        }

        public void UpdateAssignTask(string maDA, string maNV, string thoigian)
        {
            string query = $"UPDATE DEAN SET PHANCONG = N'{maDA}', NGAYBD = '{maNV}' WHERE MADA = '{thoigian}'";
            _helper.ExecuteNonQuery(query);
        }
    }
}
