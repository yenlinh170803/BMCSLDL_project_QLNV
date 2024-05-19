using Quan_ly_NV.BLL;
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
    public partial class frm_quyen : Form
    {
        RoleBLL _roleBLL;
        public frm_quyen()
        {
            InitializeComponent();
            _roleBLL = new RoleBLL();
        }

        private void frm_quyen_Load(object sender, EventArgs e)
        {
            DataTable permissionTable = new DataTable();
            permissionTable = _roleBLL.GetAllPermission();
            for(int i = 0; i < permissionTable.Rows.Count; i++)
            {
                pnl_quyen.Rows.Add(permissionTable.Rows[i]["Grantee"], permissionTable.Rows[i]["Object name"], permissionTable.Rows[i]["Column"], permissionTable.Rows[i]["Grantable"], permissionTable.Rows[i]["Type"]);
            }
            
        }
    }
}
