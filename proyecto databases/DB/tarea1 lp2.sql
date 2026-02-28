create database tarea;
go

use tarea;
go

create table categorias (
	categoriaId  int identity(1,1) not null primary key,
	Nombrecategoria varchar(50) not null
)

create table productos (
	Id int identity(1,1) not null primary key ,
	nombre varchar(100) not null,
	descripcion varchar(255) not null,
	precio decimal(10,2) not null,
	stock int not null default 0,
	categoriaID int not null,
	foreign key (categoriaID) references categorias(categoriaId)
);
create table clientes (
	clienteId int identity(1,1) not null primary key,
	NombreCompleto varchar(150) not null,
	CorreoElectronico varchar(100),
	Telefono varchar(15),
	direccion varchar(255)
);
create table facturas (
	facturaId int identity(1,1) not null primary key,
	clienteId int not null,
	FechaFactura date not null,
	total decimal(10,2) not null
	foreign key (clienteId) references clientes(clienteId)
);
create table DetallesFactura (
	DetalleID int identity(1,1) not null primary key,
	FacturaId int not null,
	ProductoId int not null,
	Cantidad int not null,
	Precio decimal(10,2) not null,
	Impuesto decimal(10,2) not null,
	Subtotal decimal(10,2) not null,
	foreign key(FacturaId) references facturas(facturaId),
	foreign key(ProductoId) references productos(Id)
);
create table Proveedores (
	ProveedorID int identity(1,1) not null primary key,
	NombreProveedor varchar(100) not null,
	Telefono varchar(15),
	CorreoElectronico varchar(100)
);
create table Compras (
	CompraID int identity(1,1) not null primary key,
	proveedorID int not null,
	FechaCompra date not null,
	Total decimal(10,2) not null
);
create table DetallesCompra (
	DetalleCompraID int identity(1,1) not null primary key,
	CompraID int not null,
	ProductoID int not null,
	Cantidad int not null,
	CostoUnitario decimal(10,2) not null,
	Impuesto decimal(10,2) not null,
	Subtotal decimal(10,2) not null,
	foreign key(CompraID) references Compras(CompraID),
	foreign key(productoID) references productos(Id)
);
insert into categorias (Nombrecategoria) values
('Embutidos'),
('Lacteos'),
('Productos de limpieza'),
('Bebidas');
--separacion
insert into productos (nombre,descripcion,precio,stock,categoriaID) values
('Salami','Salami induveca 1.47 Lb',224,200,1),
('Chuleta','Chuleta ahumada 1 Lb',129,200,1),
('Queso','Queso gouda en lonjas 0.5 Lb',298,200,2),
('Leche','Leche descremada Rica 1 Lt',80,200,2),
('Yogurt','Yogurt griego Chobani',185,200,2),
('Mantequilla','Mantequilla La vaquita Rica 1 Lb',259,200,2),
('Suavizante','Suavizante Suavitel 850 Ml',324,200,3),
('Refresco','Coca Cola Zero Sin azucar 2 Lt',85,200,4),
('Jugo','Jugo De naranja 100% sin azucar añadida',149,200,4),
('Cerveza','Cerveza presidente lata regular 12 Oz',100,200,4);
--separacion
insert into Clientes (NombreCompleto, CorreoElectronico, Telefono, Direccion) values
('Charles De Gaulle', 'charles@email.com', '8091111111', 'Santo Domingo'),
('Ramon Salazar', 'ramon@email.com', '8092222222', 'Santiago'),
('Jesus Ortiz', 'jesus@email.com', '8093333333', 'La Vega'),
('Pedro Gonzalez', 'pedro@email.com', '8094444444', 'San Cristóbal'),
('Sean Combs', 'sean@email.com', '8095555555', 'Baní'),
('Leon Kennedy', 'leon@email.com', '8096666666', 'Higüey');
--separacion
insert into Facturas (ClienteId, FechaFactura, Total) values
(1,GETDATE(),329),
(2,getdate(),448),
(3,getdate(),444),
(4, GETDATE(), 324),
(5, GETDATE(), 334),
(6, GETDATE(), 180);
INSERT INTO DetallesFactura (FacturaId, ProductoId, Cantidad, Precio, Impuesto, Subtotal) VALUES
(1, 4, 1, 80, 0, 80),
(1, 9, 1, 149, 0, 149),
(1, 10, 1, 100, 0, 100),
(2, 1, 2, 224, 0, 448),
(3, 5, 1, 185, 0, 185),
(3, 6, 1, 259, 0, 259),
(4, 7, 1, 324, 0, 324),
(5, 8, 1, 85, 0, 85),
(5, 9, 1, 149, 0, 149),
(5, 10, 1, 100, 0, 100),
(6, 4, 1, 80, 0, 80),
(6, 10, 1, 100, 0, 100);
INSERT INTO Proveedores (NombreProveedor, Telefono, CorreoElectronico) VALUES
('Rica', '8097771111', 'Rica@email.com'),
('Bepensa', '8097772222', 'Bepensa@email.com'),
('Grupo SID', '8097773333', 'GrupoSID@email.com'),
('CND', '8097774444', 'CND@email.com'),
('Productos Sosua', '8097775555', 'Sosua@email.com');
INSERT INTO Compras (ProveedorID, FechaCompra, Total) VALUES
(1,GETDATE(),10000),
(2,getdate(),10000),
(3,GETDATE(),40000),
(4,getdate(),16000),
(5,GETDATE(),45000);
INSERT INTO DetallesCompra (CompraID, ProductoID, Cantidad, CostoUnitario, Impuesto, Subtotal) VALUES
(1, 4, 50, 80, 720, 4000),     
(1, 5, 20, 185, 666, 3700),    
(1, 6, 10, 259, 466, 2590),   
(1, 4, 30, 80, 432, 2400),  
(2, 8, 40, 85, 612, 3400),    
(2, 9, 20, 149, 536, 2980),   
(2, 10, 20, 100, 360, 2000),   
(2, 8, 10, 85, 153, 850),     
(3, 1, 50, 224, 2016, 11200),  
(3, 2, 40, 129, 928, 5160),   
(3, 1, 30, 224, 1209, 6720),   
(3, 2, 20, 129, 464, 2580),    
(4, 10, 60, 100, 1080, 6000),  
(4, 8, 40, 85, 612, 3400),     
(4, 9, 30, 149, 804, 4470),   
(4, 7, 5, 324, 292, 1620),     
(5, 3, 40, 298, 2146, 11920), 
(5, 3, 30, 298, 1609, 8940),  
(5, 3, 20, 298, 1073, 5960),   
(5, 3, 10, 298, 536, 2980);  

Select id,nombre,stock from productos where stock <=5;
Select id,nombre,categoriaID,stock,precio from productos where categoriaID=1
Select facturaid, clienteId , FechaFactura, total from facturas where facturaId=1
Update productos
set precio = precio*1.10 where categoriaID=2;
update clientes
set direccion='Elias piña' where clienteId=5
update productos
set precio=300 where Id=6