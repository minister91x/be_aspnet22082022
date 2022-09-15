using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class DBHelper
    {

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = null;
            try
            {
                var connectstring = "Server=DESKTOP-IFRSV3F;Database=MedicineStore;User Id=sa;Password=123456;";

                connection = new SqlConnection(connectstring);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return connection;
        }


        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            try
            {
                // Bước 1 : Mở connectionString
                var connectionstring = GetSqlConnection();
                //Bước 2 : Dùng Sqlcommand để thao tác với database 
                SqlCommand command = new SqlCommand("Customer_GetList", connectionstring);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // bước 3
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new Employee { ID = reader["ID"].ToString(), address = reader["Name"].ToString() });
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return employees;
        }
        public static int Customer_Insert(string name)
        {
            try
            {
                // Bước 1 : Mở connectionString
                var connectionstring = GetSqlConnection();

                //Bước 2 : Dùng Sqlcommand để thao tác với database 

                // Nếu dùng CommandText thì khai báo CommandType là TEXT
                SqlCommand commandtEXT = new SqlCommand("INSERT INTO KHACHHANG (MaKH, Ten, DiaChi, GioiTinh, Tuoi, SĐT)VALUES(1, '" + name + "', 'HA NOI', 'nam', 18, '091232432')", connectionstring);
                commandtEXT.CommandType = System.Data.CommandType.Text;

                // Nếu dùng StoredProcedure thì khai báo CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("Customer_Insert", connectionstring);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Khới tạo các tham số truyển vào nếu dùng StoreProcedure bằng class SqlParameter 
                SqlParameter sqlParameter = new SqlParameter();
                // Khai bảo tên của Parameter
                sqlParameter.ParameterName = "@_TenKhachhang";
                // GIÁ TRỊ CỦA PARAMETER
                sqlParameter.Value = name;
                // add parametter vào trong Sqlcommand
                command.Parameters.Add(sqlParameter);


                SqlParameter sqlParameter1 = new SqlParameter();
                sqlParameter1.ParameterName = "@_DiaChiKH";
                sqlParameter1.Value = name;
                command.Parameters.Add(sqlParameter1);

                // Bước 3: gọi lênh ExecuteNonQuery tương đương vs lệnh EXCETUE BÊN SQL SERVER
                var result = command.ExecuteNonQuery();

                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return 1;
        }

    }
}
