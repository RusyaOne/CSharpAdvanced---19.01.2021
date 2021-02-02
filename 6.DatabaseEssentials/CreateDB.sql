create database CSharpAdvanced
 CONTAINMENT = none
 on primary 
( name = N'CSharpAdvanced', filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CSharpAdvanced.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG on 
( name = N'CSharpAdvanced_log', filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CSharpAdvanced_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 with CATALOG_COLLATION = DATABASE_DEFAULT
go


drop database CSharpAdvanced
go
