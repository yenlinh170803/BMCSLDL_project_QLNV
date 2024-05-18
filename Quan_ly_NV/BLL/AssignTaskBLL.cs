using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.BLL
{
    internal class AssignTaskBLL
    {
        private static AssignTaskDAL _assigntaskDAL;

        public AssignTaskBLL()
        {
            _assigntaskDAL = new AssignTaskDAL();
        }

        public List<AssignTaskDTO> GetAllAssignTask()
        {
            return _assigntaskDAL.GetAllAssignTask();
        }

        public void CreateNewAssignTask(string maDA, string maNV, string thoigian)
        {
            _assigntaskDAL.CreateNewAssignTask(maDA, maNV, thoigian );
        }

        public void UpdateAssignTask(string maDA, string maNV, string thoigian)
        {
            _assigntaskDAL.UpdateAssignTask(maDA, maNV, thoigian);
        }
    }
}
