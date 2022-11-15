/*Comando para poner la base de datos en uso o foco*/
USE BelloCenterDB;

GO

/*Creacion de tablas y relaciones*/

CREATE TABLE Tipos_doc(
id_tipo_doc int primary key identity,
nombre varchar(20) not null
)

GO

CREATE TABLE Cargos(
id_cargo int primary key identity,
nombre varchar(50) not null
)

GO

CREATE TABLE Clientes(
id_cliente int primary key identity,
nombre varchar(50) not null,
apellido varchar(50) not null,
id_doc int foreign key references Tipos_doc(id_tipo_doc) not null,
no_doc varchar(20) not null,
telefono varchar(20) null,
email varchar(60) null,
direccion varchar(100) null
)

GO

CREATE TABLE Empleados(
id_empleado int primary key identity,
nombre varchar(50) not null,
apellido varchar(50) not null,
edad int not null,
id_doc int foreign key references Tipos_doc(id_tipo_doc) not null,
no_doc varchar(20) not null,
telefono varchar(20) null,
email varchar(60) null,
direccion varchar(100) null,
id_cargo int foreign key references Cargos(id_cargo) not null,
)

GO

CREATE TABLE Usuarios(
id_usuario int primary key identity,
nombre_usuario varchar(50) unique,
clave nvarchar(30) not null,
tipo_usuario varchar(30) not null,
id_empleado int foreign key references Empleados(id_empleado)
)

GO

CREATE TABLE Proveedores(
id_proveedor int primary key identity,
nombre varchar(50) not null,
id_doc int foreign key references Tipos_doc(id_tipo_doc) not null,
no_doc varchar(20) not null,
telefono varchar(20) null,
email varchar(60) null,
direccion varchar(100) null
)

GO

CREATE TABLE Marcas(
id_marca int primary key identity,
nombre varchar(50) not null
)

GO

CREATE TABLE Categorias(
id_categorias int primary key identity,
nombre varchar(50) not null
)

GO

CREATE TABLE Articulos(
id_articulo int primary key identity,
nombre varchar(50) not null,
id_marca int foreign key references Marcas(id_marca) not null,
id_categoria int foreign key references Categorias(id_categorias) not null,
descripcion varchar(100) not null,
precio_compra money not null,
precio_venta money not null,
stock int not null
)

GO

CREATE TABLE Ventas(
id_venta int primary key identity,
id_cliente int foreign key references Clientes(id_cliente) not null,
id_empleado int foreign key references Empleados(id_empleado) not null,
condicion varchar(20) not null,
plazo varchar(20) not null,
fecha datetime not null,
fecha_venc date not null,
tol_sub_total numeric(18,2) not null,
tol_descuento numeric(18,2) not null,
tol_impuesto numeric(18,2) not null,
tol_total numeric(18,2) not null,
)

GO

CREATE TABLE Detalles_Ventas(
id_detalle_venta int primary key identity,
id_venta int foreign key references Ventas(id_venta) not null,
id_articulo int foreign key references Articulos(id_articulo) not null,
cantidad int not null,
precio numeric(18,2) not null,
descuento numeric(18,2) not null,
sub_total numeric(18,2) not null,
impuesto numeric(18,2) not null,
total numeric(18,2) not null,
)

GO

CREATE TABLE Compras(
id_compra int primary key identity,
id_empleado int foreign key references Empleados(id_empleado) not null,
id_proveedor int foreign key references Proveedores(id_proveedor) not null,
condicion varchar(20) not null,
plazo varchar(20) not null,
fecha datetime not null,
fecha_venc date not null,
tol_sub_total numeric(18,2) not null,
tol_descuento numeric(18,2) not null,
tol_impuesto numeric(18,2) not null,
tol_total numeric(18,2) not null,
)

GO

CREATE TABLE Detalles_Compras(
id_detalle_compra int primary key identity,
id_compra int foreign key references Compras(id_compra) not null,
id_articulo int foreign key references Articulos(id_articulo) not null,
cantidad int not null,
precio numeric(18,2) not null,
descuento numeric(18,2) not null,
sub_total numeric(18,2) not null,
impuesto numeric(18,2) not null,
total numeric(18,2) not null,
)

GO

CREATE TABLE Cotizaciones(
id_cotizacion int primary key identity,
id_cliente int foreign key references Clientes(id_cliente) not null,
id_empleado int foreign key references Empleados(id_empleado) not null,
condicion varchar(20) not null,
plazo varchar(20) not null,
fecha datetime not null,
fecha_venc date not null,
tol_sub_total numeric(18,2) not null,
tol_descuento numeric(18,2) not null,
tol_impuesto numeric(18,2) not null,
tol_total numeric(18,2) not null,
)

