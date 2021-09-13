USE [MoviesDb]
GO

INSERT INTO [dbo].[Products]
           ([CategoryId]
           ,[Name]
           ,[Price]
           ,[Description]
           ,[ProductFeatured])
     VALUES
           (<CategoryId, int,>
           ,<Name, varchar(255),>
           ,<Price, decimal(17,2),>
           ,<Description, varchar(max),>
           ,<ProductFeatured, bit,>)
GO

