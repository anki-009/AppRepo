USE [MoviesDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_GetProductByCategory]    Script Date: 6/29/2021 5:00:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_GetProductByCategory]
	-- Add the parameters for the stored procedure here
	 @CategoryId int
AS
BEGIN
	SELECT P.ProductId, P.Sku, P.Name, P.Description, P.Price, p.CategoryId
	FROM   Products P WHERE  P.CategoryId = @CategoryId
END
GO

