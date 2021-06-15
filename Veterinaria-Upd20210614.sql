
USE [Veterinaria]
GO
/****** Object:  Table [dbo].[Animales]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[TipoID] [int] NOT NULL,
	[RazaID] [int] NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Inactivo] [bit] NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK__ANIMAL__2F74DE09CD744E5B] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_CARGOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria_Factura]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Factura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__CATEGORI__CB993CBC2AEBA799] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__CIUDAD__13A4F5219068B971] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellidos] [varchar](20) NOT NULL,
	[Cedula] [varchar](11) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[CiudadID] [int] NOT NULL,
	[Telefono] [varchar](12) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__CLIENTE__93706688C1449A9E] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizaciones]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizaciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[ClienteID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[TipoProductoID] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descuento] [decimal](18, 2) NULL,
	[SubTotal] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__COTIZACI__104F13633C2B72CA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellidos] [varchar](20) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[CargoId] [int] NOT NULL,
	[Sueldo] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[CiudadID] [int] NOT NULL,
	[Telefono] [varchar](12) NULL,
	[Cedula] [varchar](50) NOT NULL,
	[Correo] [varchar](60) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__EMPLEADO__E014C3162C959F3F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[TipoFacturaID] [int] NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[ClienteID] [int] NOT NULL,
	[DescuentoTotal] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__FACTURA__F7D4C9C7FF960832] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas_Detalle]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas_Detalle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FacturasID] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[TipoProductoId] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__FACTURA___A1AC0F64DB98CE63] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial_Recetas]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Recetas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RecetaId] [int] NOT NULL,
	[AnimalId] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Diagnostico] [varchar](100) NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Tratamiento] [varchar](50) NOT NULL,
	[Inactivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[TipoProductoId] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[ProveedorId] [int] NOT NULL,
	[Costo] [decimal](18, 2) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__PRODUCTO__7D8DC0F1FB65C88C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Dirección] [varchar](50) NOT NULL,
	[TipoProveedorID] [int] NOT NULL,
	[Telefono] [varchar](12) NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__PROVEEDO__4EB245E407A530BA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[TipoAnimalId] [int] NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__RAZA__973763B898D4F2D1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receta]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AnimalID] [int] NOT NULL,
	[TipoAnimalId] [int] NOT NULL,
	[RazaID] [int] NOT NULL,
	[Padecimiento] [varchar](100) NOT NULL,
	[ProductoId] [varchar](30) NOT NULL,
	[Dosis] [varchar](100) NOT NULL,
	[Personales] [varchar](30) NULL,
	[Inactivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Animal]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__TIPO_ANI__1ADD8C1AC8FAD393] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Factura]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Factura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__TIPO_FAC__BFE6368D68BE0AFA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Producto]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__TIPO_PRO__251D59B5363E3417] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/06/2021 9:32:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasena] [varchar](4) NOT NULL,
	[Inactivo] [bit] NOT NULL,
 CONSTRAINT [PK__USUARIO__98242AA9C7817574] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Animales] ON 
GO
INSERT [dbo].[Animales] ([ID], [Nombre], [TipoID], [RazaID], [Edad], [Direccion], [Inactivo], [ClienteId]) VALUES (1, N'Perla', 1, 1, 5, N'3ra 4', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Animales] OFF
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 
GO
INSERT [dbo].[Cargos] ([ID], [Nombre], [Inactivo]) VALUES (1, N'VETERINARIO', 0)
GO
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
SET IDENTITY_INSERT [dbo].[Ciudad] ON 
GO
INSERT [dbo].[Ciudad] ([ID], [Nombre], [Inactivo]) VALUES (1, N'Santo Domingo', 0)
GO
INSERT [dbo].[Ciudad] ([ID], [Nombre], [Inactivo]) VALUES (2, N'Santiago', 0)
GO
INSERT [dbo].[Ciudad] ([ID], [Nombre], [Inactivo]) VALUES (3, N'La Vega', 0)
GO
SET IDENTITY_INSERT [dbo].[Ciudad] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellidos], [Cedula], [Direccion], [CiudadID], [Telefono], [Inactivo]) VALUES (1, N'Cesar', N'Delgado', N'11100022233', N'3ra 4', 1, N'8098644121', 0)
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [TipoProductoId], [Descripcion], [ProveedorId], [Costo], [Precio], [Cantidad], [Inactivo]) VALUES (1, N'Vitamina B', 1, N'Vitamina B', 2, CAST(5.50 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 8, 0)
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [TipoProductoId], [Descripcion], [ProveedorId], [Costo], [Precio], [Cantidad], [Inactivo]) VALUES (3, N'Vitamina D', 1, N'Vitamina D', 2, CAST(2.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 100, 0)
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [TipoProductoId], [Descripcion], [ProveedorId], [Costo], [Precio], [Cantidad], [Inactivo]) VALUES (4, N'Vitamina K', 1, N'Potasio', 2, CAST(5.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), 100, 0)
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [TipoProductoId], [Descripcion], [ProveedorId], [Costo], [Precio], [Cantidad], [Inactivo]) VALUES (5, N'Vitamina A', 1, N'Vitamina A', 2, CAST(1.50 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 50, 0)
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [TipoProductoId], [Descripcion], [ProveedorId], [Costo], [Precio], [Cantidad], [Inactivo]) VALUES (1002, N'Zinc', 1, N'Minerales', 2, CAST(5.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 100, 0)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Dirección], [TipoProveedorID], [Telefono], [Inactivo]) VALUES (2, N'Sanut', N'Autopista Duarte', 1, N'8098882222', 0)
GO
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Dirección], [TipoProveedorID], [Telefono], [Inactivo]) VALUES (3, N'Ceconsa', N'Av Romulo, Bella Vista', 1, N'8095550000', 0)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Raza] ON 
GO
INSERT [dbo].[Raza] ([Id], [Nombre], [TipoAnimalId], [Inactivo]) VALUES (1, N'Chiguagua', 1, 0)
GO
INSERT [dbo].[Raza] ([Id], [Nombre], [TipoAnimalId], [Inactivo]) VALUES (2, N'Pastor Aleman', 1, 0)
GO
INSERT [dbo].[Raza] ([Id], [Nombre], [TipoAnimalId], [Inactivo]) VALUES (3, N'Persa', 2, 0)
GO
INSERT [dbo].[Raza] ([Id], [Nombre], [TipoAnimalId], [Inactivo]) VALUES (4, N'Angora', 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Raza] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Animal] ON 
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (1, N'Perro', 0)
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (2, N'Gato', 0)
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (3, N'Chivo', 0)
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (4, N'Vaca', 0)
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (5, N'Caballo', 0)
GO
INSERT [dbo].[Tipo_Animal] ([Id], [Nombre], [Inactivo]) VALUES (6, N'Conejo', 0)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Animal] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Producto] ON 
GO
INSERT [dbo].[Tipo_Producto] ([Id], [Nombre], [Inactivo]) VALUES (1, N'Vitaminas', 1)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Producto] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__CLIENTE__B80D7D0A1170C853]    Script Date: 14/06/2021 9:32:13 PM ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [UQ__CLIENTE__B80D7D0A1170C853] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__EMPLEADO__B68101B1D2449CC1]    Script Date: 14/06/2021 9:32:13 PM ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [UQ__EMPLEADO__B68101B1D2449CC1] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Animales] ADD  CONSTRAINT [DF__ANIMAL__ESTATUS__5070F446]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Cargos] ADD  CONSTRAINT [DF__CARGOS__ESTATUS__5165187F]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Categoria_Factura] ADD  CONSTRAINT [DF__CATEGORIA__ESTAT__52593CB8]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Ciudad] ADD  CONSTRAINT [DF__CIUDAD__ESTATUS__534D60F1]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF__CLIENTE__ESTATUS__5441852A]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Cotizaciones] ADD  CONSTRAINT [DF__COTIZACIO__DESCU__5535A963]  DEFAULT ('0') FOR [Descuento]
GO
ALTER TABLE [dbo].[Cotizaciones] ADD  CONSTRAINT [DF_Cotizaciones_Inactiva]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF__EMPLEADO__ESTATU__5629CD9C]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF__FACTURA__DESCUEN__571DF1D5]  DEFAULT ((0)) FOR [DescuentoTotal]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF_Facturas_SubTotal]  DEFAULT ((0)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF_Facturas_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF_Facturas_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Facturas_Detalle] ADD  CONSTRAINT [DF__FACTURA_D__DESCU__5812160E]  DEFAULT ((0)) FOR [Descuento]
GO
ALTER TABLE [dbo].[Facturas_Detalle] ADD  CONSTRAINT [DF_FACTURA_DETALLE_SubTotal]  DEFAULT ((0)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Facturas_Detalle] ADD  CONSTRAINT [DF_FACTURA_DETALLE_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Facturas_Detalle] ADD  CONSTRAINT [DF_Facturas_Detalle_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Historial_Recetas] ADD  CONSTRAINT [DF_Historial_Recetas_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF__PRODUCTO__ESTATU__59063A47]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Proveedor] ADD  CONSTRAINT [DF__PROVEEDOR__ESTAT__59FA5E80]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Raza] ADD  CONSTRAINT [DF__RAZA__ESTATUS__5AEE82B9]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Receta] ADD  CONSTRAINT [DF_Receta_Inactivo]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Tipo_Animal] ADD  CONSTRAINT [DF__TIPO_ANIM__ESTAT__5BE2A6F2]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Tipo_Factura] ADD  CONSTRAINT [DF__TIPO_FACT__ESTAT__5CD6CB2B]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Tipo_Producto] ADD  CONSTRAINT [DF__TIPO_PROD__ESTAT__5DCAEF64]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF__USUARIO__ESTATUS__5EBF139D]  DEFAULT ((0)) FOR [Inactivo]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [Clientes_Animales] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([ID])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [Clientes_Animales]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAL_RAZA] FOREIGN KEY([RazaID])
REFERENCES [dbo].[Raza] ([Id])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_ANIMAL_RAZA]
GO
ALTER TABLE [dbo].[Animales]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAL_TIPO_ANIMAL] FOREIGN KEY([TipoID])
REFERENCES [dbo].[Tipo_Animal] ([Id])
GO
ALTER TABLE [dbo].[Animales] CHECK CONSTRAINT [FK_ANIMAL_TIPO_ANIMAL]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_CIUDAD] FOREIGN KEY([CiudadID])
REFERENCES [dbo].[Ciudad] ([ID])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_CLIENTE_CIUDAD]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_CLIENTE] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ID])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_COTIZACION_CLIENTE]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_EMPLEADO] FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([ID])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_COTIZACION_EMPLEADO]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_COTIZACION_PRODUCTO] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([Id])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_COTIZACION_PRODUCTO]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_CARGOS] FOREIGN KEY([CargoId])
REFERENCES [dbo].[Cargos] ([ID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_EMPLEADO_CARGOS]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_CIUDAD] FOREIGN KEY([CiudadID])
REFERENCES [dbo].[Ciudad] ([ID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_EMPLEADO_CIUDAD]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CATEGORIA_FACTURA] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categoria_Factura] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FACTURA_CATEGORIA_FACTURA]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CLIENTE] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FACTURA_CLIENTE]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_EMPLEADO] FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FACTURA_EMPLEADO]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_TIPO_FACTURA] FOREIGN KEY([TipoFacturaID])
REFERENCES [dbo].[Tipo_Factura] ([Id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FACTURA_TIPO_FACTURA]
GO
ALTER TABLE [dbo].[Facturas_Detalle]  WITH CHECK ADD  CONSTRAINT [Facturas_Facturas_Detalle] FOREIGN KEY([FacturasID])
REFERENCES [dbo].[Facturas] ([ID])
GO
ALTER TABLE [dbo].[Facturas_Detalle] CHECK CONSTRAINT [Facturas_Facturas_Detalle]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_PROVEEDOR] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[Proveedor] ([ID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_PRODUCTO_PROVEEDOR]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_TIPO_PRODUCTO] FOREIGN KEY([TipoProductoId])
REFERENCES [dbo].[Tipo_Producto] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_PRODUCTO_TIPO_PRODUCTO]
GO
ALTER TABLE [dbo].[Raza]  WITH CHECK ADD  CONSTRAINT [FK_RAZA_TIPO_ANIMAL] FOREIGN KEY([TipoAnimalId])
REFERENCES [dbo].[Tipo_Animal] ([Id])
GO
ALTER TABLE [dbo].[Raza] CHECK CONSTRAINT [FK_RAZA_TIPO_ANIMAL]
GO
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD  CONSTRAINT [FK_RECETA_ANIMAL] FOREIGN KEY([AnimalID])
REFERENCES [dbo].[Animales] ([ID])
GO
ALTER TABLE [dbo].[Receta] CHECK CONSTRAINT [FK_RECETA_ANIMAL]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_EMPLEADO] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleados] ([ID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_USUARIO_EMPLEADO]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
