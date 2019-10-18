USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Potato] Script Date: 10/16/2019 1:42:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Potato] (
    [Form_ID]                       INT            NOT NULL,
    [Veg_ID]                        INT            NOT NULL,
    [Form]                          VARCHAR (50)   NULL,
    [Average_Retail_Price_Dollars]  DECIMAL (3, 2) NULL,
    [Price_Unit]                    VARCHAR (50)   NULL,
    [Preparation_yield_Factor]      DECIMAL (4, 3) NULL,
    [Size_Cup_Equivalent]           DECIMAL (4, 3) NULL,
    [Size_Unit]                     VARCHAR (50)   NULL,
    [Average_Price_Per_Cup_Dollars] DECIMAL (3, 2) NULL
);

Insert INTO Potato(Form_ID, Veg_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_cup_Dollars) 
VALUES 
        (1001,1,'Fresh',0.60,'per pound',0.811,0.265,'pounds',0.20), 
        (1002,1,'Frozen French Fries',1.22,'per pound',0.776,0.342,'pounds',0.54), 
        (1003,1,'Canned(Packed in syrup)',0.90,'per pound',0.65,0.342,'pounds',0.47);
		
