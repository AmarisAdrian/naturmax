CREATE DATABASE BDORION;
USE BDORION;
---------------------/---------------/------------------/------------FACTURA--------------/----------------/-----------------------------------------/
GO  
CREATE TABLE CLIENTE(
NODOCUMENTO BIGINT PRIMARY KEY,
NOMBRES NVARCHAR (50),
APELLIDOS NVARCHAR(50),
DIRECCION NVARCHAR(50),
TELEFONO NVARCHAR(19),
CELULAR NVARCHAR(19),
);

GO
CREATE TABLE PROVEEDOR(
IDPROVEEDOR INT PRIMARY KEY,
NOMBRE NVARCHAR(50),
DIRECCION NVARCHAR(50),
TELEFONO NVARCHAR(20),
EMAIL NVARCHAR(45),
RUT NVARCHAR(50),
NOMBRECONTACTO NVARCHAR(50),
TELEFONOCONTACTO NVARCHAR(20),
EMAILCONTACTO NVARCHAR(45),
CIUDAD NVARCHAR(45),
DEPARTAMENTO NVARCHAR(45),
);

GO
CREATE TABLE CATEGORIA_PRODUCTO(
IDCATEGORIA INT PRIMARY KEY,
NOMBRE NVARCHAR(30),
);

GO 
CREATE TABLE MARCA
(
IDMARCA VARCHAR(20),
NOMBRE NVARCHAR(45),
PRIMARY KEY(IDMARCA),
);

GO
CREATE TABLE PRODUCTO(
IDPRODUCTO INT PRIMARY KEY,
IDPROVEEDOR INT,
IDCATEGORIA INT REFERENCES CATEGORIA_PRODUCTO(IDCATEGORIA),
CONSTRAINT FK_PRODUCTO FOREIGN KEY(IDPROVEEDOR) REFERENCES PROVEEDOR(IDPROVEEDOR),
FOREIGN KEY(IDMARCA) REFERENCES MARCA(IDMARCA),
IDMARCA VARCHAR(20),
DESCRIPCION NVARCHAR(100),
STOCK INT,
PRECIOUNITARIO  NVARCHAR(20),
PRECIOIVA  NVARCHAR(20),
);

GO
CREATE TABLE FACTURA(
NOFACTURA VARCHAR(20),
IDCLIENTE BIGINT ,
FOREIGN KEY(IDCLIENTE) REFERENCES CLIENTE(NODOCUMENTO),
IVA NVARCHAR(5),
SUBTOTAL DECIMAL(20),
TOTALPAGAR DECIMAL(20),
FECHA DATE,
PRIMARY KEY(NOFACTURA),
);

GO
CREATE TABLE DETALLEFACTURA
(
NOFACTURA VARCHAR(20) ,
IDPRODUCTO INT,
IDMARCA VARCHAR(20),
PRECIO  DECIMAL(20),
DESCUENTO INT,
CANTIDAD  NVARCHAR(20),
CONSTRAINT FK_DETALLE FOREIGN KEY(IDPRODUCTO) REFERENCES PRODUCTO(IDPRODUCTO),
FOREIGN KEY (NOFACTURA) REFERENCES FACTURA(NOFACTURA),
FOREIGN KEY(IDMARCA) REFERENCES MARCA(IDMARCA),
PRIMARY KEY (NOFACTURA,IDPRODUCTO),
);

GO 
CREATE TABLE CONTROLOPERADOR
(
IDCONTROL BIGINT PRIMARY KEY,
NODOCUMENTO BIGINT,
HORAINICIO TIME,
HORAFIN TIME,
FECHA DATE,
FOREIGN KEY(NODOCUMENTO) REFERENCES OPERADOR(NODOCUMENTO),
);

CREATE TABLE ERRORLOGS
(
NOFACTURA VARCHAR(20),
CONT INT  ,
FECHA DATE,
FOREIGN KEY (NOFACTURA) REFERENCES FACTURA(NOFACTURA),
PRIMARY KEY (NOFACTURA),
);

---------------------/---------------/------------------/------------OPERADORS--------------/----------------/-----------------------------------------/

GO  
CREATE TABLE TIPOUSUARIO(
ID INT PRIMARY KEY,
NOMBRE VARCHAR (20),
);

