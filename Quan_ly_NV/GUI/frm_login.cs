using Quan_ly_NV.BLL;
using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quan_ly_NV
{
    public partial class frm_login : Form
    {
        private static EmployeeBLL _employeeBLL;
        private static RoleBLL _roleBLL;
        public frm_login()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _roleBLL = new RoleBLL();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.ToString();
            string password = txt_password.Text.ToString();
            byte[] passwordHash = GetMD5Hash(password);
            string roleid = cb_role.SelectedValue?.ToString();
            string role = _roleBLL.GetRoleFromRoleId(roleid);            
            if (_employeeBLL.Login(username, passwordHash, roleid))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                switch (role)
                {
                    case "DBA":                        
                        frm_admin admin = new frm_admin();
                        admin.Show();
                        break;
                    default:
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công do tài khoản bị khóa hoặc sai thông tin đăng nhập. Vui lòng kiểm tra lại!");
                txt_password.Focus();
            }
            }

            private void frm_login_Load(object sender, EventArgs e)
            {
            cb_role.DataSource = _roleBLL.LoadRoleCbx();
            cb_role.DisplayMember = "RoleName";
            cb_role.ValueMember = "RoleId";
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

        }
    }