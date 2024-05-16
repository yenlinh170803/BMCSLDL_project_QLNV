using Quan_ly_NV.DAL;
using Quan_ly_NV.DTO;
using System.Collections.Generic;

namespace Quan_ly_NV.BLL
{
    internal class ProjectBLL
    {
        private static ProjectDAL _projectDAL;

        public ProjectBLL()
        {
            _projectDAL = new ProjectDAL();
        }

        public List<ProjectDTO> GetAllProject()
        {
            return _projectDAL.GetAllProject();
        }

        public void CreateNewProject(string maDA, string tenDA, string ngayBD, string maPB)
        {
            _projectDAL.CreateNewProject(maDA, tenDA, ngayBD, maPB);
        }

        public void UpdateProject(string maDA, string tenDA, string ngayBD, string maPB)
        {
            _projectDAL.UpdateProject(maDA, tenDA, ngayBD, maPB);
        }
    }
}