GO  
CREATE TABLE ESTADOUSUARIO(
ID INT PRIMARY KEY,
NOMBRE VARCHAR (20),
);

GO 
CREATE TABLE GENERO(
ID INT PRIMARY KEY,
NOMBRE VARCHAR(20),
);

GO
CREATE TABLE OPERADOR
(
NODOCUMENTO BIGINT PRIMARY KEY,
PASSWORD NVARCHAR(35),
NOMBRESOPERADOR NVARCHAR(30),
APELLIDOSOPERADOR NVARCHAR(30),
IDTIPOGENERO INT,
IDESTADO INT,
IDTIPOUSUARIO INT,
TELEFONOOPERADOR NVARCHAR(30),
MOVILOPERADOR NVARCHAR(30),
EMAILOPERADOR NVARCHAR(30),
CIUDADOPERADOR NVARCHAR(30),
DIRECCIONOPERADOR NVARCHAR(30),
FOTOPERADOR IMAGE,
FOREIGN KEY (IDTIPOGENERO) REFERENCES GENERO(ID),
FOREIGN KEY (IDTIPOUSUARIO) REFERENCES TIPOUSUARIO(ID),
FOREIGN KEY (IDESTADO) REFERENCES ESTADOUSUARIO(ID),
);

CREATE TABLE EMAIL
(
ID INT,
EMAIL VARCHAR(90),
PRIMARY KEY (ID) ,
CONSTRAINT UK_EMAIL_EMAIL UNIQUE(EMAIL)
);
--------------------------------//-----------------//------------------//--AUDITORIA ----------------------//-----------------------//---------//------------------------------------//
CREATE TABLE CAJA
(
IDCAJA VARCHAR(20),
NUMERO INT UNIQUE,
PRIMARY KEY (IDCAJA),
CONSTRAINT UK_CAJA_NUMERO UNIQUE(NUMERO)
);

CREATE TABLE ESTADOCAJA
(
ID INT,
NOMBRE VARCHAR(20),
PRIMARY KEY (ID)
);
CREATE TABLE REGISTROCAJA
(
IDREGISTRO BIGINT,
IDCAJA VARCHAR(20),
IDESTADO INT,
DOCUMENTO BIGINT,
FECHA DATE,
PRIMARY KEY(IDREGISTRO),
FOREIGN KEY (IDREGISTRO) REFERENCES REGISTROCAJA(IDREGISTRO),
FOREIGN KEY (DOCUMENTO) REFERENCES OPERADOR(NODOCUMENTO),
FOREIGN KEY (IDESTADO) REFERENCES ESTADOCAJA(ID),
);

CREATE TABLE ABRIRCAJA
(
IDREGISTRO BIGINT,
MONTOA DECIMAL,
MONTOI DECIMAL,
HORAI TIME,
PRIMARY KEY(IDREGISTRO),
FOREIGN KEY (IDREGISTRO) REFERENCES REGISTROCAJA(IDREGISTRO),
);

CREATE TABLE CERRARCAJA
(
IDREGISTRO BIGINT,
FACTURASG INT,
MONTOR DECIMAL,
HORAF TIME,
TOTAL DECIMAL,
PRIMARY KEY(IDREGISTRO),
FOREIGN KEY (IDREGISTRO) REFERENCES REGISTROCAJA(IDREGISTRO),
);

GO 
CREATE TABLE CONTROLFACTURA
(
NOFACTURA VARCHAR(20),
DOCUMENTO BIGINT ,
PC VARCHAR(20),
FOREIGN KEY(DOCUMENTO) REFERENCES OPERADOR(NODOCUMENTO),
FOREIGN KEY(PC) REFERENCES CAJA(IDCAJA),
FOREIGN KEY(NOFACTURA) REFERENCES FACTURA(NOFACTURA),
PRIMARY KEY (NOFACTURA),
);

-------------------------------------------------------------------------//-------------------------------------------//
GO 
CREATE TABLE OPERACION
(
ID INT ,
NOMBRE VARCHAR(30) NOT NULL,
CONSTRAINT PK_OPERACION PRIMARY KEY(ID),
CONSTRAINT UK_OPERACION_NOMBRE UNIQUE(NOMBRE),
);

