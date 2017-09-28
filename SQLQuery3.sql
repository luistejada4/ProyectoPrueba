--CREATE TABLE [dbo].[Articulos](
--	[Codigo] [int] IDENTITY(1,1) NOT NULL primary key,
--	[Descripcion] [varchar](60) NOT NULL,
--	[Costo] [money] NOT NULL,
--	[Ganancia] [money] NOT NULL,
--	[Precio] [money] NULL,
--	[Itbis] [float] NOT NULL,
--	[Existencia] [int] NOT NULL)

CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [varchar](60) NOT NULL,
	[Direccion] [varchar](120) NULL)


CREATE TABLE [dbo].[Pedidos](
	[Codigo] [int] IDENTITY(1,1) NOT NULL primary key,
	[ClienteCodigo] [int] NOT NULL FOREIGN KEY references Clientes,
	[Fecha] [date] NULL)

	CREATE TABLE [dbo].[Items](
	[Codigo] [int] IDENTITY(1,1) NOT NULL primary key,
	[CodigoPedido] [int] NULL FOREIGN KEY references Pedidos,
	[CodigoArticulo] [int] NULL FOREIGN KEY references Articulos,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Itbis] [money] NULL)
