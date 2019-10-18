USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Agri_Products] Script Date: 10/16/2019 11:38:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Agri_Products] (
    [Product_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Product_Name] NVARCHAR (50) NOT NULL
);

MERGE INTO Agri_Products AS Target 
USING (VALUES 
        (1, 'Fruits'), 
        (2, 'Vegetable') 
        
) 
AS Source (Product_ID,Product_Name) 
ON Target.Product_ID = Source.Product_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Product_Name) 
VALUES (Product_Name);