GO
CREATE TABLE ACCION 
(
ID INT ,
NOMBRE VARCHAR(30) NOT NULL,
IDOPERACION INT,
CONSTRAINT PK_ACCION PRIMARY KEY(ID),
CONSTRAINT UK_ACCION_NOMBRE UNIQUE(NOMBRE),
CONSTRAINT FK_ACCION_IDOPERACION FOREIGN KEY(IDOPERACION)REFERENCES OPERACION(ID),
);
GO 
CREATE TABLE AUDITORIA
(
ID BIGINT,
DESCRIPCION VARCHAR(500) NOT NULL,
IDACCION INT NOT NULL,
FECHA DATETIME NOT NULL,
NODOCUMENTO BIGINT NOT NULL,
CONSTRAINT PK_AUDITORIA PRIMARY KEY(ID),
CONSTRAINT FK_AUDITORIA_IDACCION FOREIGN KEY(IDACCION)REFERENCES ACCION(ID), 
CONSTRAINT FK_AUDITORIA_IDUSUARIO FOREIGN KEY(NODOCUMENTO)REFERENCES OPERADOR(NODOCUMENTO),
);

---------------//----------------------------//-----------------------//----INSERTS------------------------//----------------------//-------------//----------------------------------//
INSERT INTO TIPOUSUARIO 
VALUES(1,'ADMINISTRADOR')
INSERT INTO TIPOUSUARIO 
VALUES(2,'OPERADOR')

INSERT INTO ESTADOUSUARIO 
VALUES(1,'ACTIVO')
INSERT INTO ESTADOUSUARIO 
VALUES(2,'INACTIVO')
INSERT INTO ESTADOUSUARIO 
VALUES(3,'BLOQUEADO')

INSERT INTO GENERO
VALUES(1,'MASCULINO')
INSERT INTO GENERO
VALUES(2,'FEMENINO')
INSERT INTO GENERO
VALUES(3,'OTROS')

-------------------------------------------------------//PROCEDIMIENTOS ALMACENADOS//------------------------------------//---------------------------------///---------------------
CREATE PROCEDURE CONSULTARULTIMAFACTURA
AS
SELECT TOP 1 NOFACTURA FROM FACTURA ORDER BY NOFACTURA DESC

----------------------------------------------------------------------------------------------------------

CREATE PROCEDURE ULTIMAFACTURA
AS
SELECT RIGHT('000000' +CAST(MAX(CAST(NOFACTURA AS INT )+ 1)AS VARCHAR),6)FROM FACTURA 

-----------------------------------------------------------------------------------------------------------

CREATE PROCEDURE INSERTARDETALLE
@NOFACTURA NVARCHAR(20),
@IDPRODUCTO INT,
@IDMARCA NVARCHAR(20),
@PRECIO DECIMAL(20),
@DESCUENTO INT,
@CANTIDAD INT
AS
IF NOT EXISTS (SELECT * FROM FACTURA WHERE NOFACTURA=@NOFACTURA)
BEGIN
   PRINT 'NO EXISTE LA FACTURA'
END
ELSE
IF NOT EXISTS (SELECT*FROM PRODUCTO WHERE IDPRODUCTO=@IDPRODUCTO )
BEGIN 
 PRINT 'EL PRODUCTO NO EXSTE'
END
ELSE
IF EXISTS (SELECT @NOFACTURA,@IDPRODUCTO,@IDMARCA,@PRECIO,@DESCUENTO,@CANTIDAD FROM DETALLEFACTURA  WHERE NOFACTURA=@NOFACTURA AND IDPRODUCTO=@IDPRODUCTO AND IDMARCA=@IDMARCA  AND PRECIO=@PRECIO AND DESCUENTO=@DESCUENTO AND CANTIDAD=@CANTIDAD)
BEGIN 
 PRINT 'ESTE DETALLE DE FACTURA YA EXISTE'
 END
 ELSE
 BEGIN
   INSERT INTO DETALLEFACTURA VALUES(@NOFACTURA,@IDPRODUCTO,@IDMARCA,@PRECIO,@DESCUENTO,@CANTIDAD)
   UPDATE PRODUCTO SET STOCK =STOCK-@CANTIDAD WHERE IDPRODUCTO=@IDPRODUCTO AND STOCK > @CANTIDAD
 END

 ---------------------------------------------------------------------

