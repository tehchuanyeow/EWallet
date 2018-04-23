CREATE TABLE [dbo].[Account]
(
	[AccountNumber] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(25) NOT NULL, 
    [AccountName] NCHAR(25) NULL, 
    [AccountBalance] FLOAT NOT NULL, 
    CONSTRAINT [FK_Account_Users] FOREIGN KEY ([Username]) REFERENCES [Users]([Username])
)
