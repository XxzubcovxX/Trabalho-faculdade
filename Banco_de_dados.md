CREATE DATABASE pet_house;

CREATE TABLE cliente (
    id_do_cliente int PRIMARY KEY AUTO_INCREMENT,
    nome_do_cliente varchar(20),
    sobrenome varchar(50),
    cpf varchar(11) UNIQUE,
    telefone_fixo varchar(10),
    telefone_celular varchar(11),
    email varchar(50)UNIQUE,
    senha varchar(8),
    genero varchar(9),
    data_de_nascimento date,
    cep varchar(9),
    endereco varchar(30),
    numero varchar(10),
    bairro varchar(50),
    cidade varchar(20),
    uf varchar(20)
);

INSERT INTO cliente (nome_do_cliente, sobrenome, cpf, telefone_fixo, telefone_celular, email, senha, genero, data_de_nascimento, cep, endereco, numero, bairro, cidade, uf)
VALUES 
('João', 'da Silva', '12345678901', '1122334455', '11987654321', 'joao.silva@example.com', '12345678', 'Masculino', '1990-05-15', '01234-567', 'Rua das Flores', '123', 'Santa Teresa', 'São Paulo', 'SP'),
('Maria', 'Oliveira', '98765432109', '5544332211', '11999887766', 'maria.oliveira@example.com', 'abcdefgh', 'Feminino', '1985-08-20', '89012-345', 'Avenida dos Sonhos', '456', 'Jardim Botânico', 'Rio de Janeiro', 'RJ'),
('Anderson', 'Melo', '48932178535', '1145458989', '11874747896', 'AndersonMelo@gmail.com', 'ijklmnop', 'Outro', '1980-09-16', '08165478', 'Rua Ribeirao', '221B', 'Vila Madalena', 'Rio Branco', 'São Paulo'),
('Maria', 'Silva', '12345678910', '2123456789', '21987654321', 'maria@gmail.com', 'qrstuvwx', 'Feminino', '1990-05-20', '20000-000', 'Avenida Brasil', '789', 'Leblon', 'Rio de Janeiro', 'RJ'),
('João', 'dos Santos', '98765432111', '3133334444', '3199998888', 'joao.santos@hotmail.com', 'yzabcdef', 'Masculino', '1985-11-12', '30000-000', 'Rua das Flores', '555', 'Brooklin', 'Belo Horizonte', 'MG'),
('Ana', 'de Oliveira', '45678901234', '5133335555', '5199992222', 'ana.oliveira@yahoo.com', '123abcde', 'Feminino', '1978-07-25', '90000-000', 'Rua dos Andradas', '13', 'Copacabana', 'Porto Alegre', 'RS'),
('Pedro', 'Fernandes Santana', '87654321098', '1133337777', '1199993333', 'pedro.fernandes@gmail.com', '67890abc', 'Outro', '1998-03-08', '01300-000', 'Avenida Paulista', '1001', 'Soho', 'São Paulo', 'SP');


CREATE TABLE animal (
    id_do_animal int PRIMARY KEY AUTO_INCREMENT,
    nome_do_animal varchar(20),
    especie varchar(20),
    raca varchar(15),
    data_de_nascimento date,
    altura_cm DECIMAL(5,2),
    peso_kg DECIMAL(5,2),
    comprimento_cm DECIMAL(5,2)
);

INSERT INTO animal (nome_do_animal, especie, raca, data_de_nascimento, altura_cm, peso_kg, comprimento_cm) VALUES
('Rex', 'Cachorro', 'Pastor Alemão', '2019-07-12', 65.0, 30.0, 70.0),
('Bella', 'Gato', 'Maine Coon', '2020-04-30', 35.0, 7.0, 55.0),
('Tweety', 'Pássaro', 'Canário', '2018-12-05', 15.0, 0.2, 10.0),
('Goldie', 'Peixe', 'Betta', '2020-01-01', 2.0, 0.01, 5.0),
('Whiskers', 'Roedor', 'Hamster Sírio', '2021-01-15', 10.0, 0.05, 10.0),
('Spike', 'Réptil', 'Iguana', '2017-09-20', 35.0, 5.5, 50.0),
('Fluffy', 'Gato', 'Persa', '2020-10-20', 25.0, 4.0, 40.0);


