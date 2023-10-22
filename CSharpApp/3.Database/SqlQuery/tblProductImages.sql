IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblProductImages]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblProductImages (
       Id INT PRIMARY KEY IDENTITY(1,1),
	   ProductId INT NOT NULL FOREIGN KEY REFERENCES tblProducts(Id),
       Name NVARCHAR(250) NOT NULL,
       CreatedDate DATETIME NOT NULL
);'
