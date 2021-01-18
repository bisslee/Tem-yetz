-- --------------------------------------------------------
-- Servidor:                     bd.asp.hostazul.com.br
-- Versão do servidor:           5.7.19-log - MySQL Community Server (GPL)
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura para tabela 9263_yetz.flow.campanhas
DROP TABLE IF EXISTS `campanhas`;
CREATE TABLE IF NOT EXISTS `campanhas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `nomecliente` varchar(150) NOT NULL,
  `data_inicio` datetime NOT NULL,
  `data_termino` datetime NULL,
  `fator_conversao` float(100,0) NOT NULL ,
  `taxa` float(100,0) NOT NULL ,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuariosusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.compra_pontos
DROP TABLE IF EXISTS `compra_pontos`;
CREATE TABLE IF NOT EXISTS `compra_pontos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcampanha` int(11) NOT NULL,
  `idtipocredito` int(11) NOT NULL,
  `idobservacao` int(11) NOT NULL,
  `unidades` int(11) NOT NULL,
  `pontos` bigint(20) NOT NULL,
  `totalpontos` float NOT NULL ,
  `valoryetz` float NOT NULL,
  `valorpontos` float NOT NULL,
  `valortotal` float NOT NULL ,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.notas_fiscais
DROP TABLE IF EXISTS `notas_fiscais`;
CREATE TABLE IF NOT EXISTS `notas_fiscais` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `dataemissao` datetime DEFAULT NULL,
  `idstatus` int(11) NOT NULL,
  `observacao` text,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.pagadores
DROP TABLE IF EXISTS `pagadores`;
CREATE TABLE IF NOT EXISTS `pagadores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL,
  `contato` varchar(150) NOT NULL,
  `cnpj` varchar(14) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.usuarios
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(100) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `password` varchar(15) NOT NULL,
  `ultimo_login` datetime DEFAULT NULL,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.venda_direta
DROP TABLE IF EXISTS `venda_direta`;
CREATE TABLE IF NOT EXISTS `venda_direta` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcanpanha` int(11) NOT NULL,
  `idpagador` int(11) NOT NULL,
  `numeronota` int(11) DEFAULT NULL,
  `valor` int(11) NOT NULL,
  `dataemissao` int(11) DEFAULT NULL,
  `idstatus` int(11) DEFAULT NULL,
  `observacao` TEXT,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,  
   PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela 9263_yetz.flow.voucher
DROP TABLE IF EXISTS `voucher`;
CREATE TABLE IF NOT EXISTS `voucher` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `idtipo` int(11) NOT NULL,
  `idorigem` int(11) NOT NULL,
  `codPlataforma` int(11) DEFAULT NULL,
  `valor` float NOT NULL,
  `data_criacao` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_atualizacao` timestamp NULL DEFAULT NULL,
  `idusuario_criacao` int(11) DEFAULT NULL,
  `idusuario_atualizacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