GO

CREATE TABLE Detalles_Cotizaciones(
id_detalle_cotizacion int primary key identity,
id_cotizacion int foreign key references Cotizaciones(id_cotizacion) not null,
id_articulo int foreign key references Articulos(id_articulo) not null,
cantidad int not null,
precio numeric(18,2) not null,
descuento numeric(18,2) not null,
sub_total numeric(18,2) not null,
impuesto numeric(18,2) not null,
total numeric(18,2) not null,
)

GO

CREATE TABLE Reparaciones(
id_reparacion int primary key identity,
id_cliente int foreign key references Clientes(id_cliente) not null,
id_empleado int foreign key references Empleados(id_empleado) not null,
fecha_entrada datetime not null,
fecha_salida datetime not null,
descripcion varchar(max) not null,
estado varchar(35) not null
)

GO

CREATE TABLE Facturas_Reparaciones(
id_factura_reparacion int primary key identity,
id_cliente int foreign key references Clientes(id_cliente) not null,
id_empleado int foreign key references Empleados(id_empleado) not null,
id_reparacion int foreign key references Reparaciones(id_reparacion) not null,
fecha datetime not null,
tol_sub_total numeric(18,2) not null,
tol_descuento numeric(18,2) not null,
tol_total numeric(18,2) not null,
)

GO

CREATE TABLE Detalles_Reparaciones(
id int primary key identity,
id_factura_reparacion int foreign key references Facturas_Reparaciones(id_factura_reparacion) not null,
articulo varchar(100) not null,
cantidad int not null,
descripcion varchar(max) not null,
precio numeric(18,2) not null,
descuento numeric(18,2) not null,
sub_total numeric(18,2) not null,
total numeric(18,2) not null,
)

/*Creacion de tablas y relaciones*/

GO

/*Creacion de procesos almacenados para interactuar con las tablas*/

/*----------------------------------------*/

CREATE PROC Log_in

@username varchar(30),
@password varchar(30)

AS

SELECT e.nombre,e.id_empleado, c.nombre as cargo FROM Empleados e, Cargos c, Usuarios u 
WHERE u.id_empleado = e.id_empleado and e.id_cargo = c.id_cargo 
and u.nombre_usuario = @username and CONVERT(nvarchar(MAX),DECRYPTBYPASSPHRASE('password',u.clave)) = @password

GO

CREATE PROC AddUser
@user varchar(50),
@pass nvarchar(30),
@tipo varchar(30),
@id_empleado int
AS
BEGIN
INSERT INTO Usuarios VALUES (@user,ENCRYPTBYPASSPHRASE('password',@pass),@tipo,@id_empleado)
END

GO

CREATE PROC UpdateUser
@id int,
@user varchar(50),
@pass varchar(12),
@tipo varchar(30)
AS

UPDATE Usuarios SET nombre_usuario = @user, clave = @pass, tipo_usuario = @tipo WHERE id_usuario = @id

GO

CREATE PROC DeleteUser
@id int
AS

DELETE FROM Usuarios WHERE id_usuario = @id

GO

CREATE PROC GetAllUsers

AS

SELECT * FROM Usuarios

/*----------------------------------------*/

GO

CREATE PROC AddTipoDoc
@name varchar(20)
AS

INSERT INTO Tipos_doc VALUES (@name) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateTipoDoc
@id int,
@name varchar(20)
AS

UPDATE Tipos_doc SET nombre = @name WHERE id_tipo_doc = @id

GO

CREATE PROC DeleteTipoDoc
@id int
AS

DELETE FROM Tipos_doc WHERE id_tipo_doc = @id

GO

CREATE PROC GetAllTipoDoc

AS

SELECT * FROM Tipos_doc

GO

/*----------------------------------------*/

CREATE PROC AddCargo
@name varchar(20)
AS

INSERT INTO Cargos VALUES (@name) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateCargo
@id int,
@name varchar(20)
AS

UPDATE Cargos SET nombre = @name WHERE id_cargo = @id

GO

CREATE PROC DeleteCargo
@id int
AS

DELETE FROM Cargos WHERE id_cargo = @id

GO

CREATE PROC GetAllCargos

AS

SELECT * FROM Cargos

GO

/*----------------------------------------*/

CREATE PROC AddCliente
@name varchar(50),
@lastname varchar(50),
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100)
AS

INSERT INTO Clientes VALUES(@name,@lastname,@iddoc,@nodoc,@phone,@email,@adress) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateCliente
@id int,
@name varchar(50),
@lastname varchar(50),
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100)
AS

