-- =============================================
-- Author:		Henry Wyckoff
-- Create date: 2/1/2018
-- Description:	Given a length in inches, convert to centimeters.
-- =============================================
CREATE FUNCTION ConvertInchesToCentimeters 
(		
	@Inches float
)
RETURNS TABLE 
AS
RETURN 
(	
	SELECT Centimeters=cast(@Inches*2.54 as float)
)
