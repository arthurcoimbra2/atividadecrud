drop database db_usuarios;
Create database db_usuarios;
use db_usuarios;

create table tb_usuarios (
    ID INT auto_increment primary key,
    NOME VARCHAR(45),
    EMAIL VARCHAR(45)
);


insert into tb_usuarios (NOME, EMAIL) values ('Vitor', 'kisenta@gmail.com');
insert into tb_usuarios (NOME, EMAIL) values ('Szaffron', 'szafroONG@gmail.com');
insert into tb_usuarios (NOME, EMAIL) values ('Arthur', 'mesi@gmail.com');
