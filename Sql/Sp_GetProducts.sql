USE [MoviesDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_GetFeaturedProducts]    Script Date: 6/29/2021 5:00:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_GetFeaturedProducts]
 
AS
BEGIN
	SELECT P.ProductId, P.Sku, P.Name, P.Description, P.Price,P.CategoryId 
	FROM Products P
		INNER JOIN Categories C
			 ON P.CategoryId = C.CategoryId
	WHERE
		C.[CategoryProductsFeatured] = 1
		OR P.ProductFeatured = 1
END
GO

