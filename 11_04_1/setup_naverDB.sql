-- w10 강의자료 p.18~25 기반: 데이터베이스 생성 / 테이블 / 샘플 데이터 / 조회
-- 처음 실행하거나 다시 실행해도 기존 데이터를 지우지 않습니다.
IF DB_ID(N'naverDB') IS NULL
    EXEC(N'CREATE DATABASE naverDB');
GO

USE naverDB;
GO

IF OBJECT_ID(N'dbo.userTable', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.userTable (
        id CHAR(4),
        userName CHAR(15),
        email CHAR(15),
        birthYear INT
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM userTable WHERE id = 'john')
    INSERT INTO userTable VALUES ('john', 'John Bann', 'john@naver.com', 1990);

IF NOT EXISTS (SELECT 1 FROM userTable WHERE id = 'kim')
    INSERT INTO userTable VALUES ('kim', 'Kim Chi', 'kim@daum.net', 1992);

IF NOT EXISTS (SELECT 1 FROM userTable WHERE id = 'lee')
    INSERT INTO userTable VALUES ('lee', 'Lee Pal', 'lee@paran.com', 1988);

IF NOT EXISTS (SELECT 1 FROM userTable WHERE id = 'park')
    INSERT INTO userTable VALUES ('park', 'Park Su', 'park@gmail.com', 1980);
GO

SELECT id, userName, email, birthYear FROM dbo.userTable ORDER BY id;
GO
