
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2016 14:41:21
-- Generated from EDMX file: C:\Users\Administrator\Desktop\LHYS.WMS\DBModel\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TransferBillRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_TransferBillRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_BackInputRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_BackInputRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_OtherInputRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_OtherInputRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_DIYBillRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_DIYBillRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationChangeRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_LocationChangeRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckBillRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_CheckBillRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_GiveBillRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_GiveBillRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_BackOutputRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_BackOutputRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_OtherOutputRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Record] DROP CONSTRAINT [FK_OtherOutputRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuAMenuB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuB] DROP CONSTRAINT [FK_MenuAMenuB];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Location] DROP CONSTRAINT [FK_WarehouseLocation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TransferBill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransferBill];
GO
IF OBJECT_ID(N'[dbo].[BackInput]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BackInput];
GO
IF OBJECT_ID(N'[dbo].[OtherInput]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OtherInput];
GO
IF OBJECT_ID(N'[dbo].[DIYBill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIYBill];
GO
IF OBJECT_ID(N'[dbo].[LocationChange]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocationChange];
GO
IF OBJECT_ID(N'[dbo].[CheckBill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckBill];
GO
IF OBJECT_ID(N'[dbo].[GiveBill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GiveBill];
GO
IF OBJECT_ID(N'[dbo].[BackOutput]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BackOutput];
GO
IF OBJECT_ID(N'[dbo].[OtherOutput]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OtherOutput];
GO
IF OBJECT_ID(N'[dbo].[Record]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Record];
GO
IF OBJECT_ID(N'[dbo].[MenuA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuA];
GO
IF OBJECT_ID(N'[dbo].[MenuB]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuB];
GO
IF OBJECT_ID(N'[dbo].[InWarehouse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InWarehouse];
GO
IF OBJECT_ID(N'[dbo].[Location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Location];
GO
IF OBJECT_ID(N'[dbo].[Warehouse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Warehouse];
GO
IF OBJECT_ID(N'[dbo].[TaskBill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaskBill];
GO
IF OBJECT_ID(N'[dbo].[GoodItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GoodItem];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TransferBill'
CREATE TABLE [dbo].[TransferBill] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [InputType] nvarchar(100)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL,
    [LBBillCode] nvarchar(100)  NULL,
    [LBBillDate] datetime  NULL,
    [LBFrom] nvarchar(100)  NULL,
    [LBMoveType] nvarchar(100)  NULL,
    [LBRemark] nvarchar(500)  NULL
);
GO

-- Creating table 'BackInput'
CREATE TABLE [dbo].[BackInput] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [OutputType] nvarchar(100)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL,
    [LBBillCode] nvarchar(100)  NULL,
    [LBBillDate] datetime  NULL,
    [LBBackWarehouse] nvarchar(100)  NULL,
    [LBMoveType] nvarchar(100)  NULL,
    [LBRemark] nvarchar(500)  NULL,
    [LBBackAddress] nvarchar(500)  NULL,
    [LBContacts] nvarchar(100)  NULL,
    [LBPhone] nvarchar(100)  NULL
);
GO

-- Creating table 'OtherInput'
CREATE TABLE [dbo].[OtherInput] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [InputType] nvarchar(100)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'DIYBill'
CREATE TABLE [dbo].[DIYBill] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'LocationChange'
CREATE TABLE [dbo].[LocationChange] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'CheckBill'
CREATE TABLE [dbo].[CheckBill] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'GiveBill'
CREATE TABLE [dbo].[GiveBill] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [OutputType] nvarchar(100)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL,
    [LBBillCode] nvarchar(100)  NULL,
    [LBBillDate] datetime  NULL,
    [LBTaskBillCode] nvarchar(100)  NULL,
    [LBLine] nvarchar(200)  NULL,
    [LBContacts] nvarchar(100)  NULL,
    [LBPhone] nvarchar(100)  NULL,
    [LBMailCode] nvarchar(100)  NULL,
    [LBCustomerCode] nvarchar(100)  NULL,
    [LBCustomerName] nvarchar(500)  NULL,
    [LBSendAddress] nvarchar(100)  NULL,
    [LBRemark] nvarchar(500)  NULL
);
GO

-- Creating table 'BackOutput'
CREATE TABLE [dbo].[BackOutput] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [InputType] nvarchar(100)  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL,
    [LBBillCode] nvarchar(100)  NULL,
    [LBGiveBillCode] nvarchar(100)  NULL,
    [LBBillDate] datetime  NULL,
    [LBCustomerCode] nvarchar(100)  NULL,
    [LBCustomerName] nvarchar(500)  NULL,
    [LBSendAddress] nvarchar(100)  NULL,
    [LBContacts] nvarchar(100)  NULL,
    [LBPhone] nvarchar(100)  NULL,
    [LBMailCode] nvarchar(100)  NULL,
    [LBReson] nvarchar(500)  NULL,
    [LBRemark] nvarchar(500)  NULL
);
GO

-- Creating table 'OtherOutput'
CREATE TABLE [dbo].[OtherOutput] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [Warehouse] nvarchar(100)  NULL,
    [OutputType] nvarchar(100)  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [BusinessType] nvarchar(100)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'Record'
CREATE TABLE [dbo].[Record] (
    [Id] uniqueidentifier  NOT NULL,
    [MainTableId] uniqueidentifier  NULL,
    [ItemCode] nvarchar(100)  NULL,
    [ItemLine] nvarchar(100)  NULL,
    [ItemName] nvarchar(100)  NULL,
    [ItemSpecifications] nvarchar(100)  NULL,
    [ItemLocation] nvarchar(100)  NULL,
    [ItemBatch] nvarchar(100)  NULL,
    [ItemUnit] nvarchar(100)  NULL,
    [Count] float  NULL,
    [Weight] float  NULL,
    [ReceiveCount] float  NULL,
    [Remark] nvarchar(500)  NULL
);
GO

-- Creating table 'MenuA'
CREATE TABLE [dbo].[MenuA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL,
    [OrderNumber] int  NULL
);
GO

-- Creating table 'MenuB'
CREATE TABLE [dbo].[MenuB] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MenuAId] int  NOT NULL,
    [Name] nvarchar(100)  NULL,
    [Url] nvarchar(500)  NULL,
    [OrderNumber] int  NULL
);
GO

-- Creating table 'InWarehouse'
CREATE TABLE [dbo].[InWarehouse] (
    [Id] uniqueidentifier  NOT NULL,
    [ItemCode] nvarchar(max)  NOT NULL,
    [ItemLine] nvarchar(max)  NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [ItemSpecifications] nvarchar(max)  NOT NULL,
    [ItemLocation] nvarchar(max)  NOT NULL,
    [ItemBatch] nvarchar(100)  NULL,
    [ItemUnit] nvarchar(100)  NULL,
    [Count] float  NULL
);
GO

-- Creating table 'Location'
CREATE TABLE [dbo].[Location] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WarehouseId] int  NOT NULL,
    [Name] nvarchar(100)  NULL,
    [Remark] nvarchar(500)  NULL
);
GO

-- Creating table 'Warehouse'
CREATE TABLE [dbo].[Warehouse] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL,
    [Remark] nvarchar(500)  NULL
);
GO

-- Creating table 'TaskBill'
CREATE TABLE [dbo].[TaskBill] (
    [Id] uniqueidentifier  NOT NULL,
    [BillCode] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [MakePerson] nvarchar(50)  NULL,
    [ExamineDate] datetime  NULL,
    [ExaminePerson] nvarchar(50)  NULL,
    [ChargePerson] nvarchar(50)  NULL,
    [Remark] nvarchar(1000)  NULL
);
GO

-- Creating table 'GoodItem'
CREATE TABLE [dbo].[GoodItem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemCode] nvarchar(100)  NULL,
    [ItemLine] nvarchar(100)  NULL,
    [ItemName] nvarchar(100)  NULL,
    [ItemSpecifications] nvarchar(100)  NULL,
    [ItemLocation] nvarchar(100)  NULL,
    [ItemUnit] nvarchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TransferBill'
ALTER TABLE [dbo].[TransferBill]
ADD CONSTRAINT [PK_TransferBill]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BackInput'
ALTER TABLE [dbo].[BackInput]
ADD CONSTRAINT [PK_BackInput]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OtherInput'
ALTER TABLE [dbo].[OtherInput]
ADD CONSTRAINT [PK_OtherInput]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DIYBill'
ALTER TABLE [dbo].[DIYBill]
ADD CONSTRAINT [PK_DIYBill]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocationChange'
ALTER TABLE [dbo].[LocationChange]
ADD CONSTRAINT [PK_LocationChange]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CheckBill'
ALTER TABLE [dbo].[CheckBill]
ADD CONSTRAINT [PK_CheckBill]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GiveBill'
ALTER TABLE [dbo].[GiveBill]
ADD CONSTRAINT [PK_GiveBill]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BackOutput'
ALTER TABLE [dbo].[BackOutput]
ADD CONSTRAINT [PK_BackOutput]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OtherOutput'
ALTER TABLE [dbo].[OtherOutput]
ADD CONSTRAINT [PK_OtherOutput]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [PK_Record]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MenuA'
ALTER TABLE [dbo].[MenuA]
ADD CONSTRAINT [PK_MenuA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MenuB'
ALTER TABLE [dbo].[MenuB]
ADD CONSTRAINT [PK_MenuB]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InWarehouse'
ALTER TABLE [dbo].[InWarehouse]
ADD CONSTRAINT [PK_InWarehouse]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Location'
ALTER TABLE [dbo].[Location]
ADD CONSTRAINT [PK_Location]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Warehouse'
ALTER TABLE [dbo].[Warehouse]
ADD CONSTRAINT [PK_Warehouse]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TaskBill'
ALTER TABLE [dbo].[TaskBill]
ADD CONSTRAINT [PK_TaskBill]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GoodItem'
ALTER TABLE [dbo].[GoodItem]
ADD CONSTRAINT [PK_GoodItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_TransferBillRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[TransferBill]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransferBillRecord'
CREATE INDEX [IX_FK_TransferBillRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_BackInputRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[BackInput]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BackInputRecord'
CREATE INDEX [IX_FK_BackInputRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_OtherInputRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[OtherInput]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OtherInputRecord'
CREATE INDEX [IX_FK_OtherInputRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_DIYBillRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[DIYBill]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIYBillRecord'
CREATE INDEX [IX_FK_DIYBillRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_LocationChangeRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[LocationChange]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationChangeRecord'
CREATE INDEX [IX_FK_LocationChangeRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_CheckBillRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[CheckBill]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckBillRecord'
CREATE INDEX [IX_FK_CheckBillRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_GiveBillRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[GiveBill]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GiveBillRecord'
CREATE INDEX [IX_FK_GiveBillRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_BackOutputRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[BackOutput]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BackOutputRecord'
CREATE INDEX [IX_FK_BackOutputRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MainTableId] in table 'Record'
ALTER TABLE [dbo].[Record]
ADD CONSTRAINT [FK_OtherOutputRecord]
    FOREIGN KEY ([MainTableId])
    REFERENCES [dbo].[OtherOutput]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OtherOutputRecord'
CREATE INDEX [IX_FK_OtherOutputRecord]
ON [dbo].[Record]
    ([MainTableId]);
GO

-- Creating foreign key on [MenuAId] in table 'MenuB'
ALTER TABLE [dbo].[MenuB]
ADD CONSTRAINT [FK_MenuAMenuB]
    FOREIGN KEY ([MenuAId])
    REFERENCES [dbo].[MenuA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuAMenuB'
CREATE INDEX [IX_FK_MenuAMenuB]
ON [dbo].[MenuB]
    ([MenuAId]);
GO

-- Creating foreign key on [WarehouseId] in table 'Location'
ALTER TABLE [dbo].[Location]
ADD CONSTRAINT [FK_WarehouseLocation]
    FOREIGN KEY ([WarehouseId])
    REFERENCES [dbo].[Warehouse]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WarehouseLocation'
CREATE INDEX [IX_FK_WarehouseLocation]
ON [dbo].[Location]
    ([WarehouseId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------