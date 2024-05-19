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
    public partial class frm_phanquyen : Form
    {
        EmployeeBLL _employeeBLL;
        RoleBLL _roleBLL;
        public frm_phanquyen()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _roleBLL = new RoleBLL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string roleId = comboBox12.SelectedValue?.ToString();
            string employeeId = comboBox13.SelectedValue?.ToString();
            bool grantOption = false;
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.EmployeeId = employeeId;
            employeeDTO.RoleId = roleId;
            _employeeBLL.AssignRoleToEmployee(employeeDTO, grantOption);
        }

        private void frm_phanquyen_Load(object sender, EventArgs e)
        {
            comboBox13.DataSource  = _employeeBLL.GetAllEmployee();
            comboBox13.ValueMember = "EmployeeId";
            comboBox13.DisplayMember = "EmployeeId";
            comboBox12.DataSource =comboBox11.DataSource = comboBox5.DataSource = _roleBLL.GetAllRole();
            comboBox12.ValueMember = comboBox11.ValueMember = comboBox5.ValueMember = "RoleId";
            comboBox12.DisplayMember = comboBox11.DisplayMember = comboBox5.DisplayMember = "RoleName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string permission = comboBox10.SelectedItem?.ToString();
            string obj = comboBox9.SelectedItem?.ToString();
            string roleId = comboBox11.SelectedValue?.ToString();
            bool grantOption = false;
            if(checkBox2.Checked)
            {
                grantOption = true;
            }
            _employeeBLL.AssignPermissionToRole(roleId, permission, obj, grantOption);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_chinhsua_2_Click(object sender, EventArgs e)
        {
            string permission = comboBox4.SelectedItem?.ToString();
            string obj = comboBox6.SelectedItem?.ToString();
            string roleId = comboBox5.SelectedValue?.ToString();
            _employeeBLL.RevokePermissionToRole(roleId, permission, obj);
        }
    }
}
