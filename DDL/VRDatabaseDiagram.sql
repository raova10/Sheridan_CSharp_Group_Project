CREATE TABLE [Order] 
	(OrderID int IDENTITY NOT NULL, 
	OrderDate datetime NOT NULL, 
	CustomerID int NOT NULL, 
	OrderStatus char(255) NOT NULL, 
	InventoryUpdated char(5) NOT NULL, 
	PRIMARY KEY (OrderID));

CREATE TABLE OrderItem 
	(OrderItemID int IDENTITY NOT NULL, 
	OrderItemNumOfItems int NOT NULL, 
	ProductProductID int NOT NULL, 
	OrderOrderID int NOT NULL, 
	PRIMARY KEY (OrderItemID));

CREATE TABLE Product 
	(ProductID int IDENTITY NOT NULL, 
	ProductName char(255) NOT NULL,
	 ProductCategory char(255) NOT NULL, 
	 ProductDesc char(255) NULL, 
	 ProductManufacturer char(255) NULL, 
	 ProductQuantityOnHand int NOT NULL,
	  PRIMARY KEY (ProductID));

CREATE TABLE ProductPart 
	(ProductPartID int IDENTITY NOT NULL, 
	ProductPartCategory char(255) NOT NULL, 
	ProductPartDesc char(255) NULL, 
	ProductPartQuantityOnHand int NOT NULL, 
	ProductProductID int NOT NULL, 
	PRIMARY KEY (ProductPartID));

ALTER TABLE OrderItem ADD CONSTRAINT FKOrderItem700361 FOREIGN KEY (ProductProductID) REFERENCES Product (ProductID);
ALTER TABLE ProductPart ADD CONSTRAINT FKProductPar309986 FOREIGN KEY (ProductProductID) REFERENCES Product (ProductID);
ALTER TABLE OrderItem ADD CONSTRAINT FKOrderItem314556 FOREIGN KEY (OrderOrderID) REFERENCES [Order] (OrderID);