CREATE TABLE registro_medico_do_animal (
    id_registro_medico_do_animal int PRIMARY KEY AUTO_INCREMENT,
    historico_de_vacinacao varchar(500),
    medicamentos_prescritos varchar(500),
    tratamentos_realizados varchar(500),
    consultas_veterinarias varchar(500),
    alergias varchar(500),
    condicoes_de_saude varchar(500),
    exames varchar(500),
    resultados varchar(500),
    observacoes varchar(500)
);

INSERT INTO registro_medico_do_animal (historico_de_vacinacao, medicamentos_prescritos, tratamentos_realizados, consultas_veterinarias, alergias, condicoes_de_saude, exames, resultados, observacoes) VALUES
('Vacinação completa.', 'N/A', 'N/A', 'Consulta de rotina.', 'Nenhuma', 'Boa saúde geral.', 'Exame de sangue', 'Resultados normais.', 'Animal saudável.'),
('N/A', 'Antibiótico prescrito para infecção respiratória.', 'Inalação e medicação oral', 'Consulta de acompanhamento.', 'Nenhuma', 'Recuperação estável.', 'Raio-X', 'Melhora no pulmão esquerdo.', 'Retorno em duas semanas para reavaliação.'),
('Vacinação contra raiva aplicada.', 'N/A', 'N/A', 'Consulta de rotina.', 'Nenhuma', 'Boa saúde geral.', 'Exame de fezes', 'Resultados normais.', 'Animal saudável.'),
('N/A', 'Anti-inflamatório para dor nas articulações.', 'Massagem terapêutica', 'Consulta de acompanhamento.', 'Nenhuma', 'Recuperação estável.', 'Ultrassom', 'Leve inflamação no quadril direito.', 'Restrição de atividade física recomendada.'),
('Vacinação anual atualizada.', 'N/A', 'N/A', 'Consulta de rotina.', 'Nenhuma', 'Boa saúde geral.', 'Exame de urina', 'Resultados normais.', 'Animal saudável.'),
('N/A', 'Medicação antiparasitária para vermes intestinais.', 'N/A', 'Consulta de rotina.', 'Nenhuma', 'Boa saúde geral.', 'Hemograma', 'Leve anemia detectada.', 'Suplementação de ferro recomendada.'),
('Vacinação básica administrada.', 'N/A', 'N/A', 'Consulta de rotina.', 'Nenhuma', 'Boa saúde geral.', 'Radiografia', 'N/A', 'Aguardando resultados para verificar lesão óssea suspeita.');


CREATE TABLE vinculo_tabelasCliente (
    id_vinculo_tabelasCliente int PRIMARY KEY AUTO_INCREMENT,
    id_do_cliente INT,
    id_do_animal INT,
    id_registro_medico_do_animal INT,
    FOREIGN KEY (id_do_cliente) REFERENCES cliente(id_do_cliente),
    FOREIGN KEY (id_do_animal) REFERENCES animal(id_do_animal),
    FOREIGN KEY (id_registro_medico_do_animal) REFERENCES registro_medico_do_animal(id_registro_medico_do_animal)
);

INSERT INTO vinculo_tabelasCliente (id_do_cliente, id_do_animal, id_registro_medico_do_animal) 
VALUES 
(1, 7, 1),
(2, 6, 2),
(3, 5, 3),
(4, 4, 4),
(5, 3, 5),
(6, 2, 6),
(7, 1, 7);


CREATE TABLE produtos_estoque (
    id_do_produto INT PRIMARY KEY AUTO_INCREMENT,
    nome_do_produto VARCHAR(50),
    preco decimal(10,2),
    descricao VARCHAR(100),
    quantidade_estoque INT,
    imagem LONGBLOB,
    nota int,
    data_cadastro date	
);

