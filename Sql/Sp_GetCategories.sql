USE [MoviesDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_GetCategories]    Script Date: 6/29/2021 5:00:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ankita Patel
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_GetCategories]
	 
AS
BEGIN
	 select Categories.CategoryId ,Categories.CategoryName from Categories;
END
GO

