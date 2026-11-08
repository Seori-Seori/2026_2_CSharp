using System;
using System.Data.SqlClient;

namespace w10_hw_4
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

            cmd.CommandText = "SELECT * FROM productTable";
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("제품코드\t제품명\t가격\t재고수량");
            Console.WriteLine("------------------------------------------");
            while (reader.Read())
            {
                Console.Write(reader.GetString(0) + "\t");
                Console.Write(reader.GetString(1) + "\t");
                Console.Write(reader.GetInt32(2) + "\t");
                Console.WriteLine(reader.GetInt32(3) + "\t");
            }
            reader.Close();
            conn.Close();
        }
    }
}
