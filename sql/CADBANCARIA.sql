CREATE PROCEDURE spCadBancaria

	@NOMESERVIDOR VARCHAR(50),
	@MAT INT,
	@BANCO VARCHAR(50),
	@CONTA VARCHAR(50)

AS
BEGIN

	SELECT MAT FROM SERVIDOR WHERE NOMESERVIDOR = @NOMESERVIDOR AND MAT = @MAT
	SELECT @@IDENTITY AS MAT
	--SET @ID_SERVIDOR = SCOPE_IDENTITY()

	INSERT INTO CBANCARIA (MAT, BANCO, CONTA)
		         VALUES (@MAT, @BANCO, @CONTA)

				 			--SET @ID_SERVIDOR = @@IDENTITY--SCOPE_IDENTITY()
			--INSERT INTO CBANCARIA (ID_SERVIDOR, BANCO, AGEN, CONTA) VALUES (@ID_SERVIDOR, @BANCO, @AGEN, @CONTA)

END