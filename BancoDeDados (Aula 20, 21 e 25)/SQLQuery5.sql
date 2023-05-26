
CREATE DATABASE biblioteca;

USE biblioteca;

CREATE TABLE Autor (
  id INT PRIMARY KEY,
  nome VARCHAR(255),
  nacionalidade VARCHAR(255)
);

CREATE TABLE Editora (
  id INT PRIMARY KEY,
  nome VARCHAR(255)
);

CREATE TABLE Categoria (
  id INT PRIMARY KEY,
  tipo_categoria VARCHAR(255)
);

CREATE TABLE Livro (
  isbn VARCHAR(255) PRIMARY KEY,
  titulo VARCHAR(255),
  ano_publicacao varchar(40),
  fk_editora INT,
  fk_categoria INT,
  FOREIGN KEY (fk_editora) REFERENCES Editora(id),
  FOREIGN KEY (fk_categoria) REFERENCES Categoria(id)
);


ALTER TABLE Livro 
ALTER COLUMN ano_publicacao VARCHAR(40) NOT NULL;

CREATE TABLE LivroAutores (
  id INT PRIMARY KEY,
  fk_livro VARCHAR(255),
  fk_autor INT,
  FOREIGN KEY (fk_livro) REFERENCES Livro(isbn),
  FOREIGN KEY (fk_autor) REFERENCES Autor(id)
);



SELECT Livro.isbn, Livro.titulo, Livro.ano_publicacao, Editora.nome AS editora, Categoria.tipo_categoria
FROM Livro
JOIN Editora ON Livro.fk_editora = Editora.id
JOIN Categoria ON Livro.fk_categoria = Categoria.id
ORDER BY Livro.titulo ASC;

INSERT INTO LIVRO
VALUES (8532511015, 'Harry Potter e a pedra filosofal','2000-01-01 00:00:00', 'Rocco', 'Literatura infantil') ,(23213, 'Harry Potter e a sadsadafilosofal','2000-01-01 00:00:00', 2, 'Humor');