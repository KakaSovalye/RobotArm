CREATE PROCEDURE [dbo].[spsel_KoordinataGoreMaxAci] @X INT, @Y INT	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MAX(ANGLE)
	FROM WorkEnvelope
	WHERE X=@X AND Y=@Y   
	
END