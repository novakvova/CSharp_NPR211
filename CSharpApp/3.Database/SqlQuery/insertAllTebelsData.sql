INSERT INTO tblProfessions(Name) VALUES(N'Програміст');
INSERT INTO tblProfessions(Name) VALUES(N'Слюсар');
INSERT INTO tblProfessions(Name) VALUES(N'Математик');
INSERT INTO tblProfessions(Name) VALUES(N'Механік');
INSERT INTO tblProfessions(Name) VALUES(N'Ліфтер');
insert into tblCategories(Name, Description, Image, CreatedDate) Values(N'Ноутбуки', N'Ноутбуки для козаків', N'https://i5.walmartimages.com/asr/b9085954-bfa6-4650-afa3-423cb1b44242.b3c7842f32cf96ddad48c2b6e7cd5fcf.jpeg', N'12-11-2023');
insert into tblCategories(Name, Description, Image, CreatedDate) Values(N'Планшети', N'Планшети для козачок', N'https://www.proshop.no/Images/915x900/3105910_595b4db1ba38.jpg', N'12-11-2023');
insert into tblCategories(Name, Description, Image, CreatedDate) Values(N'Смартфони', N'Смартфони для всіх', N'https://images.samsung.com/is/image/samsung/p6pim/pk/feature/164639001/pk-feature-minimal-look--quality-design-537050997?$FB_TYPE_A_MO_JPG$', N'12-11-2023');
insert into tblProducts(CategoryId, Name, Description, Price, CreatedDate) Values(1, N'HP ProBook', N'Крутий ноутбук', 28000, N'12-11-2023');
insert into tblProducts(CategoryId, Name, Description, Price, CreatedDate) Values(2, N'Lenovo Tab M10 Plus', N'Крутезний планшет', 10500, N'12-11-2023');
insert into tblProducts(CategoryId, Name, Description, Price, CreatedDate) Values(3, N'Samsung Galaxy A04s', N'Бомбічний смартфон', 17000, N'12-11-2023');
insert into tblProductImages(ProductId, Name, CreatedDate) Values(1, N'https://i5.walmartimages.com/asr/b9085954-bfa6-4650-afa3-423cb1b44242.b3c7842f32cf96ddad48c2b6e7cd5fcf.jpeg', N'12-11-2023');
insert into tblProductImages(ProductId, Name, CreatedDate) Values(2, N'https://www.proshop.no/Images/915x900/3105910_595b4db1ba38.jpg', N'12-11-2023');
insert into tblProductImages(ProductId, Name, CreatedDate) Values(3, N'https://images.samsung.com/is/image/samsung/p6pim/pk/feature/164639001/pk-feature-minimal-look--quality-design-537050997?$FB_TYPE_A_MO_JPG$', N'12-11-2023');
insert into tblClients(ProfessionId, FirstName, LastName, Phone, DateOfBirth, CreateDate, Sex) Values(1, N'Максим', N'Петренко', N'0994567382', N'03-03-1982', N'12-11-2023', 1);
insert into tblClients(ProfessionId, FirstName, LastName, Phone, DateOfBirth, CreateDate, Sex) Values(2, N'Олена', N'Максимович', N'0674829384', N'10-04-1994', N'12-11-2023', 0);
insert into tblClients(ProfessionId, FirstName, LastName, Phone, DateOfBirth, CreateDate, Sex) Values(4, N'Дмитро', N'Петренко', N'0509892673', N'18-11-1998', N'12-11-2023', 1);


insert into tblOrders(ClientId, CreatedDate, OrderStatusId) Values(2, N'12-11-2023', 1);
insert into tblOrders(ClientId, CreatedDate, OrderStatusId) Values(3, N'12-11-2023', 2);
insert into tblOrderItems(OrderId, ItemId) Values(1, 2);
insert into tblOrderItems(OrderId, ItemId) Values(1, 3);
insert into tblOrderItems(OrderId, ItemId) Values(2, 1);
