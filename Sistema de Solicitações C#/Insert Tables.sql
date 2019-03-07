INSERT into Providers (Razao_Social ,CNPJ ) values ( 'Razao Social Teste' , '06255692000103')

insert into [Notas_Fiscais] (SeriesNFe, NumberNFe , ProviderID , EmissionDate ) VALUES (1,1,1, getdate())

insert into [Products] ( Nome_produto, Tipo_unidade) values ( 'Produto Teste' , 'unidade') 

insert into [NFe_Itens] ( numero_item, Quantidade,produtcID, NFEID ) values ( 1,1,1,1)

insert into [Stock_Itens] ( ProductID, Quantidade) values ( 1,1) 

insert into [Access_Level] ( Name , Type) VALUES ( 'Administrador' , 1) 

insert into [users] (Name, UserName, Password, Acess_levelID , Login_Active, isActive,Idioma ) values ( 'usuario teste' , 'user' , '123' , 1,1,1,1)

insert into [Solicitation] (User_Requester , status) values ( 1,1)

insert into [Solicitation_Itens] (SolicitationID , ProductID, Quantidade ) VALUES ( 1,1,1)
	











