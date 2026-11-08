using System;
using System.Data.SqlClient;

namespace _11_04_1
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

            // 테이블 만들기
            try
            {
                cmd.CommandText = "DROP TABLE userTable";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { }

            cmd.CommandText = "CREATE TABLE userTable(id CHAR(4), userName CHAR(15), email CHAR(15), birthYear INT)";
            cmd.ExecuteNonQuery();

            // 데이터 입력
            cmd.CommandText = "INSERT INTO userTable VALUES('john', 'John Bann', 'john@naver.com', 1990)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('kim', 'Kim Chi', 'kim@daum.net', 1992)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('lee', 'Lee Pal', 'lee@paran.com', 1988)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('park', 'Park Su', 'park@gmail.com', 1980)";
            cmd.ExecuteNonQuery();

            // 데이터베이스 닫기
            conn.Close();
            Console.WriteLine("SQL Server 연결 성공!!");
        }
    }
}
