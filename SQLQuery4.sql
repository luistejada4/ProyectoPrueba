CREATE TABLE [dbo].[Articulos](
	[Codigo] [int] IDENTITY(1,1) primary key,
	[Descripcion] [varchar](60),
	[Costo] [money],
	[Ganancia] [money],
	[Precio] [money],
	[Itbis] [float],
	[Existencia] [int],)

CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] IDENTITY(1,1) primary key,
	[Nombre] [varchar](60),
	[Direccion] [varchar](120))


CREATE TABLE [dbo].[Pedidos](
	[Codigo] [int] IDENTITY(1,1) primary key,
	[ClienteCodigo] [int] NOT NULL FOREIGN KEY references Clientes,
	[Fecha] [date] )

	CREATE TABLE [dbo].[Items](
	[Codigo] [int] IDENTITY(1,1) primary key,
	[CodigoPedido] [int] NULL FOREIGN KEY references Pedidos,
	[CodigoArticulo] [int] NULL FOREIGN KEY references Articulos,
	[Precio] [money] ,
	[Cantidad] [int] ,
	[Itbis] [money] )


