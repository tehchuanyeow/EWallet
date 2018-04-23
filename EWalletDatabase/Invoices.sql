CREATE TABLE [dbo].[Invoices]
(
	[InvoiceNumber] INT NOT NULL PRIMARY KEY, 
    [PayingAccountNumber] INT NOT NULL, 
    [PayeeAccountNumber] INT NOT NULL, 
    [AmountPaid] FLOAT NOT NULL, 
    [AmountPayable] FLOAT NOT NULL, 
    [DueDate] DATE NOT NULL, 
    CONSTRAINT [FK_Invoices_Account_Paying] FOREIGN KEY ([PayingAccountNumber]) REFERENCES [Account]([AccountNumber]), 
    CONSTRAINT [FK_Invoices_Account_Payee] FOREIGN KEY ([PayeeAccountNumber]) REFERENCES [Account]([AccountNumber]), 
	)
