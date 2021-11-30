USE [Sacco Book]
EXEC sp_MSforeachtable 'TRUNCATE TABLE ?'
GO