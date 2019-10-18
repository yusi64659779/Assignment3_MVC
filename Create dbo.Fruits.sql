USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Fruits] Script Date: 10/16/2019 12:08:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Fruits] (
    [Fruit_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Product_ID] INT           NOT NULL,
    [Fruit_Name] NVARCHAR (50) NOT NULL
);
MERGE INTO Fruits AS Target 
USING (VALUES 
        (101, 1, 'Apple'), 
        (102, 1, 'Apricot'), 
        (103, 1, 'Blueberry')
) 
AS Source (Fruit_ID, Product_ID, Fruit_Name) 
ON Target.Fruit_ID = Source.Fruit_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Product_ID,Fruit_Name) 
VALUES (Product_ID,Fruit_Name);

