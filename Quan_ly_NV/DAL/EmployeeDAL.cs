using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV.DAL
{
    internal class EmployeeDAL
    {
        private static DataHelper _helper;
        public EmployeeDAL()
        {
            _helper = new DataHelper();
        }
        public bool VerifyLogin(string username, byte[] password, string roleId)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@USERNAME", System.Data.SqlDbType.VarChar, 100);
            parameters[0].Value = username;
            parameters[1] = new SqlParameter("@PASSWORD", System.Data.SqlDbType.VarBinary, 8000);
            parameters[1].Value = password;
            parameters[2] = new SqlParameter("@ROLEID", System.Data.SqlDbType.VarChar, 20);
            parameters[2].Value = roleId;
            parameters[3] = new SqlParameter("@LOGINSTATUS", System.Data.SqlDbType.Int);
            parameters[3].Direction = System.Data.ParameterDirection.Output;
            _helper.ExecuteStoreProcedure("SP_LOGIN_NHANVIEN", parameters);
            if ((int)parameters[3].Value == 0 || (int)parameters[3].Value == 2)
            {
                return false;
            }
            return true;
        }
        public List<NhanVienDTO> GetAllDepartmentLeads()
        {
            string query = @"SELECT MANV, TENNV
                             FROM NHANVIEN
                             WHERE MAVT = 'VT02'";

            DataTable table = _helper.ExecuteQuery(query);
            List<NhanVienDTO> departmentLeads = new List<NhanVienDTO>();

            foreach (DataRow row in table.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = row["MANV"].ToString(),
                    HoTenNV = row["TENNV"].ToString()
                };

                departmentLeads.Add(nv);
            }

            return departmentLeads;
        }

        public List<NhanVienDTO> GetAllEmployees()
        {
            string query = @"SELECT NV.MANV, NV.TENNV, GT.TENGT AS GIOITINH, NV.NGAYSINH, NV.DIACHI, NV.SODT, NV.LUONG, NV.PHUCAP, VT.TENVT AS VAITRO, NV.MANQL, NV.MAPB
                     FROM NHANVIEN NV
                     INNER JOIN GIOITINH GT ON NV.MAGT = GT.MAGT
                     INNER JOIN VAITRO VT ON NV.MAVT = VT.MAVT
                     WHERE NV.MAVT = 'VT01'";
            DataTable table = _helper.ExecuteQuery(query);
            List<NhanVienDTO> employees = new List<NhanVienDTO>();
            foreach (DataRow row in table.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = row["MANV"].ToString(),
                    HoTenNV = row["TENNV"].ToString(),
                    // Gán giá trị cho các trường mới
                    GioiTinh = row["GIOITINH"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["NGAYSINH"]),
                    DiaChi = row["DIACHI"].ToString(),
                    SoDT = row["SODT"].ToString(),
                    Luong = Convert.ToDouble(row["LUONG"]),
                    PhuCap = Convert.ToDouble(row["PHUCAP"]),
                    VaiTro = row["VAITRO"].ToString(),
                    MaNQL = row["MANQL"].ToString(),
                    MaPB = row["MAPB"].ToString()
                };
                employees.Add(nv);
            }
            return employees;
        }
        public bool UpdateEmployeeInfo(string maNV, DateTime ngaySinh, string diaChi, string soDT)
        {
            try
            {
                // Tạo câu truy vấn SQL để cập nhật thông tin nhân viên trong cơ sở dữ liệu
                string query = "UPDATE NHANVIEN SET NGAYSINH = @NgaySinh, DIACHI = @DiaChi, SODT = @SoDT WHERE MANV = @MaNV";

                // Khởi tạo và truyền các tham số cho câu truy vấn
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 20);
                parameters[0].Value = maNV;
                parameters[1] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
                parameters[1].Value = ngaySinh;
                parameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
                parameters[2].Value = diaChi;
                parameters[3] = new SqlParameter("@SoDT", SqlDbType.NVarChar, 50);
                parameters[3].Value = soDT;

                // Thực thi câu truy vấn cập nhật
                _helper.ExecuteNonQuery(query, parameters);

                return true; // Trả về true nếu cập nhật thành công
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin nhân viên: " + ex.Message);
                return false; // Trả về false nếu cập nhật thất bại
            }
        }

        public bool AddEmployee(NhanVienDTO newEmployee)
        {
            try
            {
                string query = @"INSERT INTO NHANVIEN (MANV, TENNV, NGAYSINH, DIACHI, SODT, MAGT, MAVT, MAPB, MANQL)
                         VALUES (@MaNV, @HoTenNV, @NgaySinh, @DiaChi, @SoDT, @GioiTinh, @VaiTro, @MaPB, @MaNQL)";

                SqlParameter[] parameters = new SqlParameter[9];
                parameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 20);
                parameters[0].Value = newEmployee.MaNV;
                parameters[1] = new SqlParameter("@HoTenNV", SqlDbType.NVarChar, 100);
                parameters[1].Value = newEmployee.HoTenNV;
                parameters[2] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
                parameters[2].Value = newEmployee.NgaySinh;
                parameters[3] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
                parameters[3].Value = newEmployee.DiaChi;
                parameters[4] = new SqlParameter("@SoDT", SqlDbType.NVarChar, 50);
                parameters[4].Value = newEmployee.SoDT;
                parameters[5] = new SqlParameter("@GioiTinh", SqlDbType.VarChar, 20);
                parameters[5].Value = newEmployee.GioiTinh;
                parameters[6] = new SqlParameter("@VaiTro", SqlDbType.VarChar, 20);
                parameters[6].Value = newEmployee.VaiTro;
                parameters[7] = new SqlParameter("@MaPB", SqlDbType.VarChar, 20);
                parameters[7].Value = newEmployee.MaPB;
                parameters[8] = new SqlParameter("@MaNQL", SqlDbType.VarChar, 20);
                parameters[8].Value = newEmployee.MaNQL;
                _helper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên: " + ex.Message);
                return false;
            }
        }
        public bool UpdateEmployee(NhanVienDTO updatedEmployee)
        {
            try
            {
                string query = @"UPDATE NHANVIEN 
                         SET TENNV = @HoTenNV, NGAYSINH = @NgaySinh, DIACHI = @DiaChi, 
                             SODT = @SoDT, MAGT = @GioiTinh, 
                             MAVT = @VaiTro, MAPB = @MaPB, MANQL = @MaNQL,
                         WHERE MANV = @MaNV";

                SqlParameter[] parameters = new SqlParameter[9];
                parameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 20);
                parameters[0].Value = updatedEmployee.MaNV;
                parameters[1] = new SqlParameter("@HoTenNV", SqlDbType.NVarChar, 100);
                parameters[1].Value = updatedEmployee.HoTenNV;
                parameters[2] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
                parameters[2].Value = updatedEmployee.NgaySinh;
                parameters[3] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
                parameters[3].Value = updatedEmployee.DiaChi;
                parameters[4] = new SqlParameter("@SoDT", SqlDbType.NVarChar, 50);
                parameters[4].Value = updatedEmployee.SoDT;
                parameters[5] = new SqlParameter("@GioiTinh", SqlDbType.VarChar, 20);
                parameters[5].Value = updatedEmployee.GioiTinh;
                parameters[6] = new SqlParameter("@VaiTro", SqlDbType.VarChar, 20);
                parameters[6].Value = updatedEmployee.VaiTro;
                parameters[7] = new SqlParameter("@MaPB", SqlDbType.VarChar, 20);
                parameters[7].Value = updatedEmployee.MaPB;
                parameters[8] = new SqlParameter("@MaNQL", SqlDbType.VarChar, 20);
                parameters[8].Value = updatedEmployee.MaNQL;
                _helper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin nhân viên: " + ex.Message);
                return false;
            }
        }

        public bool UpdateEmployeeFinancialInfo(NhanVienDTO updatedEmployee)
        {
            try
            {
                string query = "UPDATE NHANVIEN SET LUONG = @Luong, PHUCAP = @PhuCap WHERE MANV = @MaNV";

                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 20);
                parameters[0].Value = updatedEmployee.MaNV;
                parameters[1] = new SqlParameter("@Luong", SqlDbType.Float);
                parameters[1].Value = updatedEmployee.Luong;
                parameters[2] = new SqlParameter("@PhuCap", SqlDbType.Float);
                parameters[2].Value = updatedEmployee.PhuCap;

                _helper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật tài chính nhân viên: " + ex.Message);
                return false;
            }
        }
    }
}
