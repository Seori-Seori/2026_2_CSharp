using System;
using System.Data.SqlClient;

namespace _11_04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // w10: SQL Server 연결 → 데이터 조회 → 출력 → 연결 종료
            string connStr = @"Server=localhost\SQLEXPRESS;Database=naverDB;Integrated Security=True;Connect Timeout=5;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    Console.WriteLine("SQL Server 연결 성공");
                    Console.WriteLine();

                    string sql = "SELECT id, userName, email, birthYear FROM dbo.userTable ORDER BY id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("아이디\t이름\t이메일\t\t출생연도");
                        Console.WriteLine("-------------------------------------------------------------");

                        int count = 0;
                        while (reader.Read())
                        {
                            string id = reader.GetString(0).Trim();
                            string userName = reader.GetString(1).Trim();
                            string email = reader.GetString(2).Trim();
                            int birthYear = reader.GetInt32(3);

                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, userName, email, birthYear);
                            count++;
                        }

                        Console.WriteLine();
                        Console.WriteLine("조회된 회원: {0}명", count);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Server 연결 또는 조회 오류:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("SQL Server (SQLEXPRESS) 실행 여부와 11_04_1/setup_naverDB.sql 실행 여부를 확인하세요.");
            }
        }
    }
}
