IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblProfessions]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblProfessions (
       Id INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(200) NOT NULL
);'