UPDATE Clientes SET nombre= @name,apellido = @lastname,id_doc = @iddoc,no_doc = @nodoc,
telefono = @phone,email = @email,direccion = @adress WHERE id_cliente = @id

GO

CREATE PROC DeleteCliente
@id int
AS

DELETE FROM Clientes WHERE id_cliente = @id

GO

CREATE PROC GetAllClientes

AS

SELECT * FROM Clientes

GO

CREATE PROC GetByIdCliente
@id int
AS

SELECT * FROM Clientes WHERE id_cliente = @id

GO

CREATE PROC GetByValueCliente
@value varchar(50)
AS

SELECT * FROM Clientes WHERE Nombre LIKE '%' + @value + '%' or no_doc like '%' + @value + '%' ORDER BY Nombre

GO

/*----------------------------------------*/

CREATE PROC AddEmpleado
@name varchar(50),
@lastname varchar(50),
@age int,
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100),
@idcargo int
AS

INSERT INTO Empleados VALUES (@name,@lastname,@age,@iddoc,@nodoc,@phone,@email,@adress,@idcargo)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateEmpleado
@id int,
@name varchar(50),
@lastname varchar(50),
@age int,
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100),
@idcargo int
AS

UPDATE Empleados SET nombre = @name,apellido = @lastname,edad = @age,id_doc = @iddoc,
no_doc = @nodoc,telefono = @phone,email = @email,direccion = @adress,id_cargo = @idcargo
WHERE id_empleado = @id

GO

CREATE PROC DeleteEmpleado
@id int
AS

DELETE FROM Empleados WHERE id_empleado = @id

GO

CREATE PROC GetAllEmpleados

As

SELECT * FROM Empleados

GO

CREATE PROC GetByIdEmpleado
@id int
AS

SELECT * FROM Empleados WHERE id_empleado = @id

GO

CREATE PROC GetByValueEmpleado
@value varchar(50)
AS

SELECT * FROM Empleados WHERE Nombre LIKE '%' + @value + '%' or no_doc like '%' + @value + '%' ORDER BY Nombre

GO

/*----------------------------------------*/

CREATE PROC AddProveedor
@name varchar(50),
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100)
AS

INSERT INTO Proveedores VALUES(@name,@iddoc,@nodoc,@phone,@email,@adress) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateProveedor
@id int,
@name varchar(50),
@iddoc int,
@nodoc varchar(20),
@phone varchar(20),
@email varchar(60),
@adress varchar(100)
AS

UPDATE Proveedores SET nombre= @name,id_doc = @iddoc,no_doc = @nodoc,
telefono = @phone,email = @email,direccion = @adress WHERE id_proveedor = @id

GO

CREATE PROC DeleteProveedor
@id int
AS

DELETE FROM Proveedores WHERE id_proveedor = @id

GO

CREATE PROC GetAllProveedores

AS

SELECT * FROM Proveedores

GO

CREATE PROC GetByIdProveedor
@id int
AS

SELECT * FROM Proveedores WHERE id_proveedor = @id

GO

CREATE PROC GetByValueProveedor
@value varchar(50)
AS

SELECT * FROM Proveedores WHERE Nombre LIKE '%' + @value + '%' or no_doc like '%' + @value + '%' ORDER BY Nombre

GO

/*----------------------------------------*/

CREATE PROC AddMarca
@name varchar(20)
AS

INSERT INTO Marcas VALUES (@name) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateMarca
@id int,
@name varchar(20)
AS

UPDATE Marcas SET nombre = @name WHERE id_marca = @id

GO

CREATE PROC DeleteMarca
@id int
AS

DELETE FROM Marcas WHERE id_marca = @id

GO

CREATE PROC GetAllMarcas

AS

SELECT * FROM Marcas

GO

/*----------------------------------------*/

CREATE PROC AddCategoria
@name varchar(20)
AS

INSERT INTO Categorias VALUES (@name) SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateCategoria
@id int,
@name varchar(20)
AS

UPDATE Categorias SET nombre = @name WHERE id_categorias = @id

GO

CREATE PROC DeleteCategoria
@id int
AS

DELETE FROM Categorias WHERE id_categorias = @id

GO

CREATE PROC GetAllCategorias

AS

SELECT * FROM Categorias

GO

/*----------------------------------------*/

CREATE PROC AddArticulo
@name varchar(50),
@idmarca int,
@idcategoria int,
@description varchar(100),
@purchaseprice money,
@saleprice money,
@stock int
AS

INSERT INTO Articulos VALUES (@name,@idmarca,@idcategoria,@description,@purchaseprice,@saleprice,@stock)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateArticulo
@id int,
@name varchar(50),
@idmarca int,
@idcategoria int,
@description varchar(100),
@purchaseprice money,
@saleprice money,
@stock int
AS

