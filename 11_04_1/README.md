# 10주차 C# × SQL Server 기초 실습

- 강의자료: w10 강의자료.pdf, p.18~39
- 환경: Windows / SQL Server 2019 Express (SQLEXPRESS) / .NET Framework 4.8
- 기능: SQL Server의 naverDB에 연결하여 userTable 4개 행을 조회

## 1. 준비: SQL Server에 샘플 DB 생성

PowerShell이나 Windows Terminal에서 다음 명령어를 실행합니다.

```powershell
sqlcmd -S localhost\SQLEXPRESS -E -i ".\11_04_1\setup_naverDB.sql"
```

실행 기준 경로는 저장소 루트(C:\CookC#)입니다. 또는 sqlcmd `1>` 상태에서 setup_naverDB.sql을 복사해 실행해도 됩니다.

※ 파일에는 GO가 포함되어 있습니다. SSMS가 아닌 sqlcmd용으로도 실행 가능합니다.
※ 기존 DB/테이블은 지우지 않으며, 같은 ID의 샘플 행은 중복 입력하지 않습니다.

## 2. Visual Studio에서 C# 프로젝트 실행

1. 저장소 루트의 `11_04_SQL_기초.sln`을 엽니다.
2. `11_04_1` 프로젝트를 시작 프로젝트로 설정합니다.
3. Ctrl+F5를 눌러 실행합니다.
4. `SQL Server 연결 성공`과 4명 조회 결과를 확인합니다.

접속 주소는 `localhost\SQLEXPRESS`이고 Windows 인증(Integrated Security)을 사용합니다.

이 프로젝트는 SQL Server가 설치된 **본인 Windows 컴퓨터**에서 실행되어야 합니다. SQL Server 서비스가 시작되지 않았다면 먼저 시작해야 합니다.

## 오류가 발생하면

- 로그인 실패: `sqlcmd -S localhost\SQLEXPRESS -E`로 같은 Windows 계정에서 접속되는지 확인
- 데이터베이스 없음: setup_naverDB.sql을 먼저 실행
- 테이블 없음: setup_naverDB.sql을 다시 실행
- 서버를 찾을 수 없음: SQL Server (SQLEXPRESS) 서비스 실행/인스턴스 이름 확인

강의자료 원형에 맞춰 회원 테이블의 타입은 `CHAR(4)`, `CHAR(15)`, `INT`로 유지했습니다. 실제 서비스에서는 길이와 고정문자 타입 설계를 재검토해야 합니다.

실제 Windows Visual Studio 빌드는 별도 확인이 필요합니다.
