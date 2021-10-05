CREATE PROCEDURE [dbo].[insert_County]
    @Code NVARCHAR(50), 
    @Name NVARCHAR(50) 
AS
	INSERT INTO Counties([Code], [Name])VALUES(@Code,@Name)
