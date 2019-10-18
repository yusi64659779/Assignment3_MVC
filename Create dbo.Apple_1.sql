USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Apple] Script Date: 10/16/2019 1:21:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Apple] (
    [Form_ID]                       INT            NOT NULL,
    [Fruit_ID]                      INT            NOT NULL,
    [Form]                          VARCHAR (50)   NULL,
    [Average_Retail_Price_Dollars]  DECIMAL (3, 2) NULL,
    [Price_Unit]                    VARCHAR (50)   NULL,
    [Preparation_yield_Factor]      DECIMAL (2, 1) NULL,
    [Size_Cup_Equivalent]           DECIMAL (4, 3) NULL,
    [Size_Unit]                     VARCHAR (50)   NULL,
    [Average_Price_Per_Cup_Dollars] DECIMAL (3, 2) NULL
);

Insert INTO Apple (Form_ID, Fruit_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_cup_Dollars) 
VALUES 
        (1001,1,'Fresh',1.62,'per pound',0.9,0.243,'pounds',0.44), 
        (1002,1,'Applesauce',1.05,'per pound',1.0,0.540,'pounds',0.57), 
        (1003,1,'Juice(Ready to Drink)',0.63,'per pint',1.0,8,'fl oz',0.32),
		(1004,1,'Juice(Frozen)',0.51,'per pint',1.0,8,'fl oz',0.26);
