use BankData;

CREATE TABLE Account
(
Id int IDENTITY PRIMARY KEY,
IBAN varchar(100) NOT NULL,
Balance float,
Startdate DATETIME,
TypeId int,
ClientId int,
FOREIGN KEY (TypeId) REFERENCES [Type](Id),
FOREIGN KEY (ClientId) REFERENCES Client(Id) 
);