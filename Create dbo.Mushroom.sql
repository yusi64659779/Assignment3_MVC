USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Mushroom] Script Date: 10/16/2019 1:57:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Mushroom] (
    [Form_ID]                       INT            NOT NULL,
    [Veg_ID]                        INT            NOT NULL,
    [Form]                          VARCHAR (50)   NULL,
    [Average_Retail_Price_Dollars]  DECIMAL (3, 2) NULL,
    [Price_Unit]                    VARCHAR (50)   NULL,
    [Preparation_yield_Factor]      DECIMAL (3, 2) NULL,
    [Size_Cup_Equivalent]           DECIMAL (4, 3) NULL,
    [Size_Unit]                     VARCHAR (50)   NULL,
    [Average_Price_Per_Cup_Dollars] DECIMAL (3, 2) NULL
);
Insert INTO Mushroom(Form_ID, Veg_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars) 
VALUES 
        (1001,3,'Fresh(Whole)',3.55,'per pound',0.97,0.154,'pounds',0.56), 
        (1002,3,'Fresh(Sliced)',3.81,'per pound',1,0.154,'pounds',0.59);


