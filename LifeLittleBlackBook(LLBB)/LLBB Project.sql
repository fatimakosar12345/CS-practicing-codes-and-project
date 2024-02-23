create database LLBB

create table UserData
(
  UserID int identity(1,1),
  FirstName varchar(300),
  LastName varchar(300),
  UserName varchar(300),
  Address varchar(300),
  DOB varchar(300),
  Password varchar(300),
  ConfirmPass varchar(300),
)
drop table UserData
alter table UserData alter column FirstName varchar(300) NOT NULL;
alter table UserData alter column LastName varchar(300) NOT NULL;
alter table UserData alter column UserName varchar(300) NOT NULL;
alter table UserData alter column Password varchar(300) NOT NULL;
alter table UserData alter column ConfirmPass varchar(300) NOT NULL;
alter table UserData add primary key(UserID,Password,UserName)

create table ContactBook
(
  ContactID int identity(1,1) primary key,
  UserID int,
  Name varchar(300),
  PhoneNo varchar(300),
  Address varchar(300),
  Day varchar(300),
  Datee date,
)
alter table ContactBook alter column Datee varchar(300);

drop table Budget
create table Budget
(
  BudgetID int identity(1,1) primary key,
  UserID int,
  SourceOfIncome varchar(300),
  NetIncome varchar(300),
  BillExp varchar(300),
  InternetExp varchar(300),
  MedicalExp varchar(300),
  EduExp varchar(300),
  FoodExp varchar(300),
  MisExp varchar(300),
  RIncome varchar(300),
  Datee date,
)

alter table Budget alter column Datee varchar(300);
create table Diary
(
  DiaryID int identity(1,1) primary key,
  UserID int,
  Datee date ,
  Day varchar(300),
  Notes varchar(1000),
)
alter table Diary alter column Datee varchar(300);
drop table Diary

--create table Pictures
--( 
--  UserID int primary key references UserData,
--  Datee date,
--  Day varchar(300),
--)

create table Events
(
  EventID int identity(1,1) primary key,
  UserID int,
  Categori varchar(300),
  Day_No int,
  Month_No int,
  Year int,
  time varchar(300),
)
drop table Events
-- Inserting data into UserData table
INSERT INTO UserData (FirstName, LastName, UserName, Address, DOB, Password, ConfirmPass)
VALUES ('Ali', 'Khan', 'alikhan', '123 Australia St', '1995-05-25', 'password123', 'password123');
INSERT INTO UserData (FirstName, LastName, UserName, Address, DOB, Password, ConfirmPass)
VALUES ('Sara', 'Ahmed', 'saraahmed', '456 Paris St', '1992-12-01', 'secretword', 'secretword');
INSERT INTO UserData (FirstName, LastName, UserName, Address, DOB, Password, ConfirmPass)
VALUES ('Tariq', 'Aziz', 'tariqaziz', '789 USA St', '1998-08-15', 'mypassword', 'mypassword');
INSERT INTO UserData (FirstName, LastName, UserName, Address, DOB, Password, ConfirmPass)
VALUES ('John', 'Doe', 'johndoe', '123 London St', '1990-05-25', 'password456', 'password456');
INSERT INTO UserData (FirstName, LastName, UserName, Address, DOB, Password, ConfirmPass)
VALUES ('Bob', 'Smith', 'bobsmith', '789 Maple St', '1995-08-15', 'password', 'password');

drop table ContactBook
-- Inserting data into ContactBook table
INSERT INTO ContactBook (UserID,Name, PhoneNo, Address, Day, Datee)
VALUES (1,'John', '555-1234', '100 Australia St', 'Monday', '2023-03-27');
INSERT INTO ContactBook (UserID,Name, PhoneNo, Address, Day, Datee)
VALUES (1,'Emily', '555-5678', '200 Paris St', 'Tuesday', '2023-03-28');
INSERT INTO ContactBook (UserID,Name, PhoneNo, Address, Day, Datee)
VALUES (2,'Alice', '555-1234', '100 USA St', 'Friday', '2023-04-27');
INSERT INTO ContactBook (UserID,Name, PhoneNo, Address, Day, Datee)
VALUES (2,'David', '555-5678', '200 London St', 'Thursday', '2023-04-28');


-- Inserting data into Budget table
INSERT INTO Budget (UserID, SourceOfIncome, NetIncome, BillExp, InternetExp, MedicalExp, EduExp, FoodExp, MisExp, RIncome, Datee)
VALUES (1, 'Salary', '3000', '100', '50', '20', '100', '200', '30','500', '2023-03-01');
INSERT INTO Budget (UserID, SourceOfIncome, NetIncome, BillExp, InternetExp, MedicalExp, EduExp, FoodExp, MisExp,RIncome, Datee)
VALUES (1, 'Wages', '2500', '200', '75', '50', '150', '100', '25','300', '2023-03-01');
INSERT INTO Budget (UserID, SourceOfIncome, NetIncome, BillExp, InternetExp, MedicalExp, EduExp, FoodExp, MisExp,RIncome, Datee)
VALUES (2, 'Bonus', '3000', '100', '50', '20', '100', '200', '30','1000', '2023-03-01');
INSERT INTO Budget (UserID, SourceOfIncome, NetIncome, BillExp, InternetExp, MedicalExp, EduExp, FoodExp, MisExp,RIncome, Datee)
VALUES (2, 'Wages', '2500', '200', '75', '50', '150', '100', '25','700', '2023-03-01');


-- Inserting data into Diary
INSERT INTO Diary (UserID, Datee, Day, Notes)
VALUES (1, '2023-03-27', 'Monday', 'Had a productive day at work today.');
INSERT INTO Diary (UserID, Datee, Day, Notes)
VALUES (1, '2023-03-28', 'Tuesday', 'Met with friends for lunch and caught up on old times.');
INSERT INTO Diary (UserID, Datee, Day, Notes)
VALUES (2, '2023-04-25', 'Friday', 'Visited the new museum exhibit today.');
INSERT INTO Diary (UserID, Datee, Day, Notes)
VALUES (2, '2023-05-26', 'Saturday', 'Went on a hike with friends and saw some beautiful views.');


-- Inserting data into Events
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (1, 'Urgent', 5, 6, 2023, '10AM');
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (1, 'Wait', 10, 7, 2023, '1PM');
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (2, 'Urgent', 15, 9, 2023, '12AM');
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (2, 'Personal', 25, 3, 2023, '8AM');
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (1, 'Urgent', 15, 9, 2023, '7AM');
INSERT INTO Events (UserID, Categori, Day_No, Month_No, Year, time)
VALUES (1, 'Urgent', 25, 4, 2023, '12PM');


