using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV.DAL
{
    internal class DataHelper
    {
        private static SqlConnection _connection = null;
        public DataHelper()
        {
            string connection = ConfigurationSettings.AppSettings["DBConnection"];
            _connection = new SqlConnection(connection);
        }
        public void SetConnection(string connection)
        {
            _connection = new SqlConnection(connection);
        }
        //Thực hiện các câu truy vấn
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện truy vấn: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return dataTable;
        }
        //Thực hiện CRUD: Create, Update, Delete
        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện CUD: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        //Thực hiện store procedure
        public void ExecuteStoreProcedure(string procedure, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(procedure, _connection);
            command.CommandType = CommandType.StoredProcedure;
            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            try
            {
                _connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện store procedure: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Thêm phương thức ExecuteNonQuery mới
        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện CUD: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
