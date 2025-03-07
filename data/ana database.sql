create database Zoologico;
use Zoologico;

CREATE TABLE IF NOT EXISTS Animal (
	id_animal INT PRIMARY KEY AUTO_INCREMENT,
	nome_animal VARCHAR(100) NOT NULL,
	especie VARCHAR(100),
	dataNascimento DATE,
	sexo_animal VARCHAR(20),
    observacao_animal TEXT,
    id_habitat INT NOT NULL,
	FOREIGN KEY (id_habitat) REFERENCES Habitats(id_habitat)
);
CREATE TABLE IF NOT EXISTS Funcionarios (
    id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    nome_func VARCHAR(100) NOT NULL,
    cargo_func VARCHAR(50),
    data_admissao DATE,
    cpf_func VARCHAR(20),
    tel_func VARCHAR(15)
   );
CREATE TABLE IF NOT EXISTS Alimentos (
    id_alimento INT PRIMARY KEY AUTO_INCREMENT,
    nome_alimento VARCHAR(100) NOT NULL,
    tipo_alimento VARCHAR(50),  -- Ex: vegetal, carnivoro, misto, ração seca, ração umida
    quantidade_em_estoque VARCHAR(30),  -- Estoque atual, ex: 30kg, 8 fardos, 7 litros
    validade_alimento DATE,  
    id_fornecedor INT NOT NULL, 
    FOREIGN KEY (id_fornecedor) REFERENCES Fornecedores(id_fornecedor)
);
CREATE TABLE IF NOT EXISTS Fornecedores (
    id_fornecedor INT PRIMARY KEY AUTO_INCREMENT,
    nome_forn VARCHAR(100) NOT NULL,
    cnpj_forn VARCHAR(20),
    tel_forn VARCHAR(15)
);
CREATE TABLE IF NOT EXISTS consultaMedica (
    id_consulta INT PRIMARY KEY AUTO_INCREMENT,
    data_consulta DATE,
    diagnostico TEXT,
    tratamento TEXT,
    id_animal INT NOT NULL,
    id_funcionario INT NOT NULL,  -- O veterinário responsável pela consulta
    FOREIGN KEY (id_animal) REFERENCES Animal(id_animal),
    FOREIGN KEY (id_funcionario) REFERENCES Funcionarios(id_funcionario)
);
CREATE TABLE IF NOT EXISTS Habitats (
    id_habitat INT PRIMARY KEY AUTO_INCREMENT,
    nome_habitat VARCHAR(100),  -- Nome do habitat (Ex: Floresta Amazônica, Recinto Aquático)
    descricao_habitat TEXT,
    tipo_habitat VARCHAR(50),
    tempMin DOUBLE,  -- Temperatura mínima CONSIDERAR SE HAVERÁ
    tempMax DOUBLE  -- Temperatura máxima CONSIDERAR SE HAVERÁ
   );
CREATE TABLE IF NOT EXISTS manutencaoHabitat (
    id_manutencao INT PRIMARY KEY AUTO_INCREMENT,
    data_manutencao DATE,
    descricao TEXT,
    id_habitat INT NOT NULL,
    id_funcionario INT NOT NULL,  -- Funcionario responsável pela manutenção
    FOREIGN KEY (id_habitat) REFERENCES Habitats(id_habitat),
    FOREIGN KEY (id_funcionario) REFERENCES Funcionarios(id_funcionario)
);
CREATE TABLE IF NOT EXISTS Alimentacao (
    id_alimentacao INT AUTO_INCREMENT PRIMARY KEY,
    frequencia VARCHAR(100),
    id_animal INT NOT NULL,
    id_alimento INT NOT NULL,  -- Exemplo de campo para descrever a frequência(ex: "diária", "semanal")
    tipo VARCHAR(50),         -- Exemplo de campo para descrever o tipo(secaa, molhada, carnívora, onívora)
    FOREIGN KEY (id_animal) REFERENCES Animal(id_animal),
    FOREIGN KEY (id_alimento) REFERENCES Alimentos(id_alimento)
);
CREATE TABLE IF NOT EXISTS AnimalHabitat (
    id_animal INT,
    id_habitat INT,
    quantMax INT NOT NULL,
    tipo_animal VARCHAR(50) NOT NULL,
    PRIMARY KEY (id_animal, id_habitat),
    FOREIGN KEY (id_animal) REFERENCES animal(id_animal),
    FOREIGN KEY (id_habitat) REFERENCES habitats(id_habitat)
);

INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Catrina', 'gato', '2020-02-02', 'feminino','gato safado');
INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Laguna', 'peixe boi femea', '2020-04-05', 'feminino','ama brincar');
INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Rodolfo', 'leão', '2010-02-22', 'macho','ter cuidado pois é temperamental');
INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Soso', 'jaguatirica', '2019-03-05', 'femea','cuidar da pelagem com cuidado');
INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Pitico', 'zebra', '2018-02-23', 'macho','dar bastante liquido');
INSERT INTO animal(nome_animal, especie, dataNascimento, sexo_animal, observacao_animal)
 VALUES ('Hilário', 'papagaio', '2021-12-22', 'macho','em tratamento do bico');

INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Dra Luiza',
	 'Médica Veterinária',
	'2020-12-10',          
       	'020.020.222-22',
	69992254530
       );
INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Dr Pablo',
	 'Médico Veterinário',
	'2019-02-15',          
       	'030.453.133-28',
	69999887654
       );
INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Angelina',
	 'Técnica em Zootécnia',
	'2018-12-08',          
       	'846.234.288-12',
	69992567380
       );
INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Fábio',
	 'Técnico em Zootécnia',
	'2018-11-20',          
       '334.026.333-48',
	6984216655
       );
INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Luiz',
	 'Técnico da manutenção',
	'2020-12-10',          
       	'020.020.222-22',
	69992254530
       );
INSERT INTO Funcionarios ( nome_func, cargo_func, data_admissao, cpf_func, tel_func)
VALUES ( 'Rogério',
	 'Auxliar da manutenção',
	'2017-06-17',          
	'023.577.456-44',
	69992443311
       );

INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2025-03-01',              -- Data da consulta
        'Infecção respiratória',   -- Diagnóstico
        'Antibióticos e repouso',  -- Tratamento
         1,                         -- id_animal (referente ao animal com id 1)
         1                          -- id_funcionario (referente ao funcionário com id 1 que será um do médicos veterinarios)
);
INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2025-02-10',              -- Data da consulta
        'Infecção intestinal',   -- Diagnóstico
        'Antibióticos, repouso e dieta rica em liquidos',  -- Tratamento
         3,                         -- id_animal (referente ao animal com id 3)
         2                          -- id_funcionario (referente ao funcionário com id 2 que será um dos médicos veterinatrios)
);
INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2024-11-21',              -- Data da consulta
        'Tártaro',   -- Diagnóstico
        'Limpezabucal e escovação regular dos dentes',  -- Tratamento
         2,                         -- id_animal (referente ao animal com id 1)
         2                          -- id_funcionario (referente ao funcionário com id 2)
);
INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2024-09-11',              -- Data da consulta
        'Insuficiencia respiratória',   -- Diagnóstico
        'Inalação com antibioticos e repouso',  -- Tratamento
         4,                         -- id_animal (referente ao animal com id 1)
         1                          -- id_funcionario (referente ao funcionário com id 2)
);
INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2025-01-12',              -- Data da consulta
        'Intoxicação intestinal',   -- Diagnóstico
        'Analgésicos, repouso e dieta rica em liquidos',  -- Tratamento
         5,                         -- id_animal (referente ao animal com id 1)
         2                          -- id_funcionario (referente ao funcionário com id 2)
);
INSERT INTO consultaMedica (data_consulta, diagnostico, tratamento, id_animal, id_funcionario)
VALUES ('2024-12-21',              -- Data da consulta

        'Dermatite',   -- Diagnóstico
        'Antihistamínicos, xampus de miconazol e limpeza regular',  -- Tratamento
         6,                         -- id_animal (referente ao animal com id 1)
         1                          -- id_funcionario (referente ao funcionário com id 2)
);

INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Recinto Aquático',                   -- Nome do habitat
    'Habitat com água e espaço para animais marinhos.',  -- Descrição do habitat
    'Aquático',                           -- Tipo do habitat
    18.5,                                   -- Temperatura mínima
    28.8                                    -- Temperatura máxima
);
INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Floresta Amazônica',                   -- Nome do habitat
    'Habitat com variedade de arvores para animais silvestres.',  -- Descrição do habitat
    'Floresta',                           -- Tipo do habitat
    23.5,                                   -- Temperatura mínima
    31.0                                   -- Temperatura máxima
);
INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Savana Africana',                   -- Nome do habitat
    'Área de pastagem com clima quente e seco para animais originários de tais regiões.',  -- Descrição do habitat
    'Terrestre',                           -- Tipo do habitat
    24.0,                                   -- Temperatura mínima
    36.8                                    -- Temperatura máxima
);
INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Savana Africana (animais não carnivoros)',                   -- Nome do habitat
    'Área de pastagem com clima quente e seco para animais silvestres da savana.',  -- Descrição do habitat
    'Terrestre',                           -- Tipo do habitat
    24.0,                                   -- Temperatura mínima
    36.8                                    -- Temperatura máxima
);
INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Tundra Ártica',                   -- Nome do habitat
    'Habitat gelado com vegetação rasteira para animais de regiões frias/polares.',  -- Descrição do habitat
    'Polar',                           -- Tipo do habitat
    -30.0,                                   -- Temperatura mínima
    -5.0                                    -- Temperatura máxima
);
INSERT INTO habitats ( nome_habitat, descricao_habitat, tipo_habitat, tempMin, tempMax)
VALUES (
    'Ambiente doméstico',                   -- Nome do habitat
    'Habitat com temperatura e modulariação ideal para animais domésticos.',  -- Descrição do habitat
    'Doméstico',                           -- Tipo do habitat
    20.0,                                   -- Temperatura mínima
    26.0                                    -- Temperatura máxima
);

