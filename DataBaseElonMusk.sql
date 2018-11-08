CREATE TABLE [dbo].[Company] (
    [Id]          BIGINT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Address]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]        BIGINT            IDENTITY (1, 1) NOT NULL,
    [Login]     NVARCHAR (20)  NOT NULL,
    [Password]  NVARCHAR (256) NOT NULL,
    [Status]    INT            NOT NULL,
    [FullName]  NVARCHAR (100) NULL,
    [BirthDay]  DATETIME       NULL,
    [Sex]       BIT            NULL,
    [Email]     NVARCHAR (50)  NULL,
    [CompanyId] BIGINT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_User_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
);


CREATE TABLE [dbo].[Operation] (
    [Id]          BIGINT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ArgsCount]   INT            NOT NULL,
    [Uid]         NVARCHAR (MAX) NOT NULL,
    [CompanyId]   BIGINT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Operation_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
);

CREATE TABLE [dbo].[Result] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [CreateDate]  DATETIME   DEFAULT (getdate()) NOT NULL,
    [UserId]      BIGINT        NOT NULL,
    [OperationId] BIGINT        NOT NULL,
    [Result]      FLOAT (53) NULL,
	[Args]	      NVARCHAR (MAX) NULL,
    [ExecTime]    BIGINT     NOT NULL,
    [Status]      INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Result_Operation] FOREIGN KEY ([OperationId]) REFERENCES [Operation]([Id]), 
    CONSTRAINT [FK_Result_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
);
