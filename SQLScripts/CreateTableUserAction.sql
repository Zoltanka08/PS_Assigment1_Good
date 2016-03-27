use BankData;

CREATE TABLE UserAction 
(
Id int IDENTITY PRIMARY KEY,
[Timestamp] DATETIME,
Description varchar(255),
UserId int,
FOREIGN KEY (UserId) REFERENCES [User](Id)
);