using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.BLL
{
    internal class PhongBanBLL
    {
        private static PhongBanDAL _phongBanDAL;

        public PhongBanBLL()
        {
            _phongBanDAL = new PhongBanDAL();
        }

        public List<PhongBanDTO> GetAllDepartments()
        {
            return _phongBanDAL.GetAllDepartments();
        }

        public void CreateNewDepartment(string maPB, string tenPB, string maTrgPhg)
        {
            _phongBanDAL.CreateNewDepartment(maPB, tenPB, maTrgPhg);
        }

        public void UpdateDepartment(string maPB, string tenPB, string maTrgPhg)
        {
            _phongBanDAL.UpdateDepartment(maPB, tenPB, maTrgPhg);
        }


    }
}
