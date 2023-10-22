IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblClients]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblClients (
       Id INT PRIMARY KEY IDENTITY(1,1),
       ProfessionId INT NOT NULL FOREIGN KEY REFERENCES tblProfessions(Id),
       FirstName NVARCHAR(50) NOT NULL,
       LastName NVARCHAR(50) NOT NULL,
       Phone NVARCHAR(20) NOT NULL,
       DateOfBirth DATE NULL,
       CreatedDate DATETIME NOT NULL,
       Sex bit NOT NULL
);'
