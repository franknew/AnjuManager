/*
Navicat MySQL Data Transfer

Source Server         : fangkemanager
Source Server Version : 50524
Source Host           : 5609232420fde.gz.cdb.myqcloud.com:5184
Source Database       : FangkeManager

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2015-12-23 15:04:16
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for Action
-- ----------------------------
DROP TABLE IF EXISTS `Action`;
CREATE TABLE `Action` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Building
-- ----------------------------
DROP TABLE IF EXISTS `Building`;
CREATE TABLE `Building` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `ProvinceID` varchar(32) DEFAULT NULL,
  `CityID` varchar(32) DEFAULT NULL,
  `AreaID` varchar(32) DEFAULT NULL,
  `Street` varchar(200) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `IsDeleted` bit(1) DEFAULT b'0',
  `Remark` varchar(200) DEFAULT NULL,
  `FloorCount` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ChargeFee
-- ----------------------------
DROP TABLE IF EXISTS `ChargeFee`;
CREATE TABLE `ChargeFee` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `UnitPrice` decimal(10,2) DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  `CalType` int(11) DEFAULT NULL,
  `Unit` varchar(10) DEFAULT NULL,
  `PeriodTypeID` int(4) DEFAULT NULL,
  `IsShared` bit(1) DEFAULT NULL,
  `RoomID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for DataDictionary
-- ----------------------------
DROP TABLE IF EXISTS `DataDictionary`;
CREATE TABLE `DataDictionary` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Value` int(11) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `DataDictionaryGroupID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for DataDictionaryGroup
-- ----------------------------
DROP TABLE IF EXISTS `DataDictionaryGroup`;
CREATE TABLE `DataDictionaryGroup` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for House
-- ----------------------------
DROP TABLE IF EXISTS `House`;
CREATE TABLE `House` (
  `ID` varchar(32) NOT NULL,
  `BuildingID` varchar(32) DEFAULT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Floor` int(11) DEFAULT NULL,
  `RoomCount` int(11) DEFAULT NULL,
  `HallCount` int(11) DEFAULT NULL,
  `ToiletCount` int(11) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  `RentType` int(11) DEFAULT NULL,
  `RoomNumber` int(11) DEFAULT NULL,
  `HallNumber` int(11) DEFAULT NULL,
  `ToiletNumber` int(11) DEFAULT NULL,
  `KitchenNumber` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for LogonHistory
-- ----------------------------
DROP TABLE IF EXISTS `LogonHistory`;
CREATE TABLE `LogonHistory` (
  `ID` varchar(32) NOT NULL,
  `UserID` varchar(32) DEFAULT NULL,
  `Token` varchar(32) DEFAULT NULL,
  `LogonTime` datetime DEFAULT NULL,
  `IP` varchar(15) DEFAULT NULL,
  `ActiveTime` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Menu
-- ----------------------------
DROP TABLE IF EXISTS `Menu`;
CREATE TABLE `Menu` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Page` varchar(50) DEFAULT NULL,
  `ParentID` varchar(32) DEFAULT NULL,
  `Enabled` bit(1) DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `ImagePath` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Menu_Role
-- ----------------------------
DROP TABLE IF EXISTS `Menu_Role`;
CREATE TABLE `Menu_Role` (
  `ID` varchar(32) NOT NULL,
  `MenuID` varchar(32) DEFAULT NULL,
  `RoleID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Module
-- ----------------------------
DROP TABLE IF EXISTS `Module`;
CREATE TABLE `Module` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for RentPeriodType
-- ----------------------------
DROP TABLE IF EXISTS `RentPeriodType`;
CREATE TABLE `RentPeriodType` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Role
-- ----------------------------
DROP TABLE IF EXISTS `Role`;
CREATE TABLE `Role` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Role_Module_Action
-- ----------------------------
DROP TABLE IF EXISTS `Role_Module_Action`;
CREATE TABLE `Role_Module_Action` (
  `ID` varchar(32) NOT NULL,
  `RoleID` varchar(32) DEFAULT NULL,
  `ModuleID` varchar(32) DEFAULT NULL,
  `ActionID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Room
-- ----------------------------
DROP TABLE IF EXISTS `Room`;
CREATE TABLE `Room` (
  `ID` varchar(255) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Area` decimal(8,2) DEFAULT NULL,
  `HouseID` varchar(32) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  `RentFee` decimal(10,2) DEFAULT NULL COMMENT '租赁费用',
  `RentCycleType` int(11) DEFAULT NULL COMMENT '租赁周期类型',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for User
-- ----------------------------
DROP TABLE IF EXISTS `User`;
CREATE TABLE `User` (
  `ID` varchar(32) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Creator` varchar(32) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `Enabled` bit(1) DEFAULT NULL,
  `LastUpdateTime` datetime DEFAULT NULL,
  `LastUpdator` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for User_Role
-- ----------------------------
DROP TABLE IF EXISTS `User_Role`;
CREATE TABLE `User_Role` (
  `ID` varchar(32) NOT NULL,
  `UserID` varchar(32) DEFAULT NULL,
  `RoleID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for UserInfo
-- ----------------------------
DROP TABLE IF EXISTS `UserInfo`;
CREATE TABLE `UserInfo` (
  `ID` varchar(32) NOT NULL,
  `QQ` varchar(20) DEFAULT NULL,
  `Mobile` varchar(20) DEFAULT NULL,
  `WX` varchar(30) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Identity` varchar(20) DEFAULT NULL,
  `CnName` varchar(20) DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