CREATE PROCEDURE CONSULTARDETALLEFACTURA
@NOFACTURA VARCHAR(20)
AS
SELECT NUMERO.NOFACTURA, NOMBREPRO.DESCRIPCION ,NOMBREMARCA.NOMBRE ,NOMBREPRO.PRECIOIVA,NODETALLE.DESCUENTO,NODETALLE.CANTIDAD
FROM FACTURA AS NUMERO, DETALLEFACTURA AS NODETALLE,PRODUCTO AS NOMBREPRO ,MARCA AS NOMBREMARCA 
WHERE  NODETALLE.NOFACTURA= NUMERO.NOFACTURA AND NOMBREPRO.IDPRODUCTO= NODETALLE.IDPRODUCTO AND NOMBREMARCA.IDMARCA = NODETALLE.IDMARCA AND NOMBREPRO.PRECIOIVA = NODETALLE.PRECIO AND NUMERO.NOFACTURA = @NOFACTURA

-------------------------------------------------------------------------
CREATE PROCEDURE CONSULTARDOPERADORFACTURA
@NOFACTURA VARCHAR(20)
AS
SELECT NOMBREOPERADOR.NOMBRESOPERADOR,NOMBREOPERADOR.APELLIDOSOPERADOR
FROM CONTROLFACTURA AS NUMEROFACTURA, OPERADOR AS NOMBREOPERADOR,FACTURA AS NOFACTURA
WHERE NUMEROFACTURA.NOFACTURA=@NOFACTURA  AND NUMEROFACTURA.DOCUMENTO = NOMBREOPERADOR.NODOCUMENTO
GROUP BY NOMBREOPERADOR.NOMBRESOPERADOR,NOMBREOPERADOR.APELLIDOSOPERADOR

 ----------------------------------------------------------------------------
CREATE PROCEDURE CONSULTARCAJA
@FECHA DATE
AS
SELECT CAJA.IDREGISTRO ,DOCUMENTO.NODOCUMENTO,CAJA.IDCAJA,SUM(FACTURA.TOTALPAGAR)TOTALGENERADO
FROM REGISTROCAJA AS CAJA,OPERADOR AS DOCUMENTO,FACTURA,CAJA AS IDCAJA,ABRIRCAJA AS OPENCAJA
WHERE  CAJA.IDREGISTRO=OPENCAJA.IDREGISTRO AND DOCUMENTO.NODOCUMENTO=CAJA.DOCUMENTO AND CAJA.FECHA =@FECHA AND FACTURA.FECHA=@FECHA
GROUP BY CAJA.IDREGISTRO,DOCUMENTO.NODOCUMENTO,CAJA.IDCAJA

 
-------------------------------------------------------------------------

CREATE PROCEDURE CONSULTARCIERRE
AS
SELECT TOP (1) TOTAL
FROM CERRARCAJA
ORDER BY TOTAL DESC

-------------------------------------------------------------------------
CREATE PROCEDURE CONSULTARULTIMOREGISTRO
AS
SELECT TOP 1 IDREGISTRO FROM REGISTROCAJA ORDER BY IDREGISTRO DESC

--------------------------------------------------------------------------
CREATE PROCEDURE CONSULTARULTIMOIDCONTROL
AS
SELECT TOP 1 IDCONTROL FROM CONTROLOPERADOR ORDER BY IDCONTROL DESC
---------------------------------------------------------------------
CREATE PROCEDURE VALIDARABRIRCAJA
@FECHA DATE
AS
SELECT COUNT(*) AS NUMERO
FROM REGISTROCAJA
WHERE FECHA =@FECHA
----------------------------------------------------------------------
CREATE PROCEDURE VALIDARCERRARCAJA
@FECHA DATE
AS
SELECT REGISTROCAJA.IDESTADO AS NUMERO
FROM REGISTROCAJA
WHERE  REGISTROCAJA.FECHA=@FECHA

