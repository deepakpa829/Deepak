CREATE PROCEDURE [dbo].[UpdateRecords]
     @Id int ,
	@Sname varchar(max)
	
AS
	update Student set Sname=@Sname where Id=@Id;

