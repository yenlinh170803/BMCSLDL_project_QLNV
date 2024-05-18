using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Quan_ly_NV.DAL
{
    internal class ProjectDAL
    {
        private static DataHelper _helper;

        public ProjectDAL()
        {
            _helper = new DataHelper();
        }

        public List<ProjectDTO> GetAllProject()
        {
            DataTable projectTable = _helper.ExecuteQuery("SELECT * FROM DEAN");

            List<ProjectDTO> projects = new List<ProjectDTO>();
            foreach (DataRow row in projectTable.Rows)
            {
                projects.Add(new ProjectDTO
                {
                    MaDA = row["MADA"].ToString(),
                    TenDA = row["TENDA"].ToString(),
                    NgayBD = row["NGAYBD"].ToString(),
                    MaPB = row["MAPB"].ToString()
                });
            }

            return projects;
        }

        public void CreateNewProject(string maDA, string tenDA, string ngayBD, string maPB)
        {
            string query = $"INSERT INTO DEAN (MADA, TENDA, NGAYBD, MAPB) VALUES ('{maDA}', N'{tenDA}', '{ngayBD}', '{maPB}')";
            _helper.ExecuteNonQuery(query);
        }

        public void UpdateProject(string maDA, string tenDA, string ngayBD, string maPB)
        {
            string query = $"UPDATE DEAN SET TENDA = N'{tenDA}', NGAYBD = '{ngayBD}', MAPB = '{maPB}' WHERE MADA = '{maDA}'";
            _helper.ExecuteNonQuery(query);
        }
    }
}
