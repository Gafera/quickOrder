-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 14-Dez-2018 às 13:42
-- Versão do servidor: 5.7.21
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quickorder`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(30) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `senha` varchar(1000) DEFAULT NULL,
  `dataNascimento` varchar(12) DEFAULT NULL,
  `telefone` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `formapagamento`
--

DROP TABLE IF EXISTS `formapagamento`;
CREATE TABLE IF NOT EXISTS `formapagamento` (
  `codForma` int(11) NOT NULL AUTO_INCREMENT,
  `nomeForma` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`codForma`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `formapagamento`
--

INSERT INTO `formapagamento` (`codForma`, `nomeForma`) VALUES
(1, 'Dinheiro'),
(2, 'Cartão de Crédito'),
(4, 'Dinheiro'),
(5, 'Cartão de Crédito');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itenspedido`
--

DROP TABLE IF EXISTS `itenspedido`;
CREATE TABLE IF NOT EXISTS `itenspedido` (
  `codPedido` int(11) DEFAULT NULL,
  `codProduto` int(11) DEFAULT NULL,
  `preco` decimal(10,0) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `pronto` varchar(30) DEFAULT NULL,
  KEY `codPedido` (`codPedido`),
  KEY `codProduto` (`codProduto`),
  KEY `fk_pronto` (`pronto`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mesa`
--

DROP TABLE IF EXISTS `mesa`;
CREATE TABLE IF NOT EXISTS `mesa` (
  `numeroMesa` int(11) NOT NULL AUTO_INCREMENT,
  `ocupacao` varchar(7) DEFAULT NULL,
  PRIMARY KEY (`numeroMesa`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `mesa`
--

INSERT INTO `mesa` (`numeroMesa`, `ocupacao`) VALUES
(1, 'Livre'),
(2, 'Livre'),
(3, 'Livre');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE IF NOT EXISTS `pedido` (
  `codPedido` int(11) NOT NULL,
  `codCliente` int(11) DEFAULT NULL,
  `codFormaPagamento` int(11) DEFAULT NULL,
  `codMesa` int(11) DEFAULT NULL,
  `valorTotal` decimal(10,0) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `andamento` varchar(30) DEFAULT NULL,
  `tipoPedido` int(11) DEFAULT NULL,
  PRIMARY KEY (`codPedido`),
  KEY `codCliente` (`codCliente`),
  KEY `codFormaPagamento` (`codFormaPagamento`),
  KEY `codMesa` (`codMesa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(30) DEFAULT NULL,
  `precoProduto` decimal(10,0) DEFAULT NULL,
  `codTipo` int(11) DEFAULT NULL,
  `imagemLocal` varchar(150) DEFAULT NULL,
  `nomeImagem` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`codProduto`),
  KEY `codTipoFK` (`codTipo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipoproduto`
--

DROP TABLE IF EXISTS `tipoproduto`;
CREATE TABLE IF NOT EXISTS `tipoproduto` (
  `codTipo` int(11) NOT NULL AUTO_INCREMENT,
  `nomeTipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`codTipo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tipoproduto`
--

INSERT INTO `tipoproduto` (`codTipo`, `nomeTipo`) VALUES
(1, 'Lanches'),
(2, 'Porções'),
(3, 'Bebidas');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
