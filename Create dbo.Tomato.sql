USE [Agriculture_Database]
GO

/****** Object: Table [dbo].[Tomato] Script Date: 10/16/2019 1:46:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tomato] (
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

Insert INTO Tomato(Form_ID, Veg_ID, Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_cup_Dollars) 
VALUES 
        (1001,2,'Fresh(grape and Cherry)',3.48,'per pound',0.91,0.375,'pounds',1.43), 
        (1002,2,'Fresh(Roma and Plum)',1.29,'per pound',0.91,0.375,'pounds',0.53), 
        (1003,2,'Fresh(Large Round)',2.01,'per pound',0.91,0.375,'pounds',0.83),
		(1004,2,'Canned',0.91,'per pound',1,0.540,'pounds',0.49);


