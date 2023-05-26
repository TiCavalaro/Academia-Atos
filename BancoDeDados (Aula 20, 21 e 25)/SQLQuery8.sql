
create table EDITORA

(

��� id integer not null primary key identity,

��� nome varchar(50) not null

)

�

create table AUTOR

(

��� id integer not null primary key identity,

��� nome varchar(50) not null,

��� nacionalidade varchar(50)

)

�

create table CATEGORIA

(

��� id integer not null primary key identity,

��� tipo_categoria varchar(50) not null

)

�

create table LIVRO

(

��� isbn varchar(50) primary key not null,

��� titulo varchar(100) not null,

��� ano_publicacao date not null,

��� fk_editora integer not null,

��� fk_categoria integer not null,

��� FOREIGN KEY (fk_editora) REFERENCES EDITORA (id),

��� FOREIGN KEY (fk_categoria) REFERENCES CATEGORIA (id)

)

�

create table LIVROAUTOR

(

��� id int not null primary key identity,

��� fk_livro varchar(50) not null,

��� fk_autor integer not null,

��� FOREIGN KEY (fk_livro) REFERENCES LIVRO (isbn),

��� FOREIGN KEY (fk_autor)��� REFERENCES AUTOR (id)

)

�

/*insert*/

insert into CATEGORIA values('Literatura Juvenil');

insert into CATEGORIA values('Fic��o Cient�fica');

insert into CATEGORIA values('Humor');

insert into CATEGORIA values('Horror C�smico');

select * from CATEGORIA;

�

insert into AUTOR(nome) values('J.K.Rowling');

insert into AUTOR(nome) values('Clive Staples Lewis');

insert into AUTOR(nome) values('Affonso Solano');

insert into AUTOR (nome, nacionalidade) values('Marcos Piangers', 'Brasileira');

insert into AUTOR values('Marcos Piangers', 'Brasileira');

insert into AUTOR(nome) values('Ciro Botelho - Tiririca');

insert into AUTOR(nome) values('Bianca M�l');

select * from AUTOR;

�

insert into EDITORA(nome) values('Rocco');

insert into EDITORA(nome) values('Wmf Martins Fontes');

insert into EDITORA(nome) values('Casa da Palavra');

insert into EDITORA(nome) values('Belas Letras');

insert into EDITORA(nome) values('Matrix');

select *from EDITORA;

�

insert into LIVRO values('8532511015','Harry Potter e A Pedra Filosofal','2000',1,1);

insert into LIVRO values('9788578270698','As Cr�nicas de N�rnia','2009',1,2);

insert into LIVRO values('9788577343348','O Espadachim de Carv�o','2013',3,3);

insert into LIVRO values('9788581742458','O Papai � Pop','2015',3,1);

insert into LIVRO values('9788582302026','Pior Que T� N�o Fica','2015',4,2);

insert into LIVRO values('9788577345670','Garota Desdobr�vel','2015',2,3);

insert into LIVRO values('8532512062','Harry Potter e o Prisioneiro de Azkaban','2000',1,1);

select *from LIVRO;

�

insert into LIVROAUTOR values('8532511015',1);

insert into LIVROAUTOR values('9788578270698',2);

insert into LIVROAUTOR values('9788577343348',3);

insert into LIVROAUTOR values('9788581742458',4);

insert into LIVROAUTOR values('9788582302026',5);

insert into LIVROAUTOR values('9788577345670',6);

insert into LIVROAUTOR values('8532512062',1);

insert into LIVROAUTOR values('8532512062',2);

select *from LIVROAUTOR;






select *from livro


select livro.isbn, livro.titulo,�
��� LIVRO.ano_publicacao,�
��� editora.nome as 'Editora',�
��� CATEGORIA.tipo_categoria as 'Categoria'
from LIVRO, editora, CATEGORIA
where LIVRO.fk_editora = editora.id
��� and livro.fk_categoria = CATEGORIA.id


select livro.isbn, livro.titulo,�
��� LIVRO.ano_publicacao,�
��� editora.nome as 'Editora',�
��� CATEGORIA.tipo_categoria as 'Categoria',
��� AUTOR.nome
from LIVRO, editora, CATEGORIA, LIVROAUTOR, AUTOR
where LIVRO.fk_editora = editora.id
��� and livro.fk_categoria = CATEGORIA.id
��� and LIVROAUTOR.fk_livro = LIVRO.isbn
��� and LIVROAUTOR.fk_autor = AUTOR.id
order by AUTOR.nome


select livro.isbn, livro.titulo,�
��� LIVRO.ano_publicacao,�
��� editora.nome as 'Editora',�
��� CATEGORIA.tipo_categoria as 'Categoria',
��� AUTOR.nome
from LIVRO, editora, CATEGORIA, LIVROAUTOR, AUTOR
where LIVRO.fk_editora = editora.id
��� and livro.fk_categoria = CATEGORIA.id
��� and LIVROAUTOR.fk_livro = LIVRO.isbn
��� and LIVROAUTOR.fk_autor = AUTOR.id
��� and�
��� (CATEGORIA.tipo_categoria like '%humor%'
��� or CATEGORIA.tipo_categoria like '%fic%fica')
��� and�
��� YEAR(LIVRO.ano_publicacao)�
����������� between 2000 and 2010