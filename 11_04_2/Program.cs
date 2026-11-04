using System;
using System.Data.SqlClient;

namespace _11_04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server = localhost\\SQLEXPRESS;Database = naverDB;Trusted_Connection = True;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            string data1, data2, data3, data4, sql;
            while (true)
            {
                Console.Write("사용자 ID ==> ");
                data1 = Console.ReadLine();
                if (data1.Length == 0)
                    break;
                Console.Write("사용자 이름 ==> ");
                data2 = Console.ReadLine();
                Console.Write("사용자 이메일 ==> ");
                data3 = Console.ReadLine();
                Console.Write("사용자 출생연도 ==> ");
                data4 = Console.ReadLine();

                sql = "INSERT INTO userTable VALUES('" + data1 + "','" + data2 + "','" + data3 + "'," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
