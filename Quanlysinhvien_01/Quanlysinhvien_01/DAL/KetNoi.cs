using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace Quanlysinhvien_01.DAL
{
    public class KetNoi
    {
        // Chuỗi kết nối cơ sở dữ liệu
        private string connectionString = @"Data Source=localhost;Initial Catalog=db_QLSV_01;Integrated Security=True;";
        private static KetNoi instance; 

        public static KetNoi Instance
        {
            get { if (instance == null) instance = new KetNoi(); return instance; }
            private set => instance = value;
        }

        private KetNoi() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //public bool ExecuteNonQuery(string query, object[] parameter = null)
        //{
        //    int data = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        if (parameter != null)
        //        {
        //            string[] listParams = query.Split(' ');

        //            int i = 0;
        //            foreach (string item in listParams)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        data = command.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    return data > 0;
        //}

    }
}
