-- Database: ProductDepartmentalStore

-- DROP DATABASE "ProductDepartmentalStore";

CREATE DATABASE "ProductDepartmentalStore"
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
	category_id INT REFERENCES category(category_id) NOT NULL,
	PRIMARY KEY(product_id,category_id)
);

--create inventory table

CREATE TABLE Inventory(
	
	inventory_id SERIAL NOT NULL PRIMARY KEY,
	product_id INT REFERENCES Product(product_id) NOT NULL,
	category_id INT REFERENCES Category(category_id) NOT NULL,
	product_quantity INT ,
	instock CHAR(1) NOT NULL
);


--create address table

CREATE TABLE Address(
    
	address_id SERIAL PRIMARY KEY,
    address_line1 VARCHAR(152) NOT NULL,
    address_line2 VARCHAR(152) ,
	city VARCHAR(30) NOT NULL,
	state_name VARCHAR(30) NOT NULL,
	country VARCHAR(30) NOT NULL,
	pincode bigint NOT NULL
	
);
--create supplier table

CREATE TABLE Supplier(
    
	supplier_id SERIAL NOT NULL PRIMARY KEY,
	supplier_name VARCHAR(50) NOT NULL,
	supplier_gender CHAR(1) NOT NULL,
	supplier_phone_no CHAR(10) NOT NULL UNIQUE,
	supplier_email VARCHAR(50) NOT NULL,
	address_id INT REFERENCES Address(address_id) NOT NULL,
	supply_date DATE
);

--create supplierproduct junction table

CREATE TABLE SupplierProduct(
	
	product_id INT REFERENCES Product(product_id) NOT NULL,
	supplier_id INT REFERENCES Supplier(supplier_id) NOT NULL,
	PRIMARY KEY(product_id,supplier_id)
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
	staff_gender CHAR(1) NOT NULL,
	staff_phone_no bigint NOT NULL UNIQUE,
	address_id INT REFERENCES Address(address_id) NOT NULL,
	dep_id INT REFERENCES Department(dep_id) NOT NULL
);

--create staff department table

CREATE TABLE Department(
	
	dep_id SERIAL NOT NULL PRIMARY KEY,
	dep_name VARCHAR(50) NOT NULL,
	dep_description VARCHAR(100)
);

---------------------------------------insert data--------------------------

--insert data in product table
INSERT INTO Product (product_name ,product_code ,brand_name ,cost_price,selling_price ) 
VALUES ('Milk','mil','Amul',25.2 , 23.00),('Eraser','era','Natraj',20.5 , 23.00),
	   ('Bike','bik','Honda',500000.00 , 600000.02),('Car','car','Audi',5000000,600000),
	   ('Cheese','che','Amul',200.0,201.09),('Notebook','not','Extramarks',150,160);	

SELECT * from Product;


--insert data in category table
INSERT INTO Category ( category_name,category_code ) 
VALUES ('Dairy','daI'),('Automobile','aut'),('Stationary','sta'),
       ('Four Wheeler','for'),('Travel','tra');


--insert data in category product junction table
INSERT INTO ProductCategory(product_id ,category_id )
VALUES(1,1),(4,4),(4,2),(2,3),(3,2),(3,5);


--insert data in inventory table
INSERT INTO Inventory (product_id ,category_id ,product_quantity ,instock  ) 
VALUES(1,1,300,'T'),(4,2,0,'F'),(3,5,4988,'T'),
       (1,1,0,'F'),(2,3,3000,'T'),(1,1,300,'T');


--insert data in address table
INSERT INTO Address(address_line1,address_line2,city,state_name,country,pincode)
VALUES('South Delhi Society','West Delhi','Delhi','UP','India',272040),
      ('Goregaun Society','Goregaun east','Mumbai','Maharastra','India',279990),
	  ('Kerela Society','Temple','Karnataka','Kerela','India',872040),
	  ('Jaipuria Society','Jaipur Market','Jaipur','MP','India',299040),
	  ('Gorakhdham Society','Goregaun East','Mumbai','Maharastra','India',27040),
	  ('Chadani Chawk','OLD Delhi ','Delhi','UP','India',272040);


