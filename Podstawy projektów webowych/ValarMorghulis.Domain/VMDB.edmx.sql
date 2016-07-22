
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/02/2016 20:31:58
-- Generated from EDMX file: D:\projects\euvic\szkolenia\repo\Szkolenia-2016\Podstawy projektów webowych\ValarMorghulis.Domain\VMDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ValarMorghulisDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CharacterHouse_Character]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacterHouse] DROP CONSTRAINT [FK_CharacterHouse_Character];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacterHouse_House]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacterHouse] DROP CONSTRAINT [FK_CharacterHouse_House];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacterTitle_Character]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacterTitle] DROP CONSTRAINT [FK_CharacterTitle_Character];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacterTitle_Title]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacterTitle] DROP CONSTRAINT [FK_CharacterTitle_Title];
GO
IF OBJECT_ID(N'[dbo].[FK_TitleHouse_Title]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TitleHouse] DROP CONSTRAINT [FK_TitleHouse_Title];
GO
IF OBJECT_ID(N'[dbo].[FK_TitleHouse_House]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TitleHouse] DROP CONSTRAINT [FK_TitleHouse_House];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacterCulture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacterSet] DROP CONSTRAINT [FK_CharacterCulture];
GO
IF OBJECT_ID(N'[dbo].[FK_HouseRegion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HouseSet] DROP CONSTRAINT [FK_HouseRegion];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacterHouse1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HouseSet] DROP CONSTRAINT [FK_CharacterHouse1];
GO
IF OBJECT_ID(N'[dbo].[FK_HouseHouse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HouseSet] DROP CONSTRAINT [FK_HouseHouse];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CharacterSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharacterSet];
GO
IF OBJECT_ID(N'[dbo].[CultureSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CultureSet];
GO
IF OBJECT_ID(N'[dbo].[HouseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HouseSet];
GO
IF OBJECT_ID(N'[dbo].[RegionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegionSet];
GO
IF OBJECT_ID(N'[dbo].[TitleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TitleSet];
GO
IF OBJECT_ID(N'[dbo].[CharacterHouse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharacterHouse];
GO
IF OBJECT_ID(N'[dbo].[CharacterTitle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharacterTitle];
GO
IF OBJECT_ID(N'[dbo].[TitleHouse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TitleHouse];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Characters'
CREATE TABLE [dbo].[Characters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Born] nvarchar(max)  NOT NULL,
    [Died] nvarchar(max)  NOT NULL,
    [Culture_Id] int  NOT NULL
);
GO

-- Creating table 'Cultures'
CREATE TABLE [dbo].[Cultures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Houses'
CREATE TABLE [dbo].[Houses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CoatOfArms] nvarchar(max)  NOT NULL,
    [Words] nvarchar(max)  NOT NULL,
    [CharacterId] int  NOT NULL,
    [HouseId] int  NOT NULL,
    [Region_Id] int  NOT NULL
);
GO

-- Creating table 'Regions'
CREATE TABLE [dbo].[Regions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Titles'
CREATE TABLE [dbo].[Titles] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'CharacterHouse'
CREATE TABLE [dbo].[CharacterHouse] (
    [SwornMemebers_Id] int  NOT NULL,
    [Houses_Id] int  NOT NULL
);
GO

-- Creating table 'CharacterTitle'
CREATE TABLE [dbo].[CharacterTitle] (
    [Characters_Id] int  NOT NULL,
    [Titles_Id] int  NOT NULL
);
GO

-- Creating table 'TitleHouse'
CREATE TABLE [dbo].[TitleHouse] (
    [Titles_Id] int  NOT NULL,
    [Houses_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Characters'
ALTER TABLE [dbo].[Characters]
ADD CONSTRAINT [PK_Characters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cultures'
ALTER TABLE [dbo].[Cultures]
ADD CONSTRAINT [PK_Cultures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Houses'
ALTER TABLE [dbo].[Houses]
ADD CONSTRAINT [PK_Houses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Regions'
ALTER TABLE [dbo].[Regions]
ADD CONSTRAINT [PK_Regions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Titles'
ALTER TABLE [dbo].[Titles]
ADD CONSTRAINT [PK_Titles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SwornMemebers_Id], [Houses_Id] in table 'CharacterHouse'
ALTER TABLE [dbo].[CharacterHouse]
ADD CONSTRAINT [PK_CharacterHouse]
    PRIMARY KEY CLUSTERED ([SwornMemebers_Id], [Houses_Id] ASC);
GO

-- Creating primary key on [Characters_Id], [Titles_Id] in table 'CharacterTitle'
ALTER TABLE [dbo].[CharacterTitle]
ADD CONSTRAINT [PK_CharacterTitle]
    PRIMARY KEY CLUSTERED ([Characters_Id], [Titles_Id] ASC);
GO

-- Creating primary key on [Titles_Id], [Houses_Id] in table 'TitleHouse'
ALTER TABLE [dbo].[TitleHouse]
ADD CONSTRAINT [PK_TitleHouse]
    PRIMARY KEY CLUSTERED ([Titles_Id], [Houses_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SwornMemebers_Id] in table 'CharacterHouse'
ALTER TABLE [dbo].[CharacterHouse]
ADD CONSTRAINT [FK_CharacterHouse_Character]
    FOREIGN KEY ([SwornMemebers_Id])
    REFERENCES [dbo].[Characters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Houses_Id] in table 'CharacterHouse'
ALTER TABLE [dbo].[CharacterHouse]
ADD CONSTRAINT [FK_CharacterHouse_House]
    FOREIGN KEY ([Houses_Id])
    REFERENCES [dbo].[Houses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacterHouse_House'
CREATE INDEX [IX_FK_CharacterHouse_House]
ON [dbo].[CharacterHouse]
    ([Houses_Id]);
GO

-- Creating foreign key on [Characters_Id] in table 'CharacterTitle'
ALTER TABLE [dbo].[CharacterTitle]
ADD CONSTRAINT [FK_CharacterTitle_Character]
    FOREIGN KEY ([Characters_Id])
    REFERENCES [dbo].[Characters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Titles_Id] in table 'CharacterTitle'
ALTER TABLE [dbo].[CharacterTitle]
ADD CONSTRAINT [FK_CharacterTitle_Title]
    FOREIGN KEY ([Titles_Id])
    REFERENCES [dbo].[Titles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacterTitle_Title'
CREATE INDEX [IX_FK_CharacterTitle_Title]
ON [dbo].[CharacterTitle]
    ([Titles_Id]);
GO

-- Creating foreign key on [Titles_Id] in table 'TitleHouse'
ALTER TABLE [dbo].[TitleHouse]
ADD CONSTRAINT [FK_TitleHouse_Title]
    FOREIGN KEY ([Titles_Id])
    REFERENCES [dbo].[Titles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Houses_Id] in table 'TitleHouse'
ALTER TABLE [dbo].[TitleHouse]
ADD CONSTRAINT [FK_TitleHouse_House]
    FOREIGN KEY ([Houses_Id])
    REFERENCES [dbo].[Houses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TitleHouse_House'
CREATE INDEX [IX_FK_TitleHouse_House]
ON [dbo].[TitleHouse]
    ([Houses_Id]);
GO

-- Creating foreign key on [Culture_Id] in table 'Characters'
ALTER TABLE [dbo].[Characters]
ADD CONSTRAINT [FK_CharacterCulture]
    FOREIGN KEY ([Culture_Id])
    REFERENCES [dbo].[Cultures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacterCulture'
CREATE INDEX [IX_FK_CharacterCulture]
ON [dbo].[Characters]
    ([Culture_Id]);
GO

-- Creating foreign key on [Region_Id] in table 'Houses'
ALTER TABLE [dbo].[Houses]
ADD CONSTRAINT [FK_HouseRegion]
    FOREIGN KEY ([Region_Id])
    REFERENCES [dbo].[Regions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HouseRegion'
CREATE INDEX [IX_FK_HouseRegion]
ON [dbo].[Houses]
    ([Region_Id]);
GO

-- Creating foreign key on [CharacterId] in table 'Houses'
ALTER TABLE [dbo].[Houses]
ADD CONSTRAINT [FK_CharacterHouse1]
    FOREIGN KEY ([CharacterId])
    REFERENCES [dbo].[Characters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacterHouse1'
CREATE INDEX [IX_FK_CharacterHouse1]
ON [dbo].[Houses]
    ([CharacterId]);
GO

-- Creating foreign key on [HouseId] in table 'Houses'
ALTER TABLE [dbo].[Houses]
ADD CONSTRAINT [FK_HouseHouse]
    FOREIGN KEY ([HouseId])
    REFERENCES [dbo].[Houses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HouseHouse'
CREATE INDEX [IX_FK_HouseHouse]
ON [dbo].[Houses]
    ([HouseId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------