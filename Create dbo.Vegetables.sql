USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Vegetables] Script Date: 10/16/2019 12:14:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vegetables] (
    [Veg_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Product_ID] INT           NOT NULL,
    [Veg_Name]   NVARCHAR (50) NOT NULL
);

MERGE INTO Vegetables AS Target 
USING (VALUES 
        (201, 2, 'Potato'), 
        (202, 2, 'Tomato'), 
        (203, 2, 'Mushroom')
) 
AS Source (Veg_ID, Product_ID, Veg_Name) 
ON Target.Veg_ID = Source.Veg_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Product_ID, Veg_Name) 
VALUES (Product_ID, Veg_Name);
