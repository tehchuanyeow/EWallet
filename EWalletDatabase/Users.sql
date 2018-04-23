CREATE TABLE [dbo].[Users]
(
	[Username] NVARCHAR(25) NOT NULL PRIMARY KEY, 
    [UserPassword] NCHAR(15) NOT NULL, 
    [UserPermission] NVARCHAR(13) NOT NULL, 
    CONSTRAINT [FK_Users_Permissions] FOREIGN KEY ([UserPermission]) REFERENCES [Permissions]([Permission]) 
)