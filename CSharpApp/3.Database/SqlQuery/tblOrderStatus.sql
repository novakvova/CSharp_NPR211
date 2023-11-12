IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblOrderStatus]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblOrderStatus (
       Id INT PRIMARY KEY IDENTITY(1,1),
       Name NVARCHAR(250) NOT NULL,
       CreatedDate DATETIME NOT NULL
);'
