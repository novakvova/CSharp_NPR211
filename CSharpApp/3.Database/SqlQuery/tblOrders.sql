IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblOrders]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblOrders (
       Id INT PRIMARY KEY IDENTITY(1,1),
	   ClientId INT NOT NULL FOREIGN KEY REFERENCES tblClients(Id),
	   OrderStatusId INT NOT NULL FOREIGN KEY REFERENCES tblOrderStatus(Id),
       CreatedDate DATETIME NOT NULL
);'
