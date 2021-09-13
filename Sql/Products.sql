USE [MoviesDb]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 6/29/2021 4:59:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Price] [decimal](17, 2) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[ProductFeatured] [bit] NOT NULL,
	[Sku]  AS (CONVERT([varchar](10),[CategoryId])+right('0000'+CONVERT([varchar](4),[ProductId]),(4))),
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_ProductPrice]  DEFAULT ((99999999999.99)) FOR [Price]
GO

ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_ProductFeatured]  DEFAULT ((0)) FOR [ProductFeatured]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO

