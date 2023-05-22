CREATE TABLE [dbo].[Animals] (
    [Id]          INT          NULL Identity,
    [AnimalType]  VARCHAR (50) NULL,
    [AnimalName]  VARCHAR (50) NULL,
    [DOB]         DATETIME     NULL,
    [Breed] VARCHAR (50) NULL,
    [DietType]    VARCHAR (50) NULL,
    [OwnersName]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

