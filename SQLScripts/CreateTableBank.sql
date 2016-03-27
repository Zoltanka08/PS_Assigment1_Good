use BankData;

CREATE TABLE Bank
(
Id int IDENTITY PRIMARY KEY,
Location int,
UserId int,
ClientId int,
FOREIGN KEY (UserId) REFERENCES [User](Id),
FOREIGN KEY (ClientId) REFERENCES Client(Id)
);