UPDATE Articulos SET nombre = @name,id_marca = @idmarca,id_categoria = @idcategoria,
descripcion = @description,precio_compra = @purchaseprice,precio_venta = @saleprice,stock = @stock
WHERE id_articulo = @id

GO

CREATE PROC DeleteArticulo
@id int
AS

DELETE FROM Articulos WHERE id_articulo = @id

GO

CREATE PROC GetAllArticulos

AS

SELECT * FROM Articulos

GO

CREATE PROC GetByIdArticulo
@id int
AS

SELECT * FROM Articulos WHERE id_articulo = @id

GO

CREATE PROC GetByValueArticulo
@value varchar(50)
AS

SELECT * FROM Articulos WHERE Nombre LIKE '%' + @value + '%' or descripcion like '%' + @value + '%' ORDER BY Nombre

GO

/*----------------------------------------*/

CREATE PROC AddVenta
@idcliente int,
@idempleado int,
@condition varchar(20),
@term varchar(20),
@date datetime,
@expiration date,
@tolsub numeric(18,2),
@toldiscount numeric(18,2),
@tolimpo numeric(18,2),
@toltotal numeric(18,2)
AS

INSERT INTO Ventas VALUES (@idcliente,@idempleado,@condition,@term,@date,@expiration,@tolsub,@toldiscount,
@tolimpo,@toltotal) SELECT SCOPE_IDENTITY()

GO

CREATE PROC GetAllVentas

AS

SELECT * FROM Ventas

GO

CREATE PROC GetByIdVenta
@id int
AS

SELECT * FROM Ventas WHERE id_venta = @id

GO

/*----------------------------------------*/

CREATE PROC AddDetallesVentas
@idventa int,
@idarticulo int,
@cant int,
@price numeric(18,2),
@discount numeric(18,2),
@subtotal numeric(18,2),
@impo numeric(18,2),
@total numeric(18,2)
AS

INSERT INTO Detalles_Ventas VALUES (@idventa,@idarticulo,@cant,@price,@discount,@subtotal,@impo,@total)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC SelectDetallesVenta
@id int
AS

SELECT * FROM Detalles_Ventas WHERE id_venta = @id

GO

/*----------------------------------------*/

CREATE PROC AddCompra
@idempleado int,
@idproveedor int,
@condition varchar(20),
@term varchar(20),
@date datetime,
@expiration date,
@tolsub numeric(18,2),
@toldiscount numeric(18,2),
@tolimpo numeric(18,2),
@toltotal numeric(18,2)
AS

INSERT INTO Ventas VALUES (@idempleado,@idproveedor,@condition,@term,@date,@expiration,@tolsub,@toldiscount,
@tolimpo,@toltotal) SELECT SCOPE_IDENTITY()

GO

CREATE PROC GetAllCompras

AS

SELECT * FROM Compras

GO

CREATE PROC GetByIdCompra
@id int
AS

SELECT * FROM Compras WHERE id_compra = @id

GO

/*----------------------------------------*/

CREATE PROC AddDetallesCompras
@idcompra int,
@idarticulo int,
@cant int,
@price numeric(18,2),
@discount numeric(18,2),
@subtotal numeric(18,2),
@impo numeric(18,2),
@total numeric(18,2)
AS

INSERT INTO Detalles_Ventas VALUES (@idcompra,@idarticulo,@cant,@price,@discount,@subtotal,@impo,@total)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC SelectDetallesCompra
@id int
AS

SELECT * FROM Detalles_Compras WHERE id_compra = @id

GO

/*----------------------------------------*/

CREATE PROC AddCotizacion
@idcliente int,
@idempleado int,
@condition varchar(20),
@term varchar(20),
@date datetime,
@expiration date,
@tolsub numeric(18,2),
@toldiscount numeric(18,2),
@tolimpo numeric(18,2),
@toltotal numeric(18,2)
AS

INSERT INTO Cotizaciones VALUES (@idcliente,@idempleado,@condition,@term,@date,@expiration,@tolsub,@toldiscount,
@tolimpo,@toltotal) SELECT SCOPE_IDENTITY()

GO

CREATE PROC GetAllCotizaciones

AS

SELECT * FROM Cotizaciones

GO

CREATE PROC GetByIdCotizacion
@id int
AS

SELECT * FROM Cotizaciones WHERE id_cotizacion = @id

GO

/*----------------------------------------*/

