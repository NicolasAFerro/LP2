CREATE TABLE Clientes (
    Id INT PRIMARY KEY,
    Nome varchar NOT NULL, 
	Quadra varchar NOT NULL, 
	Lote varchar NOT NULL,
);
CREATE TABLE Tipos( 
	Id INT PRIMARY KEY, 
	Descricao varchar NOT NULL, 
)  
CREATE TABLE servicos (
    Id INT PRIMARY KEY,
    valor varchar NOT NULL,
    data DATE NOT NULL,
    Observacao TEXT,
    Tipo_id INT,
    Clientes_id INT,
    CONSTRAINT FK_Tipo_id FOREIGN KEY (Tipo_id) REFERENCES Tipos(Id),
    CONSTRAINT FK_Clientes_id FOREIGN KEY (Clientes_id) REFERENCES Clientes(Id),
);