--insert data in supplier table
INSERT INTO Supplier (supplier_name ,supplier_gender,supplier_phone_no,supplier_email,address_id,supply_date ) 
VALUES ('Abhinav','M',9670123678,'abhinav@gmail.com',3,'2016-10-12'),
        ('Prakash','M',9623123678,'prakash@gmail.com',5,'2017-10-12'),
		('Meenu','F',9622123678,'meenu@gmail.com',4,'2018-10-12'),
		('Riya','F',9699123678,'riya@gmail.com',1,'2019-10-12'),
        ('Yash','M',9670833278,'yash@gmail.com',2,'2020-10-12');
select * from Supplier;
		
--insert data in supplier-product table
INSERT INTO SupplierProduct(product_id,supplier_id)
VALUES (2,6),(3,5),(3,4),(3,3),(4,3),(4,6);


--insert data in purchase-order table
INSERT INTO PurchaseOrder (order_id ,supplier_id,product_id,ordered_product_name, purchase_date , purchase_qty  )
VALUES (1,4,1,'Book','2020-10-12',12),
        (2,5,1,'Book','2001-10-12',12),
		(3,6,2,'Book','2024-10-12',12),
		(5,3,1,'Book','2005-10-12',12),
        (4,5,2,'Cheese','2006-10-02',30);


--insert data in department (for staff) table
INSERT INTO Department ( dep_name,dep_description ) 
VALUES ('AccountManagement','Manage account related operations'),
       ('InventoryManagement','Manage stock turn overs'),
	   ('OrderManagement','Manage purchase order and supplier details'),
	   ('Manager','Manage all staff');


--insert data in staff table
INSERT INTO Staff(staff_name,staff_gender,staff_phone_no,address_id,dep_id)
VALUES('John','M',9090734672,4,1),
      ('Staphen','M',8734328877,3,2),
	  ('Paul','F',6354589988,2,3),
	  ('Laura','F',6354589977,3,4);

SELECT * from Staff;



-----------------------------------------------------QUERY------------------------------------

--QUERY:1	
SELECT * from Staff
WHERE staff_phone_no = '6354589977' 
OR
staff_name = 'John';



--QUERY:2	(USING SUBQUERY)
SELECT * from Staff
WHERE dep_id IN
(SELECT dep_id from department
WHERE dep_name = 'AccountManagement' );


--QUERY:3
SELECT * from product
WHERE product_name ILIKE  'c%';

SELECT * from product
WHERE selling_price>50;

SELECT * from product
WHERE cost_price<900;

SELECT * from product
WHERE product_id IN
(SELECT product_id from inventory
WHERE instock='T');

SELECT * from product
WHERE product_id IN
(SELECT product_id from inventory
WHERE instock='F');


SELECT p.product_name,c.category_name
from product p
INNER JOIN productcategory pc
ON p.product_id = pc.product_id
INNER JOIN category c
on c.category_id = pc.category_id;


--QUERY:4
SELECT COUNT(instock='F') FROM inventory;


--QUERY:5
SELECT p.product_id, p.product_name,p.cost_price,c.category_name
from product p
INNER JOIN productcategory pc
ON p.product_id = pc.product_id
INNER JOIN category c
on c.category_id = pc.category_id
WHERE c.category_name LIKE 'D%';


--QUERY:6
SELECT c.category_name,count(i.product_quantity) AS TOTAL
from category c
INNER JOIN inventory i
ON c.category_id = i.category_id
GROUP BY c.category_name
ORDER BY TOTAL DESC;


--QUERY:7

SELECT * from supplier
WHERE supplier_name ILIKE 'A%'
OR
supplier_phone_no = '9622123678'
OR
supplier_email = 'yash@gmail.com';

SELECT s.supplier_id,s.supplier_name,s.supplier_email,a.city
from Supplier s
INNER JOIN Address a
ON s.address_id = a.address_id
WHERE s.address_id = 3;

SELECT s.supplier_id,s.supplier_name,s.supplier_email,a.state_name
from Supplier s
INNER JOIN Address a
ON s.address_id = a.address_id
WHERE s.address_id = 4;



--QUERY:8
SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE p.product_name ILIKE 'C%';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN inventory i
ON i.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE i.product_quantity > 2000;


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE s.supplier_name ILIKE 'A%';


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
WHERE s.supply_date>'2010-10-02';


SELECT pc.order_id,p.product_name,p.product_code,s.supplier_name,s.supply_date
from PurchaseOrder pc
INNER JOIN product p
ON pc.product_id = p.product_id
INNER JOIN supplier s
on s.supplier_id = pc.supplier_id
WHERE s.supply_date<'2021-10-12';