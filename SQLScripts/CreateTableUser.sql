use BankData;

CREATE TABLE [User]
(
Id int IDENTITY PRIMARY KEY,
Username varchar(30) NOT NULL,
[Password] varchar(200) NOT NULL,
Firstname varchar(50),
Lastname varchar(50),
Mobile varchar(20) NOT NULL,
Mail varchar(50) NOT NULL,
RoleId int,
FOREIGN KEY (RoleId) REFERENCES [Role](Id)
);