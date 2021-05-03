CREATE PROCEDURE spCadDiaria

	@MAT VARCHAR(50),
	@ID_DIARIA INT,
	@SAIDA VARCHAR(50),
	@HORAS VARCHAR(50),
	@DATAS VARCHAR(50),
	@DESTINO VARCHAR(50),
	@HORAD VARCHAR(50),
	@DATAD VARCHAR(50),
	@VALORD VARCHAR(50),
	@TIPO VARCHAR(50),
	@OBJ VARCHAR(50)

AS
BEGIN

	--SELECT MAT FROM SERVIDOR WHERE MAT = @MAT

	INSERT INTO DIARIA (ID_DIARIA, MAT, SAIDA, HORAS, DATAS, DESTINO, HORAD, DATAD, VALORD, TIPO, OBJ)
		    VALUES (@ID_DIARIA, @MAT, @SAIDA, @HORAS, @DATAS, @DESTINO, @HORAD, @DATAD, @VALORD, @TIPO, @OBJ)

END