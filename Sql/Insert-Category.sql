USE [MoviesDb]
GO

INSERT INTO [dbo].[Categories]
           ([CategoryId]
           ,[CategoryName]
           ,[CategoryProductsFeatured])
     VALUES
           (<CategoryId, int,>
           ,<CategoryName, varchar(255),>
           ,<CategoryProductsFeatured, bit,>)
GO


