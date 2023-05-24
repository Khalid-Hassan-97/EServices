IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Users] (
    [UserId] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [PasswordHash] nvarchar(max) NOT NULL,
    [PhoneNumber] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [UserType] int NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([UserId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230524082641_InitialCreate', N'7.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Email', N'Name', N'PasswordHash', N'PhoneNumber', N'UserType', N'Username') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([UserId], [Email], [Name], [PasswordHash], [PhoneNumber], [UserType], [Username])
VALUES (1, N'ahmed@email.com', N'Ahmed Ali Omer Yassir', N'QWhtZWRAMTIz', N'+971112345667', 2, N'Ahmed_50'),
(2, N'ali@email.com', N'Ali Omer Yassir Ahmed', N'QWxpQDEyMw==', N'+971112345667', 2, N'Ali_51'),
(3, N'omer@email.com', N'Omer Yassir Ahmed Ali', N'T21lckAxMjM=', N'+971112345667', 2, N'Omer_52'),
(4, N'yassir@email.com', N'Yassir Ahmed Ali Omer', N'WWFzc2lyQDEyMw==', N'+971112345667', 2, N'Yassir_53'),
(5, N'rami@email.com', N'Rami Ali Ammar', N'UmFtaUAxMjM=', N'+971112345667', 1, N'Rami_90'),
(6, N'hussam@email.com', N'Hussam Ali Ammar', N'SHVzc2FtQDEyMw==', N'+971112345667', 1, N'Hussam_91');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Email', N'Name', N'PasswordHash', N'PhoneNumber', N'UserType', N'Username') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230524090913_SeedData', N'7.0.5');
GO

COMMIT;
GO

