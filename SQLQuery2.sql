

CREATE TABLE [dbo].[Exam_Details] (
    [Id]              INT           NOT NULL,
    [QuestionId]      INT           NULL,
    [Option Selected] BIT           NULL,
    [CorrectOption]   NVARCHAR (50) NULL,
    [SubjectId]       INT           NULL,
    [Result]          BIT           NULL,
    [StudentId]       INT           NULL,
    [ExamID]          INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Questions] ([Id]),
    CONSTRAINT [FK_Exam_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subjects] ([Id]),
    CONSTRAINT [FK_ExamID] FOREIGN KEY ([ExamID]) REFERENCES [dbo].[Exams] ([Id])
);

CREATE TABLE [dbo].[Exams] (
    [Id]                     INT           IDENTITY (1, 1) NOT NULL,
    [Time]                   NVARCHAR (50) NULL,
    [TotalNumberOfQuestions] NVARCHAR (50) NULL,
    [TypeId]                 INT           NULL,
    [TotalMarks]             NVARCHAR (50) NULL,
    [TeacherId]              INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TeacherId] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);


CREATE TABLE [dbo].[GDPR] (
    [Id]                 INT IDENTITY (1, 1) NOT NULL,
    [Columns in Student] BIT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StudentId] FOREIGN KEY ([Id]) REFERENCES [dbo].[Student] ([Id])
);


CREATE TABLE [dbo].[Groups] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NULL,
    [FUB_StartDate] DATE          NULL,
    [FUB_EndDate]   DATE          NULL,
    [FUB_TotDays]   INT           NULL,
    [AUB_EndDate]   DATE          NULL,
    [AUB_TotDays]   INT           NULL,
    [Location]      NVARCHAR (50) NULL,
    [TeacherId]     INT           NULL,
    [StudentId]     INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]),
    CONSTRAINT [TeacherId] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);


CREATE TABLE [dbo].[Internship] (
    [Id]                 INT           NOT NULL,
    [StudentId]          INT           NULL,
    [StartDate]          DATE          NULL,
    [EndDate]            DATE          NULL,
    [CompanyName]        NVARCHAR (50) NULL,
    [ContactPerson]      NVARCHAR (50) NULL,
    [ContactPhoneNumber] INT           NULL,
    [ContactEmail]       NVARCHAR (50) NULL,
    [City]               NVARCHAR (50) NULL,
    [Technologies]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Internship_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id])
);


CREATE TABLE [dbo].[Questions] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Question]      NVARCHAR (50) NULL,
    [Option1]       BIT           NULL,
    [Option2]       BIT           NULL,
    [Option3]       BIT           NULL,
    [Option4]       BIT           NULL,
    [CorrectOption] NVARCHAR (50) NULL,
    [Explanation]   NVARCHAR (50) NULL,
    [SubjectID]     INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
  
    CONSTRAINT [FK_SubjectId] FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[Subjects] ([Id])
    
);

    








CREATE TABLE [dbo].[Result] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [StudentId]         INT NULL,
    [TotalMaxScore]     INT NULL,
    [TotalSubjectScore] INT NULL,
    [Status]            BIT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Result_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id])
);


CREATE TABLE [dbo].[Roles] (
    [Id]   INT           NOT NULL,
    [Name] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[RoleUsers] (
    [Id]     INT NOT NULL,
    [RoleId] INT NULL,
    [UserId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Student] (
    [Id]                 INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]          NVARCHAR (50) NULL,
    [LastName]           NVARCHAR (50) NULL,
    [EmailAddress]       NVARCHAR (50) NULL,
    [Phone]              NVARCHAR (50) NULL,
    [Date_of_Birth]      DATE          NULL,
    [FUB_ärandenummer]   NVARCHAR (50) NULL,
    [AUB_ärandenummer]   NVARCHAR (50) NULL,
    [ProfilePicture]     IMAGE         NULL,
    [CV]                 NVARCHAR (50) NULL,
    [ICE_name]           NVARCHAR (50) NULL,
    [ICE_Mobile]         NVARCHAR (50) NULL,
    [ICE_emails_Address] NVARCHAR (50) NULL,
    [HandläggareId]      INT           NULL,
    [GroupId]            INT           NULL,
    [Remark]             NVARCHAR (50) NULL,
    [UserID]             INT           NULL,
    [FileName]           NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]),
    CONSTRAINT [UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([Id])
);



CREATE TABLE [dbo].[Subjects] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Description] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Teacher] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NULL,
    [LastName]     NVARCHAR (50) NULL,
    [PersonNumber] INT           NULL,
    [Email]        NVARCHAR (50) NULL,
    [Phone Number] NVARCHAR (50) NULL,
    [UserId]       INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


CREATE TABLE [dbo].[Types] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NULL,
    [LastName]     NVARCHAR (50) NULL,
    [UserName]     NVARCHAR (50) NULL,
    [Password]     NVARCHAR (50) NULL,
    [EmailAddress] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);















