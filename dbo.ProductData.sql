CREATE PROCEDURE [dbo].[ProductData]
	@param1 int
AS
	SELECT * FROM Products
	WHERE p.Product_Id = @param1
RETURN 0