using System;
using System.Data.SqlClient;

namespace w10_hw_2
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

            try
            {
                cmd.CommandText = "DROP TABLE productTable";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { }

            cmd.CommandText = "CREATE TABLE productTable(pCode CHAR(5), pName CHAR(15), price INT, amount INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO productTable VALUES('p0001', '노트북', 110, 5)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO productTable VALUES('p0002', '마우스', 3, 22)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO productTable VALUES('p0003', '키보드', 2, 11)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM productTable";
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("pCode\tpName\tprice\tamount");
            Console.WriteLine("-------------------------------------------");
            while (reader.Read())
            {
                Console.Write(reader.GetString(0) + "\t");
                Console.Write(reader.GetString(1) + "\t");
                Console.Write(reader.GetInt32(2) + "\t");
                Console.WriteLine(reader.GetInt32(3));
            }
            reader.Close();
            conn.Close();
        }
    }
}
