using System;
using System.Data;
using System.Data.SqlClient;

namespace _11_04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = @"Server=localhost\SQLEXPRESS;Database=naverDB;Integrated Security=True;Connect Timeout=5;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    Console.WriteLine("연결 성공 (아이디를 비워두면 종료)");

                    while (true)
                    {
                        Console.Write("사용자 ID => ");
                        string id = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(id)) break;

                        Console.Write("사용자 이름 => ");
                        string name = Console.ReadLine();
                        Console.Write("사용자 이메일 => ");
                        string email = Console.ReadLine();
                        Console.Write("사용자 출생연도 => ");
                        string yearText = Console.ReadLine();

                        int year;
                        if (id.Length > 4 || string.IsNullOrWhiteSpace(name) ||
                            name.Length > 15 || string.IsNullOrWhiteSpace(email) ||
                            email.Length > 15 || !int.TryParse(yearText, out year) ||
                            year < 1 || year > 9999)
                        {
                            Console.WriteLine("입력 오류: ID 최대 4자, 이름/이메일 최대 15자, 출생연도 숫자");
                            continue;
                        }

                        using (SqlCommand cmd = new SqlCommand(
                            @"IF NOT EXISTS (SELECT 1 FROM dbo.userTable WHERE id = @id)
                              INSERT INTO dbo.userTable (id, userName, email, birthYear)
                              VALUES (@id, @name, @email, @year);", conn))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.Char, 4).Value = id;
                            cmd.Parameters.Add("@name", SqlDbType.Char, 15).Value = name;
                            cmd.Parameters.Add("@email", SqlDbType.Char, 15).Value = email;
                            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
                            Console.WriteLine(cmd.ExecuteNonQuery() > 0 ?
                                "입력 완료" : "이미 존재하는 ID입니다.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Server 오류: " + ex.Message);
            }
        }
    }
}