INSERT INTO manutencaoHabitat (data_manutencao, descricao, id_habitat, id_funcionario)
VALUES ('2025-03-01', 'Limpeza da área e verificação do sistema de filtragem da água.', 1, 5);
INSERT INTO manutencaoHabitat (data_manutencao, descricao,id_habitat, id_funcionario)
VALUES ('2025-03-05', 'Poda de árvores e revisão das cercas de proteção.', 2, 6);
INSERT INTO manutencaoHabitat (data_manutencao, descricao,id_habitat, id_funcionario)
VALUES ('2025-03-10', 'Reparo nas cercas de arame farpado e revisão das fontes de água.', 3, 6);
INSERT INTO manutencaoHabitat (data_manutencao, descricao, id_habitat, id_funcionario)
VALUES ('2025-03-15', 'Verificação dos sistemas de aquecimento e limpeza das áreas de alimentação.', 4, 5);
INSERT INTO manutencaoHabitat (data_manutencao, descricao, id_habitat, id_funcionario)
VALUES ('2025-02-15', 'Verificação dos sistemas de alimentaçaõ e forragem térmica.', 5, 6);

INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Joaquim Silva', '12.345.678/0001-90', '(11) 1234-5678', 'Rações Fanfarrão Ltda');
INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Marieta Salvador', '23.456.789/0001-12', '(21) 9876-5432', 'Carnes Vaquinha Feliz Ltda');
INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Orácio Valdes', '34.567.890/0001-23', '(31) 4567-8901', 'Horta Viva');
INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Luciana Monteiro', '45.678.901/0001-34', '(41) 2345-6789', 'Natureza em Grãos');
INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Rogério Paulo Oliveira', '56.789.012/0001-45', '(51) 3456-7890', 'NutriVita');
INSERT INTO fornecedores (nome_forn, cnpj_forn, tel_forn, nome_fantasia)
VALUES ('Valéria Santos', '67.890.123/0001-56', '(61) 4567-1234', 'Mundo das Frutas');

INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Mix de Hortaliças Horta Viva', 'Hortaliças', '50kg', '2025-12-31', 3);
INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Maçãs Verdes Mundo das Frutas', 'Frutas', '30kg', '2025-10-20', 6);
INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Suculentas Vegetais Horta Viva', 'Vegetal', '20kg', '2025-03-10', 3);
INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Carne Bovina Carnes Vaquinha Feliz', 'Carnes', '15kg', '2025-04-05', 2);
INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Mistura de Grãos Natureza em Grãos', 'Sementes', '12kg', '2025-06-25', 4);
INSERT INTO alimentos (nome_alimento, tipo_alimento, quantidade_em_estoque, validade_alimento, id_fornecedor)
VALUES ('Ração para Peixes Rações Fanfarrão', 'Ração Seca', '40kg', '2025-11-15', 1);

INSERT INTO Alimentacao (id_animal, id_alimento, frequencia, tipo)
VALUES (13, 2, 'Diária', 'Carnivora');
INSERT INTO  Alimentacao  (id_animal, id_alimento, frequencia, tipo)
VALUES (9, 3, 'Diária', 'Hortaliças');
INSERT INTO  Alimentacao  (id_animal, id_alimento, frequencia, tipo)
VALUES (12, 1, 'Diária', 'Ração seca');
INSERT INTO  Alimentacao  (id_animal, id_alimento, frequencia, tipo)
VALUES (11, 5, 'Quinzenal', 'Vitaminas');
INSERT INTO  Alimentacao  (id_animal, id_alimento, frequencia, tipo)
VALUES (14, 6, 'Semanal', 'Frutas');
INSERT INTO  Alimentacao  (id_animal, id_alimento, frequencia, tipo)
VALUES (14, 4, 'Diária', 'Sementes');

INSERT INTO animalHabitat (id_animal, id_habitat, quantMax, tipo_animal)
VALUES (13, 101, 15, 'animais de médio porte de área florestal');
INSERT INTO animalHabitat (id_animal, id_habitat, quantMax, tipo_animal)
VALUES (9, 4, 40, 'animais aquáticos');
INSERT INTO animalHabitat (id_animal, id_habitat, quantMax, tipo_animal)
VALUES (8, 5, 12, 'animais domésticos');
INSERT INTO animalHabitat (id_animal, id_habitat, quantMax, tipo_animal)
VALUES (11, 2, 7, 'animais silvestres carnivoros');
INSERT INTO animalHabitat (id_animal, id_habitat, quantMax, tipo_animal)
VALUES (12, 6, 8, 'animais silvestres não carnivoros');


select * from habitats;


drop table Funcionarios;
DESC habitats;