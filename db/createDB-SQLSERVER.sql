

DROP TABLE IF EXISTS Campanhas;

CREATE TABLE Campanhas (
  IdCampanha int IDENTITY(1,1) NOT NULL ,
  Nome varchar(150) NOT NULL,
  NomeCliente varchar(150) NOT NULL,
  DataInicio datetime NOT NULL,
  DataTermino datetime NULL,
  FatorConversao float NOT NULL ,
  Taxa float NOT NULL ,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdCampanha)
) ;

DROP TABLE IF EXISTS CompraPontos;
CREATE TABLE CompraPontos (
  IdCompraPonto int IDENTITY(1,1) NOT NULL,
  IdCampanha int NOT NULL,
  IdTipoCredito int NOT NULL,
  IdObservacao int NOT NULL,
  Unidades int NOT NULL,
  Pontos bigint NOT NULL,
  TotalPontos float NOT NULL ,
  ValorYetz float NOT NULL,
  ValorPontos float NOT NULL,
  ValorTotal float NOT NULL ,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdCompraPonto)
) ;

DROP TABLE IF EXISTS NotasFiscais;
CREATE TABLE  NotasFiscais (
  IdNotasFiscal int IDENTITY(1,1) NOT NULL,
  Numero int DEFAULT NULL,
  Valor float DEFAULT NULL,
  DataEmissao datetime DEFAULT NULL,
  IdStatus int NOT NULL,
  Observacao text,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdNotasFiscal)
) ;

DROP TABLE IF EXISTS Pagadores;
CREATE TABLE  Pagadores (
  IdPagador int IDENTITY(1,1) NOT NULL ,
  Nome varchar(150) NOT NULL,
  Email varchar(150) NOT NULL,
  Contato varchar(150) NOT NULL,
  CNPJ varchar(14) NOT NULL,
  Telefone varchar(20) NOT NULL,
  Celular varchar(20) NOT NULL,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdPagador)
) ;

DROP TABLE IF EXISTS Usuarios;
CREATE TABLE  Usuarios (
  IdUsuario int IDENTITY(1,1) NOT NULL ,
  Email varchar(100) NOT NULL,
  Nome varchar(150) NOT NULL,
  Senha varchar(50) NOT NULL,
  UltimoLogin datetime DEFAULT NULL,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdUsuario)
) ;

DROP TABLE IF EXISTS VendasDiretas;
CREATE TABLE  VendasDiretas (
  IdVendaireta int  IDENTITY(1,1) NOT NULL ,
  IdCampanha int NOT NULL,
  IdPagador int NOT NULL,
  NumeroNota int DEFAULT NULL,
  Valor int NOT NULL,
  DataEmissao int DEFAULT NULL,
  IdStatus int DEFAULT NULL,
  Observacao TEXT,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
   PRIMARY KEY (IdVendaireta)
) ;

DROP TABLE IF EXISTS Vouchers;
CREATE TABLE  Vouchers (
  IdVoucher int IDENTITY(1,1) NOT NULL ,
  Nome varchar(150) NOT NULL,
  IdTipo int NOT NULL,
  IdOrigem int NOT NULL,
  CodigoPlataforma int DEFAULT NULL,
  Valor float NOT NULL,
  DataCriacao datetime NULL DEFAULT GetDate(),
  DataAtualizacao datetime NULL DEFAULT NULL,
  IdUsuarioCriacao int DEFAULT NULL,
  IdUsuarioAtualizacao int DEFAULT NULL,
  PRIMARY KEY (IdVoucher)
) ;