CREATE PROC AddDetallesCotizacion
@idcotizacion int,
@idarticulo int,
@cant int,
@price numeric(18,2),
@discount numeric(18,2),
@subtotal numeric(18,2),
@impo numeric(18,2),
@total numeric(18,2)
AS

INSERT INTO Detalles_Ventas VALUES (@idcotizacion,@idarticulo,@cant,@price,@discount,@subtotal,@impo,@total)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC SelectDetallesCotizacion
@id int
AS

SELECT * FROM Detalles_Cotizaciones WHERE id_cotizacion = @id

GO

/*----------------------------------------*/

CREATE PROC AddReparacion
@idcliente int,
@idempleado int,
@enterdate datetime,
@outdate datetime,
@description varchar(max),
@status varchar(35)
AS

INSERT INTO Reparaciones VALUES (@idcliente,@idempleado,@enterdate,@outdate,@description,@status)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC UpdateEstadoReparacion
@id int,
@status varchar(20)
AS

UPDATE Reparaciones SET estado = @status WHERE id_reparacion = @id

GO

CREATE PROC GetAllReparaciones

AS

SELECT * FROM Reparaciones

GO

CREATE PROC GetByIdReparaciones
@id int
AS

SELECT * FROM Reparaciones WHERE id_reparacion = @id

GO

/*----------------------------------------*/

CREATE PROC AddFacturaReparacion
@idcliente int,
@idempleado int,
@idreparacion int,
@date datetime,
@toldiscount numeric(18,2),
@tolsub numeric(18,2),
@toltotal numeric(18,2)
AS

INSERT INTO Facturas_Reparaciones VALUES (@idcliente,@idempleado,@idreparacion,@date,@toldiscount,@tolsub,@toltotal)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC GetAllFacturasReparaciones

AS

SELECT * FROM Facturas_Reparaciones

GO

CREATE PROC GetByIdFacturasReparaciones
@id int
AS

SELECT * FROM Facturas_Reparaciones WHERE id_factura_reparacion = @id

GO

/*----------------------------------------*/

CREATE PROC AddDetallesReparaciones
@idfacturareparacion int,
@articulo varchar(100),
@cant int,
@description varchar(max),
@price numeric(18,2),
@discount numeric(18,2),
@subtotal numeric(18,2),
@total numeric(18,2)
AS

INSERT INTO Detalles_Reparaciones VALUES (@idfacturareparacion,@articulo,@cant,@description,
@price,@discount,@subtotal,@total)
SELECT SCOPE_IDENTITY()

GO

CREATE PROC SelectDetallesReparacion
@id int
AS

SELECT * FROM Detalles_Reparaciones WHERE id_factura_reparacion = @id

GO

/*----------------------------------------*/

/*Creacion de procesos almacenados para interactuar con las tablas*/

/*----------------------------------------*/

CREATE PROC Dashboard
@articulos int out,
@clientes int out,
@empleados int out,
@proveedores int out,
@ventas int out,
@compras int out,
@cotizaciones int out,
@reparaciones int out
AS

SET @articulos = (SELECT COUNT(id_articulo) AS articulos FROM Articulos)
SET @clientes = (SELECT COUNT(id_cliente) AS clientes FROM Clientes)
SET @empleados = (SELECT COUNT(id_empleado) AS empleados FROM Empleados)
SET @proveedores = (SELECT COUNT(id_proveedor) AS proveedores FROM Proveedores)
SET @ventas = (SELECT COUNT(id_venta) AS ventas FROM Ventas)
SET @compras = (SELECT COUNT(id_compra) AS compras FROM Compras)
SET @cotizaciones = (SELECT COUNT(id_cotizacion) AS cotizaciones FROM Cotizaciones)
SET @reparaciones = (SELECT COUNT(id_reparacion) AS reparaciones FROM Reparaciones)

GO

/*---------------------------------*/

CREATE PROC ArtPreferidos
AS

SELECT TOP 5 c.nombre+' '+c.nombre+' '+a.descripcion AS producto,COUNT(dv.id_articulo) AS cantidadventas from Detalles_Ventas dv
INNER JOIN Articulos a ON a.id_articulo = dv.id_articulo INNER JOIN Categorias c ON c.id_categorias = a.id_articulo
INNER JOIN Marcas m ON m.id_marca = a.id_marca GROUP BY dv.id_articulo,c.nombre,m.nombre,a.descripcion 
ORDER BY COUNT(2) DESC

GO

CREATE PROC ArtPorCategoria
AS

SELECT c.nombre, COUNT(id_categoria) AS cant FROM Articulos a INNER JOIN Categorias c
ON c.id_categorias = a.id_categoria GROUP BY a.id_categoria, c.nombre ORDER BY COUNT(2)