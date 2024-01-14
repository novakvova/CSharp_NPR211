IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblCategories]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblCategories (
       Id INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(50) NOT NULL,
       Description NVARCHAR(4000) NULL,
       Image NVARCHAR(200) NOT NULL,
       CreatedDate DATETIME NOT NULL
);'
