CREATE PROCEDURE spBuscaServidor

	@NOMESERVIDOR VARCHAR(50),
	@MAT VARCHAR(50)

AS
BEGIN

	IF EXISTS (SELECT * FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR AND MAT = @MAT)
	SELECT * FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR AND MAT = @MAT

	IF NOT EXISTS (SELECT * FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR OR MAT = @MAT)
	PRINT 'SERVIDOR N�O ENCONTRADO'

	ELSE (SELECT * FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR OR MAT = @MAT)
	SELECT * FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR OR MAT = @MAT
	
END