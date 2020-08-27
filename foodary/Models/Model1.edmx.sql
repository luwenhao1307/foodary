
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/27/2020 22:32:47
-- Generated from EDMX file: C:\Users\61478\source\repos\foodary\foodary\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [aspnet-foodary-20200825104712];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FoodEventSet'
CREATE TABLE [dbo].[FoodEventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [What] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL,
    [Phone] bigint  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [Monday] nvarchar(max)  NOT NULL,
    [Tuesday] nvarchar(max)  NOT NULL,
    [Wednesday] nvarchar(max)  NOT NULL,
    [Thursday] nvarchar(max)  NOT NULL,
    [Friday] nvarchar(max)  NOT NULL,
    [Saturday] nvarchar(max)  NOT NULL,
    [Sunday] nvarchar(max)  NOT NULL,
    [Public_holidays] nvarchar(max)  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [Longitude] decimal(10,7)  NOT NULL,
    [Latitude] decimal(10,7)  NOT NULL,
    [Geocoded_location] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FoodEventSet'
ALTER TABLE [dbo].[FoodEventSet]
ADD CONSTRAINT [PK_FoodEventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------