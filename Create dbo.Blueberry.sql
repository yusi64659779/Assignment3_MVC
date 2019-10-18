USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Blueberry] Script Date: 10/16/2019 1:37:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Blueberry] (
    [Form_ID]                       INT            NOT NULL,
    [Fruit_ID]                      INT            NOT NULL,
    [Form]                          VARCHAR (50)   NULL,
    [Average_Retail_Price_Dollars]  DECIMAL (3, 2) NULL,
    [Price_Unit]                    VARCHAR (50)   NULL,
    [Preparation_yield_Factor]      DECIMAL (3, 2) NULL,
    [Size_Cup_Equivalent]           DECIMAL (4, 3) NULL,
    [Size_Unit]                     VARCHAR (50)   NULL,
    [Average_Price_Per_Cup_Dollars] DECIMAL (3, 2) NULL
);

Insert INTO Blueberry (Form_ID, Fruit_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_cup_Dollars) 
VALUES 
        (1001,3,'Fresh',4.39,'per pound',0.95,0.320,'pounds',1.48), 
        (1002,3,'Frozen',3.47,'per pound',1.0,0.331,'pounds',1.15);

