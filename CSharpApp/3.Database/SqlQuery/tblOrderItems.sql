IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblOrderItems]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE tblOrderItems (
       Id INT PRIMARY KEY IDENTITY(1,1),
       OrderId INT NOT NULL FOREIGN KEY REFERENCES tblOrders(Id),
       ProductId INT NOT NULL FOREIGN KEY REFERENCES tblProducts(Id),
       PriceBy DECIMAL(18, 2),
       CreatedDate DATETIME NOT NULL
);'
