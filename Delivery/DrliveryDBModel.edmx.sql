
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2017 00:19:50
-- Generated from EDMX file: E:\VS_projeckt\Delivery\Delivery\DrliveryDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeliverSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliverSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeliverSet'
CREATE TABLE [dbo].[DeliverSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderDate] nvarchar(max)  NULL,
    [Recipient] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Adress] nvarchar(max)  NULL,
    [DeliverItem] nvarchar(max)  NULL,
    [PaymentType] nvarchar(max)  NULL,
    [Status] nvarchar(max)  NULL,
    [Sumary] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DeliverSet'
ALTER TABLE [dbo].[DeliverSet]
ADD CONSTRAINT [PK_DeliverSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------