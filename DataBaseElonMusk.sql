CREATE TABLE [dbo].[Company] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Address]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[User] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Login]     NVARCHAR (20)  NOT NULL,
    [Password]  NVARCHAR (256) NOT NULL,
    [Status]    INT            NOT NULL,
    [FullName]  NVARCHAR (100) NULL,
    [BirthDay]  DATETIME       NULL,
    [Sex]       BIT            NULL,
    [Email]     NVARCHAR (50)  NULL,
    [CompanyId] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_User_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
);


CREATE TABLE [dbo].[Operation] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ArgsCount]   INT            NOT NULL,
    [Uid]         NVARCHAR (MAX) NOT NULL,
    [CompanyId]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Operation_ToCompany] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
);

CREATE TABLE [dbo].[Result] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [CreateDate]  DATETIME   DEFAULT (getdate()) NOT NULL,
    [UserId]      INT        NOT NULL,
    [OperationId] INT        NOT NULL,
    [Result]      FLOAT (53) NOT NULL,
    [ExecTime]    TIME (7)   NOT NULL,
    [Status]      BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Result_Operation] FOREIGN KEY ([OperationId]) REFERENCES [Operation]([Id]), 
    CONSTRAINT [FK_Result_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
);
