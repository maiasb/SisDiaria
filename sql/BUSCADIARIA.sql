CREATE PROCEDURE spBuscaDiaria

	@ID_DIARIA VARCHAR(50)

AS
BEGIN
	
	SELECT * FROM DIARIA WHERE ID_DIARIA = @ID_DIARIA

END