-------------------------------------------------------------------------
CREATE PROCEDURE CONSULTARPRODUCTO
@IDPRODUCTO INT
AS
SELECT NOMBREPRODUCTO.DESCRIPCION ,NOMBREPRODUCTO.IDPRODUCTO,NOMBREMARCA.IDMARCA ,NOMBRECATEGORIA.NOMBRE AS NOMBRECATEGORIA,NOMBREMARCA.NOMBRE AS NOMBREMARCA,NOMBREPRODUCTO.PRECIOUNITARIO AS PRECIOBRUTO,NOMBREPRODUCTO.PRECIOIVA AS PRECIOIVA
FROM PRODUCTO AS NOMBREPRODUCTO,MARCA AS NOMBREMARCA,CATEGORIA_PRODUCTO AS NOMBRECATEGORIA
WHERE NOMBREPRODUCTO.IDPRODUCTO =@IDPRODUCTO  AND NOMBREMARCA.IDMARCA = NOMBREPRODUCTO.IDMARCA AND NOMBRECATEGORIA.IDCATEGORIA =NOMBREPRODUCTO.IDCATEGORIA
GROUP BY NOMBREPRODUCTO.DESCRIPCION ,NOMBREPRODUCTO.IDPRODUCTO,NOMBREMARCA.IDMARCA ,NOMBRECATEGORIA.NOMBRE,NOMBREMARCA.NOMBRE ,NOMBREPRODUCTO.PRECIOUNITARIO,NOMBREPRODUCTO.PRECIOIVA
----------------------------------------------------------------------------
CREATE PROCEDURE ESTADODECIERRE
@NUMERO INT,
@FECHA DATE
AS
SELECT  REGISTRO.IDREGISTRO,REGISTRO.DOCUMENTO, REGISTRO.FECHA, ABRIRCAJA.MONTOA , ABRIRCAJA.MONTOI,ABRIRCAJA.HORAI,ESTADO.ID AS ESTADO,CERRAR.FACTURASG,CERRAR.MONTOR,CERRAR.HORAF,CERRAR.TOTAL
FROM REGISTROCAJA AS REGISTRO , CAJA AS CAJA ,ABRIRCAJA AS ABRIRCAJA ,ESTADOCAJA AS ESTADO,CERRARCAJA AS CERRAR
WHERE CAJA.NUMERO = @NUMERO AND REGISTRO.FECHA=@FECHA AND REGISTRO.IDESTADO = ESTADO.ID
GROUP BY   REGISTRO.IDREGISTRO,REGISTRO.DOCUMENTO, REGISTRO.FECHA, ABRIRCAJA.MONTOA , ABRIRCAJA.MONTOI,ABRIRCAJA.HORAI,ESTADO.ID,CERRAR.FACTURASG,CERRAR.MONTOR,CERRAR.HORAF,CERRAR.TOTAL

---------------------------------------------------------------------------------------
CREATE PROCEDURE ESTADOACTUALCAJA
AS
SELECT CAJA.NUMERO,CAJA.IDCAJA AS CAJA,ESTADO.NOMBRE AS ESTADO ,REGISTRO.FECHA
FROM CAJA AS CAJA ,ESTADOCAJA AS ESTADO,REGISTROCAJA AS REGISTRO
WHERE ESTADO.ID= REGISTRO.IDESTADO AND REGISTRO.IDCAJA = CAJA.IDCAJA AND REGISTRO.FECHA=CONVERT(VARCHAR(10), GETDATE(), 103)
UNION
SELECT CAJA.NUMERO, CAJA.IDCAJA AS CAJA, 'DISPONIBLE' AS ESTADO,REGISTRO.FECHA
FROM CAJA AS CAJA ,ESTADOCAJA AS ESTADO,REGISTROCAJA AS REGISTRO
WHERE REGISTRO.IDESTADO != ESTADO.ID AND REGISTRO.IDCAJA != CAJA.IDCAJA AND REGISTRO.FECHA = CONVERT(VARCHAR(10), GETDATE(), 103)
GROUP BY CAJA.NUMERO,CAJA.IDCAJA,REGISTRO.FECHA
-----------------------------//------------------------------//------------------------------------------//
CREATE PROCEDURE ESTADOACTUALSESION
AS
SELECT OPERADOR.NODOCUMENTO,OPERADOR.NOMBRESOPERADOR AS NOMBRES,OPERADOR.APELLIDOSOPERADOR AS APELLIDOS,CONTROLOPERADOR.HORAINICIO,CONTROLOPERADOR.HORAFIN,CONTROLOPERADOR.FECHA
FROM CONTROLOPERADOR ,OPERADOR
WHERE FECHA= CONVERT(VARCHAR(10), GETDATE(), 103) AND CONTROLOPERADOR.NODOCUMENTO = OPERADOR.NODOCUMENTO