INSERT INTO produtos_estoque (nome_do_produto, preco, descricao, quantidade_estoque, nota, data_cadastro) 
VALUES 
('Ração Golden Special', 134.99, 'Ração Golden Special para Cães Adultos Sabor Frango e Carne', 20, 5, '2024-04-20'),
('Ração Golden', 178.00, 'Ração Golden para Gatos Adultos Castrados Sabor Salmão', 33, 5, '2024-04-20'),
('Poleiro Bragança', 50.99, 'Poleiro Bragança Galho Natural Forquilha para Pássaros', 15, 5, '2024-04-20'),
('Enfeite Lester', 23.99, 'Enfeite Lester Barril Mini', 10, 5, '2024-04-20'),
('Alimento Petz', 35.99, 'Alimento Petz Extrusado Natural para Coelho', 8, 4, '2024-04-20'),
('Terrário Aquaterrário', 572.99, 'Terrário Aquaterrário para Tartaruga Com Cascata', 5, 3, '2024-04-26'),
('Ração Reino das Aves Gold Mix', 14.99, 'Ração Reino das Aves Gold Mix Calopsita para Pássaros', 55, 4, '2024-04-27'),
('Suplemento Labcon', 21.99, 'Suplemento Labcon Tartaruga Reptovit', 7, 4, '2024-04-28'),
('Alimento Alcon Guppy', 22.99, 'Alimento para peixe Alcon Guppy 20gr', 14, 5, '2024-04-29'),
('Ração Golden Duii', 174.99, 'Ração Golden Duii para Cães Adultos Sabor Salmão com Ervas e Cordeiro com Arroz', 20, 5, '2024-04-20'),
('Ração Golden Fórmula Mini Bits', 166.99, 'Ração Golden Fórmula Mini Bits Para Cães Adultos de Porte Pequeno Sabor Carne e Arroz', 25, 5, '2024-04-20'),
('Ração Golden Seleção Natural', 169.99, 'Ração Golden Seleção Natural para Cães Adultos de Porte Médio e Grande Sabor Frango com Batata Doce', 15, 4, '2024-04-20'),
('Ração Golden Seleção Natural', 174.99, 'Ração Golden Seleção Natural para Cães Sênior de Porte Médio e Grande Sabor Frango e Arroz', 35, 5, '2024-04-20'),
('Ração Premier Fórmula', 261.99, 'Ração Premier Fórmula para Cães Sênior de Porte Grande e Gigante Sabor Frango', 5, 4, '2024-04-20'),
('Ração Premier Nutrição Clínica', 329.99, 'Ração Premier Nutrição Clínica Cardio para Cães de Porte Médio e Grande 10,1 kg', 10, 5, '2024-04-20'),
('Ração Premier Nutrição Clínica', 99.99, 'Ração Premier Nutrição Clínica Cardio para Cães de Porte Pequeno', 10, 5, '2024-04-20'),
('Ração Premier Raças', 224.99, 'Ração Premier Raças Específicas para Golden Retriever Filhotes Sabor Frango', 40, 5, '2024-04-20'),
('Ração Úmida GranPlus Gourmet', 3.99, 'Ração Úmida GranPlus Gourmet Sachê para Cães Adultos Sabor Carne', 20, 5, '2024-04-29'),
('Ração Úmida GranPlus Gourmet', 2.99, 'Ração Úmida GranPlus Gourmet Sachê para Cães Adultos Sabor Ovelha', 30, 5, '2024-04-29'),
('Antipulgas Simparic 20 mg', 101.99, 'Antipulgas Simparic 20 mg para cães de 5,1 a 10 kg', 10, 4, '2024-04-29'),
('Agemoxi CL 250mg Antibiótico', 117.99, 'Agemoxi CL 250mg Antibiótico 10 comprimidos para Cães e Gatos', 5, 4, '2024-04-20'),
('Shampoo Dermatológico Virbac Hexadene', 189.99, 'Shampoo Dermatológico Virbac Hexadene Spherulites para Cães e Gatos', 20, 5, '2024-04-29'),
('Shampoo Dermatológico Virbac Hexadene', 239.99, 'Shampoo Dermatológico Virbac Sebolytic SIS para Cães e Gatos', 30, 4, '2024-04-20'),
('Spray Hidratante Hidrapet', 139.99, 'Spray Hidratante Hidrapet Skin On para Cães e Gatos', 50, 3, '2024-04-20'),
('Caixa de Transporte Chalesco', 885.99, 'Caixa de Transporte Chalesco Gulliver Cinza Com Rodas', 10, 5, '2024-04-29'),
('Cadeira de Transporte Chalesco', 219.99, 'Cadeira de Transporte Chalesco Para Cães - Cores Sortidas', 10, 5, '2024-04-29'),
('Gravata Borboleta de Natal', 16.99, 'Gravata Borboleta de Natal Modernpet para Cães', 5, 3, '2024-04-23'),
('Guia Petz Naked Caramel', 99.99, 'Guia Petz Naked Caramel para Cães', 15, 3, '2024-04-23'),
('Peitoral Petz Flúor', 69.99, 'Peitoral Petz Flúor Blue para Cães', 15, 3, '2024-04-23'),
('Ração Premier Nutrição Clínica', 99.99, 'Ração Premier Nutrição Clínica Cardio para Cães de Porte Médio e Grande', 10, 5, '2024-04-20');

