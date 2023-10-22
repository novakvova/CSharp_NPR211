IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblProducts]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblProducts (
       Id INT PRIMARY KEY IDENTITY(1,1),
	   CategoryId INT NOT NULL FOREIGN KEY REFERENCES tblCategories(Id),
       Name NVARCHAR(250) NOT NULL,
	   Description NVARCHAR(4000) NULL,
	   Price DECIMAL(18, 2),
       CreatedDate DATETIME NOT NULL
);'
