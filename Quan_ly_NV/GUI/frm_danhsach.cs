using Quan_ly_NV.BLL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class frm_danhsach : Form
    {
        private static EmployeeBLL _employeeBLL;
        public frm_danhsach()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void frm_danhsach_Load(object sender, EventArgs e)
        {
            EmployeeDTO[] employees = new EmployeeDTO[_employeeBLL.GetAllEmployee().Count()];
            employees = _employeeBLL.GetAllEmployee();
            foreach(var employee in employees)
            {
                dtg_danhsach.Rows.Add(employee.EmployeeId, employee.Username, employee.DateCreated);
            }
        }
    }
}
