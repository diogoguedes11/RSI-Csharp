create procedure LoginUser(
  @username varchar(50),
  @password varchar(64)
)
As begin
  if not exists(select null from users where username = @username and password=@password)
      print('0');
	  else
	  print('1')
  end
IF EXISTS TAMBÉM FUNCIONA-INVERSO


--ALTERNATIVA

create procedure LoginUser(
  @username varchar(10),
  @password varchar(64)
)
As begin
	Set nocount on --Nao retoma o numero de registos
	select case when exists(select null from users where username = @username and password = @password)
	then
		cast (1 as bit)
	else
		cast (0 as bit)
	end
end
