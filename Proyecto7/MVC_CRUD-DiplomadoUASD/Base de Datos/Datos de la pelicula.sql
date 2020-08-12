USE [PeliculasDB]
GO

INSERT INTO [dbo].[TBL_PELICULA]
           ([Titulo]
           ,[Director]
           ,[AutorPrincipal]
           ,[No_Autor]
           ,[Duracion]
           ,[Estreno])
   select 'Origen','Christopher Nolan','Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page',30,2.5 ,2010
	UNION ALL
	select 'Avatar','James Cameron','Sam Worthington, Zoe Saldana, Sigourney Weaver ',30 ,3 ,2019
	UNION ALL
	select 'El caballero oscuro','Todd Phillips','Christian Bale, Heath Ledger, Aaron Eckhart',30 ,2.6 ,2008 
	UNION ALL
	select 'Joker','Quentin Tarantino','Brad Pitt, Joaquin Phoenix, Robert De Niro, Zazie Beetz ',56 ,2 ,2019 
	UNION ALL
	select 'Malditos bastardos','Christopher Nolan',' Christoph Waltz, Mélanie Laurent',20 ,2.5 , 2009
	UNION ALL
	select 'Interstellar','Christopher Nolan','Matthew McConaughey, Anne Hathaway, David Gyasi ',31 ,2.5 , 2014
	UNION ALL
	select 'Cisne negro ','Darren Aronofsky','Natalie Portman, Mila Kunis, Vincent Cassel',25 ,2.5 , 2010 
	UNION ALL
	select 'Gran Torino','Clint Eastwood','Clint Eastwood, Christopher Carley, Bee Vang',25 ,26 ,2018 
	UNION ALL
	select 'Slumdog Millionaire','Danny Boyle, Loveleen Tandan ','Dev Patel, Freida Pinto, Madhur Mittal ',29 ,2.8 ,2018 
	UNION ALL
	select 'Django desencadenado','Quentin Tarantino','Jamie Foxx, Christoph Waltz, Leonardo DiCaprio',30 ,2.5 , 2012
GO




