﻿USE WALMART
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ESTADO_LISTA')
DROP PROCEDURE ESTADO_LISTA
GO

CREATE PROCEDURE [dbo].[ESTADO_LISTA]

AS
BEGIN

	SELECT COD_ESTADO, PAIS, NOME, SIGLA, REGIAO
	FROM ESTADO

END
GO