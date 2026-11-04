# 11월 4일 · 실습 1 — DB·테이블 생성과 기본 데이터 입력

- 교재 `Project13_1` (w10 강의자료 p.26~33)에 대응
- `11_04_1/Program.cs`는 C#의 `SqlConnection` / `SqlCommand`로 `naverDB`와 `userTable`을 생성하고 기본 회원 4명을 넣습니다.
- 강의자료의 `DROP TABLE`은 기존 회원 데이터를 지울 수 있어 제외했습니다. 재실행해도 없는 회원만 추가합니다.
- SQL 스크립트 `setup_naverDB.sql`도 같은 폴더에 보존했습니다.

PowerShell에서 SQL만 먼저 생성하려면 저장소 루트 `C:\CookC#`에서 아래를 실행합니다.

```powershell
sqlcmd -S localhost\SQLEXPRESS -E -i ".\11_04_1\setup_naverDB.sql"
```

Visual Studio에서는 저장소 루트의 `11_04_SQL_전체실습.sln`을 열고 `11_04_1`을 시작 프로젝트로 선택해 실행하세요.

나머지 실습은 `11_04_2` 콘솔 입력, `11_04_3` 콘솔 조회, `11_04_4` Windows Forms 입력/조회입니다.
