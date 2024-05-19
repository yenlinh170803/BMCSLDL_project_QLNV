using Quan_ly_NV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        public int Login(EmployeeDTO employeeDTO)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@USERNAME", System.Data.SqlDbType.VarChar, 100);
            parameters[0].Value = employeeDTO.Username;
            parameters[1] = new SqlParameter("@PASSWORD", System.Data.SqlDbType.VarBinary, 8000);
            parameters[1].Value = employeeDTO.Password;
            parameters[2] = new SqlParameter("@ROLEID", System.Data.SqlDbType.VarChar, 20);
            parameters[2].Value = employeeDTO.RoleId;
            parameters[3] = new SqlParameter("@LOGINSTATUS", System.Data.SqlDbType.Int);
            parameters[3].Direction = System.Data.ParameterDirection.Output;
            _helper.ExecuteStoreProcedure("SP_LOGIN_NHANVIEN", parameters);
            return (int)parameters[3].Value; //0: ko trung khop, 1: trung khop, 2: trung khop nhung ko mo khoa
        }
        public EmployeeDTO GetEmployeeFromDataRow(DataRow row)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.EmployeeId = row["MANV"].ToString();
            employeeDTO.EmployeeName = row["TENNV"].ToString();
            employeeDTO.DateOfBirth = new DateTime();
            if (row["NGAYSINH"] != DBNull.Value)
            {
                employeeDTO.DateOfBirth = Convert.ToDateTime(row["NGAYSINH"]);
            }
            employeeDTO.Salary = Encoding.UTF8.GetBytes(row["LUONG"].ToString());
            employeeDTO.Telephone = row["SODT"].ToString();
            employeeDTO.Allowance = Encoding.UTF8.GetBytes(row["PHUCAP"].ToString());
            employeeDTO.GenderId = row["MAGT"].ToString();
            employeeDTO.RoleId = row["MAVT"].ToString();
            employeeDTO.DepartmentId = row["MAPB"].ToString();
            employeeDTO.ManagerId = row["MANQL"].ToString();
            employeeDTO.StatusId = row["MATT"].ToString();
            employeeDTO.Username = row["TENDN"].ToString();
            employeeDTO.Password = Encoding.UTF8.GetBytes(row["MATKHAU"].ToString());          
            employeeDTO.DateCreated = new DateTime();
            if (row["NGAYTAO"] != DBNull.Value)
            {
                employeeDTO.DateCreated = Convert.ToDateTime(row["NGAYTAO"]);
            }
            return employeeDTO;
        }
        public EmployeeDTO[] GetAllEmployee()
        {
            int n = 0;
            DataTable dataTable = new DataTable();
            dataTable = _helper.ExecuteQuery("SELECT * FROM NHANVIEN");
            n = dataTable.Rows.Count;
            EmployeeDTO[] employeeDTOs = new EmployeeDTO[n];
            if (n == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    employeeDTOs[i] = new EmployeeDTO();
                    employeeDTOs[i] = GetEmployeeFromDataRow(dataTable.Rows[i]);
                }
            }
            return employeeDTOs;
        }
        public bool SetStatusEmployee(EmployeeDTO employeeDTO)
        {
            string query = String.Format("UPDATE NHANVIEN SET MATT='{0}' WHERE MANV='{1}'", employeeDTO.StatusId, employeeDTO.EmployeeId);
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public EmployeeDTO GetEmployeeFromEmployeeId(string employeeId)
        {
            string query = String.Format("SELECT * FROM NHANVIEN WHERE MANV='{0}'", employeeId);
            DataTable dataTable = new DataTable();
            dataTable = _helper.ExecuteQuery(query);
            return GetEmployeeFromDataRow(dataTable.Rows[0]);
        }
        public EmployeeDTO[] GetAllDepartmentLead()
        {
            DataTable dataTable = _helper.ExecuteQuery("SELECT * FROM NHANVIEN WHERE MAVT='VT02'");
            int n = dataTable.Rows.Count;
            EmployeeDTO[] departmentLeads = new EmployeeDTO[n];

            if(n == 0)
            {
                return null;
            }
            else
            {
                for(int i = 0; i < n; i++)
                {
                    departmentLeads[i] = new EmployeeDTO();
                    departmentLeads[i] = GetEmployeeFromDataRow(dataTable.Rows[i]);
                }
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
        public DataTable GetEmployeeFromEmployeeUsername(string  username)
        {
            DataTable dataTable = new DataTable();
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENDN='{0}'", username);
            dataTable = _helper.ExecuteQuery(query);
            if(dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
        }
        public bool CreateAccountEmployee(EmployeeDTO employeeDTO)
        {
            string query = "INSERT NHANVIEN(MANV, NGAYSINH, MAVT, MATT, TENDN, MATKHAU, NGAYTAO) VALUES(@MANV, @NGAYSINH, @MAVT, @MATT, @TENDN, @MATKHAU, @NGAYTAO)";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MANV", SqlDbType.VarChar, 20);
            parameters[0].Value = employeeDTO.EmployeeId;
            parameters[1] = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            parameters[1].Value = employeeDTO.DateOfBirth;
            parameters[2] = new SqlParameter("@MAVT", SqlDbType.VarChar, 20);
            parameters[2].Value = employeeDTO.RoleId;
            parameters[3] = new SqlParameter("@MATT", SqlDbType.VarChar, 20);
            parameters[3].Value = employeeDTO.StatusId;
            parameters[4] = new SqlParameter("@TENDN", SqlDbType.VarChar, 100);
            parameters[4].Value = employeeDTO.Username;
            parameters[5] = new SqlParameter("@MATKHAU", SqlDbType.VarBinary, 8000);
            parameters[5].Value = employeeDTO.Password;
            parameters[6] = new SqlParameter("@NGAYTAO", SqlDbType.DateTime);
            parameters[6].Value = employeeDTO.DateCreated;
            try
            {
                _helper.ExecuteNonQuery(query, parameters);
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
        public bool DeleteEmployeeFromEmployeeId(string employeeId)
        {
            string query = String.Format("DELETE FROM NHANVIEN WHERE MANV='{0}'", employeeId);
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AssignRoleToEmployee(EmployeeDTO employeeDTO, bool grantOption)
        {
            UpdateRoleToEmployee(employeeDTO);
            string query = string.Format("ALTER ROLE {0} ADD MEMBER {1}", employeeDTO.RoleId, employeeDTO.EmployeeId);
            if(grantOption)
            {
                query += " WITH GRANT OPTION";
            }
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            } catch(Exception ex)            
            {
                return false; 
            }
        }
        public bool UpdateRoleToEmployee(EmployeeDTO employeeDTO)
        {
            string query = String.Format("UPDATE NHANVIEN SET MAVT='{0}' WHERE MANV='{1}'", employeeDTO.RoleId, employeeDTO.EmployeeId);
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool AssignPermissionToRole(string roleId, string permission, string obj, bool grantOption)
        {
            string query;
            if(permission == "ALL")
            {
                permission = "SELECT, INSERT, DELETE, UPDATE";
            }
            if(obj == "DATABASE")
            {
                query = string.Format("GRANT {0} TO {1}", permission, roleId);
            }
            else
            {
                query = string.Format("GRANT {0} ON {1} TO {2}", permission, obj, roleId);
            }

            if (grantOption)
            {
                query += " WITH GRANT OPTION";
            }
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RevokePermissionToRole(string roleId, string permission, string obj)
        {
            string query;
            if (permission == "ALL")
            {
                permission = "SELECT, INSERT, DELETE, UPDATE";
            }
            if (obj == "DATABASE")
            {
                query = string.Format("REVOKE {0} TO {1} CASCADE", permission, roleId);
            }
            else
            {
                query = string.Format("REVOKE {0} ON {1} FROM {2} CASCADE", permission, obj, roleId);
            }
            try
            {
                _helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdatePassword(EmployeeDTO employeeDTO)
        {
            string query = "UPDATE NHANVIEN SET MATKHAU=@MATKHAU WHERE TENDN=@TENDN";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@TENDN", SqlDbType.VarChar, 100);
            parameters[0].Value = employeeDTO.Username;
            parameters[1] = new SqlParameter("@MATKHAU", SqlDbType.VarBinary, 8000);
            parameters[1].Value = employeeDTO.Password;
            try
            {
                _helper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
