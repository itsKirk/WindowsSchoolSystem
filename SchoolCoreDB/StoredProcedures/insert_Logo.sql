CREATE PROCEDURE [dbo].[insert_Logo]
	@FileName NVARCHAR(50)
AS
	DELETE FROM Logo
	INSERT INTO Logo([FileName]) VALUES(@FileName)
