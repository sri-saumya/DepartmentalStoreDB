-- Database: DepartmentalStore

-- DROP DATABASE "DepartmentalStore";

CREATE DATABASE "DepartmentalStore"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_United States.1252'
    LC_CTYPE = 'English_United States.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

  
	
	
---------------------------------------------create tables----------------------


--create product table

CREATE TABLE Product(
 
	product_id SERIAL NOT NULL PRIMARY KEY,
	product_name VARCHAR(50) NOT NULL,
	product_code VARCHAR(50) NOT NULL UNIQUE,
	brand_name VARCHAR(50) NOT NULL,
	cost_price NUMERIC(20,2) NOT NULL,
	selling_price NUMERIC(20,2) NOT NULL
);

--create category table

CREATE TABLE Category(
	
	category_id SERIAL NOT NULL PRIMARY KEY,
	category_name VARCHAR(50) NOT NULL,
	category_code VARCHAR(50) NOT NULL UNIQUE
);

--create category-product junction table

CREATE TABLE ProductCategory(
    product_id INT REFERENCES product(product_id) NOT NULL,
	category_id INT REFERENCES category(category_id) NOT NULL
);

--create inventory table

CREATE TABLE Inventory(
	
	inventory_id SERIAL NOT NULL PRIMARY KEY,
	product_id INT REFERENCES Product(product_id) NOT NULL,
	category_id INT REFERENCES Category(category_id) NOT NULL,
	product_quantity INT ,
	stock CHAR(1) NOT NULL
);

--create supplier table

CREATE TABLE Supplier(
    
	supplier_id SERIAL NOT NULL PRIMARY KEY,
	supplier_name VARCHAR(50) NOT NULL,
	supplier_phone_no INT NOT NULL,
	supplier_email VARCHAR(50) NOT NULL,
	supplier_city VARCHAR(30) NOT NULL,
	supplier_state VARCHAR(30) NOT NULL,
	supply_date DATE
);

--create supplierproduct junction table

CREATE TABLE SupplierProduct(
	
	product_id INT REFERENCES Product(product_id) NOT NULL,
	supplier_id INT REFERENCES Supplier(supplier_id) NOT NULL
);

--create purchase_order table

CREATE TABLE PurchaseOrder(

	order_id SERIAL NOT NULL PRIMARY KEY,
	supplier_id INT REFERENCES Supplier(supplier_id) NOT NULL,
	product_id INT REFERENCES Product(product_id) NOT NULL,
	ordered_product_name VARCHAR(50) NOT NULL,
	purchase_date DATE NOT NULL,
	purchase_qty INT NOT NULL		
);

--create staff table

CREATE TABLE Staff(

	staff_id SERIAL NOT NULL PRIMARY KEY,
	staff_name VARCHAR(50) NOT NULL,
	staff_phone_no INT,
	dep_id INT REFERENCES Department(dep_id) NOT NULL
);

--create staff department table

CREATE TABLE Department(
	
	dep_id SERIAL NOT NULL PRIMARY KEY,
	dep_name VARCHAR(50) NOT NULL
);

---------------------------------------insert data--------------------------

--insert data in product table
INSERT INTO Product (
    product_name ,
    product_code ,
    brand_name ,
    cost_price,
    selling_price ) 
	VALUES ('Milk','mil','Amul',25.2 , 23.00),('Eraser','era','Natraj',20.5 , 23.00),('Bike','Bik','Honda',500000.00 , 600000.02);	

SELECT * from Product;


--insert data in category table
INSERT INTO Category ( category_name,category_code ) 
VALUES ('Dairy','daI'),('Automobile','aut'),('Stationary','sta');

SELECT * from Category;


--insert data in category product junction table
INSERT INTO ProductCategory(product_id ,category_id )
VALUES(1,1),(1,2),(2,1),(2,2);


--insert data in inventory table
INSERT INTO Inventory (product_id ,category_id ,product_quantity ,stock  ) 
VALUES(1,1,3,'T'),(1,1,2,'F'),(3,3,4,'T');


--insert data in supplier table
INSERT INTO Supplier (supplier_id ,supplier_name ,supplier_phone_no,supplier_email,supplier_city ,supplier_state,supply_date ) 
VALUES (1,'Abhinav',9670123,'abhinav@gmail.com','jaipur','mp','2021-10-12'),
        (2,'Yash',9670433,'yash@gmail.com','delhi','up','2020-10-12');
		
		
--insert data in supplier-product table
INSERT INTO SupplierProduct(product_id,supplier_id)
VALUES (1,2),(2,1),(3,1),(1,2);


--insert data in purchase-order table
INSERT INTO PurchaseOrder (order_id ,supplier_id,product_id,ordered_product_name, purchase_date , purchase_qty  )
VALUES (1,2,1,'Book','2021-10-12',12),(2,1,2,'Cheese','2021-10-02',30);


--insert data in department (for staff) table
INSERT INTO Department ( dep_name ) 
VALUES ('AccountManagement'),('InventoryManagement'),('OrderManagement');


--insert data in staff table
INSERT INTO Staff(staff_name,staff_phone_no,dep_id)
VALUES('John',734672,1),('Staphen',873432,2),('Paul',635458,3)

SELECT * from Staff;



-----------------------------------------------------QUERY------------------------------------

--QUERY:1	
SELECT * from Staff
WHERE staff_phone_no = '734672';
	
SELECT * from Staff
WHERE staff_name = 'John';


--QUERY:2	
SELECT * from Staff
WHERE dep_id IN
(SELECT dep_id from department
WHERE dep_name = 'AccountManagement' );


--QUERY:3
SELECT * from product
WHERE product_name='Milk';

SELECT * from product
WHERE selling_price>2;

SELECT * from product
WHERE cost_price<900;

SELECT * from product
WHERE product_id IN
(SELECT product_id from inventory
WHERE stock='T');

SELECT * from product
WHERE product_id IN
(SELECT product_id from inventory
WHERE stock='F');


SELECT p.product_name,c.category_name
from product p
INNER JOIN productcategory pc
ON p.product_id = pc.product_id
INNER JOIN category c
on c.category_id = pc.category_id;


--QUERY:4
SELECT COUNT(STOCK='F') FROM inventory;


--QUERY:5
SELECT p.product_id, p.product_name,p.cost_price,c.category_name
from product p
INNER JOIN productcategory pc
ON p.product_id = pc.product_id
INNER JOIN category c
on c.category_id = pc.category_id
WHERE c.category_name = 'Dairy';


--QUERY:6
SELECT c.category_name,count(i.product_quantity) AS TOTAL
from category c
INNER JOIN inventory i
ON c.category_id = i.category_id
GROUP BY c.category_name
ORDER BY TOTAL DESC;


--QUERY:7
SELECT * from supplier
WHERE supplier_name = 'Yash';

SELECT * from supplier
WHERE supplier_phone_no = '9670123';

SELECT * from supplier
WHERE supplier_email = 'yash@gmail.com';

SELECT * from supplier
WHERE supplier_city = 'Jaipur';

SELECT * from supplier
WHERE supplier_state = 'up';



--QUERY:8
SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE p.product_name='Milk';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN inventory i
ON i.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE i.product_quantity > 1;


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE s.supplier_name='Abhinav';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE p.product_code='mil';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE s.supply_date>'2021-10-02';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE s.supply_date<'2021-10-12';





