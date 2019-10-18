USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Apricot] Script Date: 10/16/2019 1:32:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Apricot] (
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

Insert INTO Apricot (Form_ID, Fruit_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_cup_Dollars) 
VALUES 
        (1001,2,'Fresh',3.09,'per pound',0.93,0.364,'pounds',1.21), 
        (1002,2,'Canned(Packed in Juice)',1.47,'per pound',1.0,0.540,'pounds',0.80), 
        (1003,2,'Canned(Packed in syrup)',1.86,'per pound',0.65,0.441,'pounds',1.26),
		(1004,2,'Dried',7.33,'per pound',1,0.143,'pounds',1.05);