CREATE PROCEDURE ESTADOACTUALSESIONFILTRO
@DOCUMENTO BIGINT
AS
SELECT OPERADOR.NODOCUMENTO,OPERADOR.NOMBRESOPERADOR AS NOMBRES,OPERADOR.APELLIDOSOPERADOR AS APELLIDOS,CONTROLOPERADOR.HORAINICIO,CONTROLOPERADOR.HORAFIN,CONTROLOPERADOR.FECHA
FROM CONTROLOPERADOR ,OPERADOR
WHERE FECHA= CONVERT(VARCHAR(10), GETDATE(), 103) AND CONTROLOPERADOR.NODOCUMENTO= OPERADOR.NODOCUMENTO AND CONTROLOPERADOR.NODOCUMENTO = @DOCUMENTO
----------------------------------//------------------------------//----------------------------------------------------//---------------------------
CREATE PROCEDURE CONSULTACONTROLFACTURA
AS
SELECT CONTROLFACTURA.NOFACTURA AS NOFACTURA,OPERADOR.NODOCUMENTO AS DOCUMENTO,OPERADOR.NOMBRESOPERADOR AS NOMBRES,OPERADOR.APELLIDOSOPERADOR AS APELLIDOS ,CONTROLFACTURA.PC,FACTURA.FECHA AS FECHA
FROM CONTROLFACTURA,OPERADOR,FACTURA 
WHERE CONTROLFACTURA.DOCUMENTO = OPERADOR.NODOCUMENTO AND CONTROLFACTURA.NOFACTURA = FACTURA.NOFACTURA
GROUP BY CONTROLFACTURA.NOFACTURA,OPERADOR.NODOCUMENTO,OPERADOR.NOMBRESOPERADOR,OPERADOR.APELLIDOSOPERADOR,CONTROLFACTURA.PC,FACTURA.FECHA
---------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CONSULTACONTROLFACTURADOCUMENTO
@DOCUMENTO BIGINT
AS
SELECT CONTROLFACTURA.NOFACTURA AS NOFACTURA,OPERADOR.NODOCUMENTO AS DOCUMENTO,OPERADOR.NOMBRESOPERADOR AS NOMBRES,OPERADOR.APELLIDOSOPERADOR AS APELLIDOS ,CONTROLFACTURA.PC,FACTURA.FECHA AS FECHA
FROM CONTROLFACTURA,OPERADOR,FACTURA 
WHERE CONTROLFACTURA.DOCUMENTO = @DOCUMENTO AND CONTROLFACTURA.NOFACTURA = FACTURA.NOFACTURA
GROUP BY CONTROLFACTURA.NOFACTURA,OPERADOR.NODOCUMENTO,OPERADOR.NOMBRESOPERADOR,OPERADOR.APELLIDOSOPERADOR,CONTROLFACTURA.PC,FACTURA.FECHA
----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CONSULTACONTROLFACTURAFECHA
AS
SELECT CONTROLFACTURA.NOFACTURA AS NOFACTURA,OPERADOR.NODOCUMENTO AS DOCUMENTO,OPERADOR.NOMBRESOPERADOR AS NOMBRES,OPERADOR.APELLIDOSOPERADOR AS APELLIDOS ,CONTROLFACTURA.PC,FACTURA.FECHA AS FECHA
FROM CONTROLFACTURA,OPERADOR,FACTURA 
WHERE CONTROLFACTURA.DOCUMENTO = OPERADOR.NODOCUMENTO AND CONTROLFACTURA.NOFACTURA = FACTURA.NOFACTURA AND FACTURA.FECHA =CONVERT(VARCHAR(10), GETDATE(), 103)
GROUP BY CONTROLFACTURA.NOFACTURA,OPERADOR.NODOCUMENTO,OPERADOR.NOMBRESOPERADOR,OPERADOR.APELLIDOSOPERADOR,CONTROLFACTURA.PC,FACTURA.FECHA

------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ULTIMOEMAIL
AS
SELECT TOP 1 EMAIL FROM EMAIL ORDER BY EMAIL DESC
------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CAMBIARPASSWORD
@NODOCUMENTO BIGINT,
@PASSWORD VARCHAR(35)
AS
IF EXISTS(SELECT PASSWORD FROM OPERADOR WHERE NODOCUMENTO=@NODOCUMENTO)
BEGIN
 UPDATE OPERADOR SET PASSWORD =@PASSWORD
END




