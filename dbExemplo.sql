create database dbExemplo;

use  dbExemplo;

create table tbUsuario
(
idUsu int primary key auto_increment,
    nomeUsu varchar (50) not null,
    cargo varchar (50) not null,
    datanasc date
);

insert into tbUsuario (nomeUsu, cargo, datanasc)
values ('bob', 'monstrorista', '2019/04/16'),
  ('maria', '171', '2019/04/16');

select * from tbUsuario;

Delimiter $$
create procedure insereUsu (pnomeUsu varchar (50),
  pcargo varchar (50),
                           pdatanasc date)

begin
insert into tbUsuario (NomeUsu, cargo, DataNasc)
  values (pNomeUsu, pcargo, pDataNasc);
end; $$

call InsereUsu ('DST', 'Aluno', '2020/02/07');