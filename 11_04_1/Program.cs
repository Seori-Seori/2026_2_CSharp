using System;
using System.Data;
using System.Data.SqlClient;

namespace _11_04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string masterStr = @"Server=localhost\SQLEXPRESS;Database=master;Integrated Security=True;Connect Timeout=5;";
            string connStr = @"Server=localhost\SQLEXPRESS;Database=naverDB;Integrated Security=True;Connect Timeout=5;";

            try
            {
                // 교재의 DROP TABLE은 기존 자료를 지우므로 실행하지 않습니다.
                using (SqlConnection conn = new SqlConnection(masterStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "IF DB_ID(N'naverDB') IS NULL EXEC(N'CREATE DATABASE naverDB');", conn))
                        cmd.ExecuteNonQuery();
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"IF OBJECT_ID(N'dbo.userTable', N'U') IS NULL
                          CREATE TABLE dbo.userTable (
                            id CHAR(4), userName CHAR(15), email CHAR(15), birthYear INT
                          );", conn))
                        cmd.ExecuteNonQuery();

                    InsertIfMissing(conn, "john", "John Bann", "john@naver.com", 1990);
                    InsertIfMissing(conn, "kim", "Kim Chi", "kim@daum.net", 1992);
                    InsertIfMissing(conn, "lee", "Lee Pal", "lee@paran.com", 1988);
                    InsertIfMissing(conn, "park", "Park Su", "park@gmail.com", 1980);

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.userTable;", conn))
                        Console.WriteLine("DB·테이블 준비 완료 / 회원 {0}명", cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Server 오류: " + ex.Message);
            }
        }

        private static void InsertIfMissing(SqlConnection conn, string id,
            string userName, string email, int birthYear)
        {
            string sql = @"IF NOT EXISTS (SELECT 1 FROM dbo.userTable WHERE id = @id)
                           INSERT INTO dbo.userTable (id, userName, email, birthYear)
                           VALUES (@id, @name, @email, @year);";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Char, 4).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.Char, 15).Value = userName;
                cmd.Parameters.Add("@email", SqlDbType.Char, 15).Value = email;
                cmd.Parameters.Add("@year", SqlDbType.Int).Value = birthYear;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
