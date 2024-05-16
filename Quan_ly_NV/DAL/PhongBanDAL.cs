using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DAL
{
    internal class PhongBanDAL
    {
        private static DataHelper _helper;

        public PhongBanDAL()
        {
            _helper = new DataHelper();
        }

        public List<PhongBanDTO> GetAllDepartments()
        {
            // Implement logic to retrieve department data and map to PhongBanDTO objects
            // Example: Execute a query to fetch all departments and populate the list
            DataTable departmentTable = _helper.ExecuteQuery("SELECT * FROM PHONGBAN");

            List<PhongBanDTO> departments = new List<PhongBanDTO>();
            foreach (DataRow row in departmentTable.Rows)
            {
                departments.Add(new PhongBanDTO
                {
                    MaPB = row["MAPB"].ToString(),
                    TenPB = row["TENPB"].ToString(),
                    MaTrgPhg = row["MATRGPHG"].ToString()
                });
            }

            return departments;
        }

        public void CreateNewDepartment(string maPB, string tenPB, string maTrgPhg)
        {
            // Implement logic to insert a new department into the PHONGBAN table
            string query = $"INSERT INTO PHONGBAN (MAPB, TENPB, MATRGPHG) VALUES ('{maPB}', N'{tenPB}', '{maTrgPhg}')";
            _helper.ExecuteNonQuery(query);
        }

        public void UpdateDepartment(string maPB, string tenPB, string maTrgPhg)
        {
            // Implement logic to update the department in the PHONGBAN table
            string query = $"UPDATE PHONGBAN SET TENPB = N'{tenPB}', MATRGPHG = '{maTrgPhg}' WHERE MAPB = '{maPB}'";
            _helper.ExecuteNonQuery(query);
        }




    }
}
