create table java
(
	professor varchar(20) null

)

create table net
(
	professor varchar(20) null
	
)


insert into net
values ('FAbricio'),('Ricador'),('Alexandre')


insert into Java
values ('FAbricio'),('Lucas'),('Davi')

select * from net
select * from java


select * from net
union
select * from java

select * from java
inner join net
on java.professor = net.professor


select * from java
left join net
on java.professor = net.professor


--left exclusivo
select * from java
left join net
on java.professor = net.professor
where net.professor is null

select * from java
right join net
on java.professor = net.professor


-- right exclusivo
select * from java
right join net
on java.professor = net.professor
where java.professor is null


-- outer join 
select * from java
full outer join net
on java.professor = net.professor
where java.professor is null
	or net.professor is null

delete from java where professor = 'Lucas'

create table log 
(

    id integer not null primary key identity,
    acao varchar(10) not null,
    descricao varchar(100),
    quando datetime not null

)

select * from java

create trigger primeiratrigger
on java
AFTER DELETE
as
BEGIN
	insert into log values ('Exclusao',
		'Um professor de java foi excluido',
		GETDATE())
END


create trigger segundatrigger
on java
after insert 
as
begin
	insert into log values('Insercao', 
	'add prof java', GETDATE());
	PRINT('Dados inseridos');
end


insert into java values ('Lucas')

select * from log

select * from java

create trigger terceira
on java
after insert
as
begin
	declare @contagem int
	select @contagem = (select count(professor) from java)

	PRINT('Quantidade de professores: ' + CONVERT(varchar(10), @contagem))

	IF @contagem < 3
		begin
			insert into log values ('Insercao', 
			'add prof java', GETDATE());
			print('Inserido com sucesso');
		end
	ELSE
		begin
			ROLLBACK;
			insert into log values ('Insercao', 
			'TENTATIVA INSERCAO MAL SUCESSIDA java', GETDATE());
			RAISERROR('INVALIDO', 14, 1);
			RETURN;
		end
end



drop trigger quartatrigger

create trigger quartatrigger
on java
after update
as
begin
    declare @anterior varchar(20)
    declare @novo varchar(20)

 

    select @anterior = (select deleted.professor from deleted)
    select @novo = (select inserted.professor from inserted)

 

    IF(ROWCOUNT_BIG() = 0)
        return;

 

    IF @anterior= @novo
    begin
        raiserror('SEM ALTERAÇÕES', 14, 1);
        rollback transaction;
        insert into log values ('Atualização', 
            'Tentativa de update mal sucedida!', GETDATE());
    end
    ELSE
    begin
        insert into log values ('upd', 
            'Alteração do prof, ' + @anterior + 
            ' para ' + @novo, GETDATE());
    end
end

 

select * from java

 

select * from log

 

update java set professor = 'Fabricio' 
where professor = 'Davi'

update java set professor 
select *from java