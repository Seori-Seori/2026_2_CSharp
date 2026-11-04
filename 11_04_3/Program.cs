using System;
using System.Data.SqlClient;

namespace _11_04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 데이터베이스 연결
            string connStr = "Server = localhost\\SQLEXPRESS;Database = naverDB;Trusted_Connection = True;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // 커맨드 생성
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // 데이터 조회
            cmd.CommandText = "SELECT * FROM userTable";
            SqlDataReader reader = cmd.ExecuteReader();

            // 조회한 데이터 출력
            Console.WriteLine("아이디\t이름\t\t이메일\t\t출생연도");
            Console.WriteLine("-------------------------------------------------");
            while (reader.Read())
            {
                Console.Write(reader.GetString(0) + "\t");
                Console.Write(reader.GetString(1) + "\t");
                Console.Write(reader.GetString(2) + "\t");
                Console.WriteLine(reader.GetInt32(3) + "\t");
            }
            reader.Close();

            // 데이터베이스 닫기
            conn.Close();
        }
    }
}
