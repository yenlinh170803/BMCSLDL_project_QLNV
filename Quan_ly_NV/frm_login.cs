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
        private string connectionString = "Data Source=.;Initial Catalog=QUANLYNV;Integrated Security=True; MultipleActiveResultSets=True;Trusted_Connection=True;trustServerCertificate=True;";
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string loginStatus = "";
            string username = txt_username.Text.ToString();
            string password = txt_password.Text.ToString();
            byte[] passwordHash = GetMD5Hash(password);
            string role = cb_role.SelectedValue?.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LOGIN_NHANVIEN", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 100).Value = username;
                        cmd.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarBinary, 8000).Value = passwordHash;
                        cmd.Parameters.Add("@ROLE", System.Data.SqlDbType.NVarChar, 100).Value = role;

                        SqlParameter output = new SqlParameter("@LOGINSTATUS", System.Data.SqlDbType.NVarChar, 20);
                        output.Direction = System.Data.ParameterDirection.Output; // Đặt hướng là OUTPUT
                        cmd.Parameters.Add(output);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị của tham số OUTPUT
                        loginStatus = output.Value.ToString();
                    }
                }
                if (loginStatus == "SUCCESS")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    switch(role)
                    {
                        case "DBA":
                            frm_admin admin = new frm_admin();
                            admin.Show();
                            break;
                        default:
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM VAITRO";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "VAITRO");
                        cb_role.DataSource = dataSet.Tables["VAITRO"];
                        cb_role.DisplayMember = "TENVT"; // Thiết lập thành viên hiển thị
                        cb_role.ValueMember = "TENVT";     // Thiết lập thành viên giá trị
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải vai trò: " + ex.Message);
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

    }
}