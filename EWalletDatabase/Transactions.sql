CREATE TABLE [dbo].[Transactions]
(
	[TransactionNumber] INT NOT NULL PRIMARY KEY, 
    [PayingAccountNumber] INT NOT NULL, 
    [PayeeAccountNumber] INT NOT NULL, 
    [Date] TIMESTAMP NOT NULL, 
    [AmountTransferred] FLOAT NOT NULL, 
    [Description] NVARCHAR(50) NULL
)