CREATE TABLE funcionarios (
id_funcionarios int AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(20),
sobrenome VARCHAR(50),
usuario VARCHAR(50) UNIQUE,
senha VARCHAR(50) UNIQUE,
grau INT(11));

INSERT INTO funcionarios(Nome,Sobrenome,Usuario,Senha,Grau) VALUES ('Samuel','Oliveira','Fk1235','12345',1);
INSERT INTO funcionarios(Nome,Sobrenome,Usuario,Senha,Grau) VALUES ('Laura','Santos','Ls3423','11134',2);
INSERT INTO funcionarios(Nome,Sobrenome,Usuario,Senha,Grau) VALUES ('André','Rezende','Ju1456','22222',3);

CREATE TABLE agendamento (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nomeCompleto VARCHAR(100),
    CPF VARCHAR(11),
    telefone VARCHAR(11),
    email VARCHAR(100),
    nomeAnimal VARCHAR(100),
    racaAnimal VARCHAR(100),
    idadeAnimal INT,
    pesoAnimal DECIMAL(10, 2),
    tipoServico VARCHAR(100),
    dataAgendamento DATE,
    horaAgendamento TIME
);

INSERT INTO agendamento (nomeCompleto, CPF, telefone, email, nomeAnimal, racaAnimal, idadeAnimal, pesoAnimal, tipoServico, dataAgendamento, horaAgendamento)
VALUES 
    ('João da Silva', '12345678901', '11987654321', 'joao.silva@example.com', 'Rex', 'Labrador', 5, 30.50, 'Clinio', '2024-06-07', '10:00:00'),
    ('Maria Oliveira', '98765432109', '11999887766', 'maria.oliveira@example.com', 'Bella', 'Poodle', 3, 15.20, 'Clínico', '2024-06-08', '11:00:00'),
    ('Adenilson da Silva', '45678912396', '11987654321', 'Adenilson@gmail.com', 'Simba', 'Siamês', 2, 7.30, 'Adestramento', '2024-06-09', '12:00:00'),
    ('Maria Silva', '12345678910', '21987654321', 'maria@gmail.com', 'Luna', 'Golden Retriever', 4, 28.00, 'Serviços de hospedagem', '2024-06-10', '13:00:00'),
    ('João dos Santos', '98765432111', '3199998888', 'joao.santos@hotmail.com', 'Thor', 'Bulldog', 1, 20.00, 'Transporte', '2024-06-11', '14:00:00');

