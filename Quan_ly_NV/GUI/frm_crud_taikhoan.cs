using Quan_ly_NV.BLL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class frm_crud_taikhoan : Form
    {
        private static RoleBLL _roleBLL;
        private static EmployeeBLL _employeeBLL;
        public frm_crud_taikhoan()
        {
            InitializeComponent();
            _roleBLL = new RoleBLL();
            _employeeBLL = new EmployeeBLL();
        }

        private void frm_crud_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = comboBox2.DataSource = _employeeBLL.GetAllEmployee();
            comboBox1.ValueMember = comboBox1.DisplayMember = comboBox2.ValueMember = comboBox2.DisplayMember = "EmployeeId";
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO = _employeeBLL.GetEmployeeFromEmployeeId(comboBox2.SelectedValue?.ToString());
            if(employeeDTO.StatusId == "TT01")
            {
                rb_unlock.Checked = true;
            }
            else
            {
                rb_lock.Checked = true;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string employeeId = comboBox1.SelectedValue?.ToString();
            _employeeBLL.DeleteEmployee(employeeId);
            comboBox1.Update();
        }

        private void btn_createrole_Click(object sender, EventArgs e)
        {
            string roleName = textBox3.Text.Trim().ToUpper();
            if(roleName == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập vai trò cần thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                RoleDTO roleDTO = new RoleDTO();
                roleDTO.RoleName = roleName;
                _roleBLL.InsertRole(roleDTO);
            }            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();
            if(username == string.Empty || password == string.Empty) 
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO.Username = username;
                employeeDTO.Password = GetMD5Hash(password);
                employeeDTO.StatusId = "TT01";
                employeeDTO.RoleId = "VT06";
                _employeeBLL.CreateAccountEmployee(employeeDTO);
            }
        }
        private byte[] GetMD5Hash(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return hashBytes;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.EmployeeId = comboBox2.SelectedValue?.ToString();
            if(rb_lock.Checked)
            {
                employeeDTO.StatusId = "TT02";
            }
            else
            {
                employeeDTO.StatusId = "TT01";
            }
            _employeeBLL.SetStatus(employeeDTO);
        }

        private void btn_changepw_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO.Username = username;
                employeeDTO.Password = GetMD5Hash(password);
                _employeeBLL.UpdatePassword(employeeDTO);
            }
        }
    }
}
