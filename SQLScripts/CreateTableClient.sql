use BankData;

CREATE TABLE Client
(
Id int IDENTITY PRIMARY KEY,
Firstnme varchar(50) NOT NULL,
Lastname varchar(50) NOT NULL,
CNP varchar(50) NOT NULL,
Mobile varchar(20) NOT NULL,
City varchar(50),
Street varchar(50),
Number varchar(50) 
);