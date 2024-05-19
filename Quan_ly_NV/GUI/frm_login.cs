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
            string username = txt_username.Text.Trim().ToString();
            string password = txt_password.Text.Trim().ToString();
            if(username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO.Username = username;
                employeeDTO.Password = GetMD5Hash(password);
                employeeDTO.RoleId = cb_role.SelectedValue?.ToString();
                string role = _roleBLL.GetRoleFromRoleId(employeeDTO.RoleId);
                int status = _employeeBLL.Login(employeeDTO); //0: failed, 1: success, 2:success but lock account

                if (status == 0)
                {
                    MessageBox.Show("Đăng nhập thất bại do tài khoản đăng nhập không chính xác. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                else if (status == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    switch(role.ToUpper())
                    {
                        case "DBA":
                            frm_admin frm_Admin = new frm_admin();
                            frm_Admin.Show();
                            this.Hide();
                            break;
                        case "TRƯỞNG PHÒNG":
                            frm_truongphong frm_Truongphong = new frm_truongphong();
                            frm_Truongphong.Show();
                            this.Hide();
                            break;
                        case "NHÂN SỰ":
                            frm_nhansu frm_Nhansu = new frm_nhansu();
                            frm_Nhansu.Show();
                            this.Hide();
                            break;
                        case "TÀI CHÍNH":
                            frm_taichinh frm_Taichinh = new frm_taichinh();
                            frm_Taichinh.Show();
                            this.Hide();
                            break;
                        case "TRƯỞNG ĐỀ ÁN":
                            frm_truongdean frm_Truongdean = new frm_truongdean();
                            frm_Truongdean.Show();
                            this.Hide();
                            break;
                        case "NHÂN VIÊN":
                            frm_employee frm_Employee = new frm_employee();
                            frm_Employee.Show();
                            this.Hide();
                            break;
                        default:
                            this.Close();
                            break;
                    }

                }
                else if (status == 2)
                {
                    MessageBox.Show("Đăng nhập thất bại do tài khoản bị khóa. Vui lòng liên hệ admin để mở khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            cb_role.DataSource = _roleBLL.GetAllRole();
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