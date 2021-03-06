USE [VETERINARIA]
GO
/****** Object:  Table [dbo].[ANIMAL]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANIMAL](
	[IDANIMAL] [int] IDENTITY(1,1) NOT NULL,
	[NOMBREANM] [varchar](20) NOT NULL,
	[IDTIPO] [int] NOT NULL,
	[IDRAZA] [int] NOT NULL,
	[EDAD] [int] NOT NULL,
	[NOMBREPRO] [varchar](50) NOT NULL,
	[DIRECCION] [varchar](50) NOT NULL,
	[TELEFONO] [varchar](12) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDANIMAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARGOS]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARGOS](
	[IDCARGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRECAR] [varchar](20) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
 CONSTRAINT [PK_CARGOS] PRIMARY KEY CLUSTERED 
(
	[IDCARGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIA_FACTURA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA_FACTURA](
	[IDCATEGIRIAFAC] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRCATE] [varchar](50) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCATEGIRIAFAC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CIUDAD]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CIUDAD](
	[IDCIUDAD] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRECIU] [varchar](20) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCIUDAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[IDECLIENTE] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRECLI] [varchar](30) NOT NULL,
	[APELLIDOCLI] [varchar](20) NOT NULL,
	[CEDULACLI] [varchar](1) NOT NULL,
	[DIRECCION] [varchar](50) NOT NULL,
	[IDCIUDAD] [int] NOT NULL,
	[TELEFONOCLI] [varchar](12) NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDECLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COTIZACION]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COTIZACION](
	[IDCOTIZACION] [int] IDENTITY(1,1) NOT NULL,
	[FECHA] [date] NOT NULL,
	[IDEMPLEADO] [int] NOT NULL,
	[IDCLIENTE] [int] NOT NULL,
	[IDPRODUCTO] [int] NOT NULL,
	[NOMBREPRO] [varchar](30) NOT NULL,
	[IDTIPOPRO] [int] NOT NULL,
	[DESCRIPCIONPRO] [varchar](50) NOT NULL,
	[PRECIOPRO] [int] NOT NULL,
	[CATIDAD] [int] NOT NULL,
	[DESCUENTO] [int] NULL,
	[SUBTOTAL] [int] NULL,
	[TOTAL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCOTIZACION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[IDEMPLEADO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBREEMP] [varchar](30) NOT NULL,
	[APELLIDOEMP] [varchar](20) NOT NULL,
	[IDUSUARIO] [int] NOT NULL,
	[NOMBREUSU] [varchar](20) NOT NULL,
	[CONTRASEÑAUSU] [varchar](4) NOT NULL,
	[IDCARGO] [int] NOT NULL,
	[NOMBRECAR] [varchar](20) NOT NULL,
	[SUELDO] [int] NOT NULL,
	[DIRECCIONEMP] [varchar](50) NOT NULL,
	[IDCIUDAD] [int] NOT NULL,
	[TELEFONO] [varchar](12) NULL,
	[CEDULAEMP] [varchar](50) NOT NULL,
	[CORREOEMP] [varchar](60) NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[IDFACTURA] [int] IDENTITY(1,1) NOT NULL,
	[IDCATEGORIA] [int] NOT NULL,
	[FECHA] [date] NOT NULL,
	[IDTIPOFAC] [int] NOT NULL,
	[IDEMPLEADO] [int] NOT NULL,
	[IDCLIENTE] [int] NOT NULL,
	[IDPRODUCTO] [int] NOT NULL,
	[NOMBREPRO] [varchar](30) NOT NULL,
	[IDTIPOPRO] [int] NOT NULL,
	[DESCRIPCIONPRO] [varchar](50) NOT NULL,
	[PRECIOPRO] [int] NOT NULL,
	[CATIDAD] [int] NOT NULL,
	[DESCUENTO] [int] NULL,
	[SUBTOTAL] [int] NULL,
	[TOTAL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFACTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_DETALLE]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_DETALLE](
	[IDDETALLE] [int] IDENTITY(1,1) NOT NULL,
	[IDFACTURA] [int] NOT NULL,
	[IDCATEGORIA] [int] NOT NULL,
	[FECHA] [date] NOT NULL,
	[IDTIPOFAC] [int] NOT NULL,
	[IDEMPLEADO] [int] NOT NULL,
	[IDCLIENTE] [int] NOT NULL,
	[IDPRODUCTO] [int] NOT NULL,
	[NOMBREPRO] [varchar](30) NOT NULL,
	[IDTIPOPRO] [int] NOT NULL,
	[DESCRIPCIONPRO] [varchar](50) NOT NULL,
	[PRECIOPRO] [int] NOT NULL,
	[CATIDAD] [int] NOT NULL,
	[DESCUENTO] [int] NULL,
	[SUBTOTAL] [int] NULL,
	[TOTAL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDETALLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIAL_RECETA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIAL_RECETA](
	[IDHIST] [int] IDENTITY(1,1) NOT NULL,
	[IDRECETA] [int] NOT NULL,
	[IDANIMAL] [int] NOT NULL,
	[NOMBREANM] [varchar](50) NOT NULL,
	[IDDUEÑO] [int] NOT NULL,
	[FECHA] [date] NOT NULL,
	[DIAGNOSTICO] [varchar](100) NOT NULL,
	[HORA] [time](7) NOT NULL,
	[TRATAMIENTO] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHIST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[IDPRODUCTO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBREPRO] [varchar](30) NOT NULL,
	[IDTIPOPRO] [int] NOT NULL,
	[DESCRIPCIONPRO] [varchar](50) NOT NULL,
	[IDPROVEEDOR] [int] NOT NULL,
	[COSTOPRO] [int] NOT NULL,
	[PRECIOPRO] [int] NOT NULL,
	[CANTIDADPRO] [int] NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPRODUCTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[IDPROVEEDOR] [int] IDENTITY(1,1) NOT NULL,
	[NOMBREPROV] [varchar](50) NOT NULL,
	[DIRECCION] [varchar](50) NOT NULL,
	[IDTIPOPROV] [int] NOT NULL,
	[TEELFONOPROV] [varchar](12) NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPROVEEDOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RAZA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RAZA](
	[IDRAZA] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRERAZA] [varchar](20) NOT NULL,
	[IDTIPOANM] [int] NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRAZA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECETA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECETA](
	[IDRECETA] [int] IDENTITY(1,1) NOT NULL,
	[IDANIMAL] [int] NOT NULL,
	[NOMBREANM] [varchar](20) NOT NULL,
	[IDTIPO] [int] NOT NULL,
	[IDRAZA] [int] NOT NULL,
	[EDAD] [int] NOT NULL,
	[PADECIMIENTO] [varchar](100) NOT NULL,
	[PRODUCTOIND] [varchar](30) NOT NULL,
	[DOSIS] [varchar](100) NOT NULL,
	[PERSONARES] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRECETA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_ANIMAL]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_ANIMAL](
	[IDTIPOANM] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRETIPANM] [varchar](50) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTIPOANM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_FACTURA]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_FACTURA](
	[IDTIPOFACT] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRETIPFAC] [varchar](30) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTIPOFACT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_PRODUCTO]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_PRODUCTO](
	[IDTIPOPRO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRETIPPRO] [varchar](50) NOT NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTIPOPRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 29/05/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IDUSUARIO] [int] IDENTITY(1,1) NOT NULL,
	[IDEMPLEADO] [int] NOT NULL,
	[NOMBREUSU] [varchar](50) NULL,
	[CONTRASEÑA] [varchar](4) NULL,
	[ESTATUS] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUSUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CARGOS] ON 

INSERT [dbo].[CARGOS] ([IDCARGO], [NOMBRECAR], [ESTATUS]) VALUES (1, N'VETERINARIO', N'A')
SET IDENTITY_INSERT [dbo].[CARGOS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__CLIENTE__B80D7D0A475A1F5A]    Script Date: 29/05/2021 20:55:29 ******/
ALTER TABLE [dbo].[CLIENTE] ADD UNIQUE NONCLUSTERED 
(
	[CEDULACLI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__EMPLEADO__B68101B1E93B5ADA]    Script Date: 29/05/2021 20:55:29 ******/
ALTER TABLE [dbo].[EMPLEADO] ADD UNIQUE NONCLUSTERED 
(
	[CEDULAEMP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ANIMAL] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[CARGOS] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[CATEGORIA_FACTURA] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[CIUDAD] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[CLIENTE] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[COTIZACION] ADD  DEFAULT ('0') FOR [DESCUENTO]
GO
ALTER TABLE [dbo].[EMPLEADO] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[FACTURA] ADD  DEFAULT ('0') FOR [DESCUENTO]
GO
ALTER TABLE [dbo].[FACTURA_DETALLE] ADD  DEFAULT ('0') FOR [DESCUENTO]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[PROVEEDOR] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[RAZA] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[TIPO_ANIMAL] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[TIPO_FACTURA] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[TIPO_PRODUCTO] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ('A') FOR [ESTATUS]
GO
ALTER TABLE [dbo].[ANIMAL]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAL_RAZA] FOREIGN KEY([IDRAZA])
REFERENCES [dbo].[RAZA] ([IDRAZA])
GO
ALTER TABLE [dbo].[ANIMAL] CHECK CONSTRAINT [FK_ANIMAL_RAZA]
GO
ALTER TABLE [dbo].[ANIMAL]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAL_TIPO_ANIMAL] FOREIGN KEY([IDTIPO])
REFERENCES [dbo].[TIPO_ANIMAL] ([IDTIPOANM])
GO
ALTER TABLE [dbo].[ANIMAL] CHECK CONSTRAINT [FK_ANIMAL_TIPO_ANIMAL]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_CIUDAD] FOREIGN KEY([IDCIUDAD])
REFERENCES [dbo].[CIUDAD] ([IDCIUDAD])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_CIUDAD]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_CLIENTE] FOREIGN KEY([IDCLIENTE])
REFERENCES [dbo].[CLIENTE] ([IDECLIENTE])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [FK_COTIZACION_CLIENTE]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_EMPLEADO] FOREIGN KEY([IDEMPLEADO])
REFERENCES [dbo].[EMPLEADO] ([IDEMPLEADO])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [FK_COTIZACION_EMPLEADO]
GO
ALTER TABLE [dbo].[COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_PRODUCTO] FOREIGN KEY([IDPRODUCTO])
REFERENCES [dbo].[PRODUCTO] ([IDPRODUCTO])
GO
ALTER TABLE [dbo].[COTIZACION] CHECK CONSTRAINT [FK_COTIZACION_PRODUCTO]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_CARGOS] FOREIGN KEY([IDCARGO])
REFERENCES [dbo].[CARGOS] ([IDCARGO])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [FK_EMPLEADO_CARGOS]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_CIUDAD] FOREIGN KEY([IDCIUDAD])
REFERENCES [dbo].[CIUDAD] ([IDCIUDAD])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [FK_EMPLEADO_CIUDAD]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CATEGORIA_FACTURA] FOREIGN KEY([IDCATEGORIA])
REFERENCES [dbo].[CATEGORIA_FACTURA] ([IDCATEGIRIAFAC])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_CATEGORIA_FACTURA]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CLIENTE] FOREIGN KEY([IDCLIENTE])
REFERENCES [dbo].[CLIENTE] ([IDECLIENTE])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_CLIENTE]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_EMPLEADO] FOREIGN KEY([IDEMPLEADO])
REFERENCES [dbo].[EMPLEADO] ([IDEMPLEADO])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_EMPLEADO]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_PRODUCTO] FOREIGN KEY([IDPRODUCTO])
REFERENCES [dbo].[PRODUCTO] ([IDPRODUCTO])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_PRODUCTO]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_TIPO_FACTURA] FOREIGN KEY([IDTIPOFAC])
REFERENCES [dbo].[TIPO_FACTURA] ([IDTIPOFACT])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_TIPO_FACTURA]
GO
ALTER TABLE [dbo].[FACTURA_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_DETALLE_FACTURA] FOREIGN KEY([IDDETALLE])
REFERENCES [dbo].[FACTURA] ([IDFACTURA])
GO
ALTER TABLE [dbo].[FACTURA_DETALLE] CHECK CONSTRAINT [FK_FACTURA_DETALLE_FACTURA]
GO
ALTER TABLE [dbo].[HISTORIAL_RECETA]  WITH CHECK ADD  CONSTRAINT [FK_HISTORIAL_RECETA_RECETA] FOREIGN KEY([IDRECETA])
REFERENCES [dbo].[RECETA] ([IDRECETA])
GO
ALTER TABLE [dbo].[HISTORIAL_RECETA] CHECK CONSTRAINT [FK_HISTORIAL_RECETA_RECETA]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_PROVEEDOR] FOREIGN KEY([IDPROVEEDOR])
REFERENCES [dbo].[PROVEEDOR] ([IDPROVEEDOR])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [FK_PRODUCTO_PROVEEDOR]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_TIPO_PRODUCTO] FOREIGN KEY([IDTIPOPRO])
REFERENCES [dbo].[TIPO_PRODUCTO] ([IDTIPOPRO])
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [FK_PRODUCTO_TIPO_PRODUCTO]
GO
ALTER TABLE [dbo].[RAZA]  WITH CHECK ADD  CONSTRAINT [FK_RAZA_TIPO_ANIMAL] FOREIGN KEY([IDTIPOANM])
REFERENCES [dbo].[TIPO_ANIMAL] ([IDTIPOANM])
GO
ALTER TABLE [dbo].[RAZA] CHECK CONSTRAINT [FK_RAZA_TIPO_ANIMAL]
GO
ALTER TABLE [dbo].[RECETA]  WITH CHECK ADD  CONSTRAINT [FK_RECETA_ANIMAL] FOREIGN KEY([IDANIMAL])
REFERENCES [dbo].[ANIMAL] ([IDANIMAL])
GO
ALTER TABLE [dbo].[RECETA] CHECK CONSTRAINT [FK_RECETA_ANIMAL]
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_EMPLEADO] FOREIGN KEY([IDEMPLEADO])
REFERENCES [dbo].[EMPLEADO] ([IDEMPLEADO])
GO
ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [FK_USUARIO_EMPLEADO]
GO
