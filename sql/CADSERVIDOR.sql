CREATE PROCEDURE spCadServidor
	@NOMESERVIDOR VARCHAR(50),
	@MAT INT,
	@CARGO VARCHAR(50),
	@LOT VARCHAR(50)

AS
BEGIN

	INSERT INTO SERVIDOR (NOMESERVIDOR, MAT, CARGO, LOT) 
		    VALUES (@NOMESERVIDOR, @MAT, @CARGO, @LOT)
END