use BankData;

CREATE TABLE Billing
(
Id int IDENTITY PRIMARY KEY,
Amount float,
[Timestamp] DATETIME,
AccountId int,
FOREIGN KEY (AccountId) REFERENCES Account(Id)
);