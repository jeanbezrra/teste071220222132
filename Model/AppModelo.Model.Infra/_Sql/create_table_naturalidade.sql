CREATE TABLE naturalidades (
id int not null auto_increment,
descricao varchar(250) not null, 
dataCriacao datetime not null,
dataAlteracao datetime not null,
ativo boolean not null,
constraint pk_naturalidade_id primary key (id))
