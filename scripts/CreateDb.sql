CREATE DATABASE TorneioLuta
GO

USE TorneioLuta
GO

CREATE TABLE Atleta
(
    Id                      UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    Nome                    VARCHAR(100) NOT NULL,
    Idade                   INT NOT NULL,
    Vitorias                INT NOT NULL,
    Derrotas                INT NOT NULL,
    Lutas                   INT NOT NULL
)

ALTER TABLE Atleta ADD CONSTRAINT PK_ATLETA PRIMARY KEY (Id)

CREATE TABLE ArtesMarciais
(
    Id                      UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    Nome                    VARCHAR(100) NOT NULL
)

ALTER TABLE ArtesMarciais ADD CONSTRAINT PK_ARTESMARCIAIS PRIMARY KEY (Id)

CREATE TABLE Atleta_x_ArtesMarciais
(
    IdAtleta                UNIQUEIDENTIFIER NOT NULL,
    IdArtesMarciais         UNIQUEIDENTIFIER NOT NULL
)

ALTER TABLE Atleta_x_ArtesMarciais ADD CONSTRAINT PK_ATLETA_X_ARTESMARCIAIS PRIMARY KEY (IdAtleta, IdArtesMarciais)
ALTER TABLE Atleta_x_ArtesMarciais ADD CONSTRAINT FK_ATLETA_X_ARTESMARCIAIS FOREIGN KEY (IdAtleta) REFERENCES Atleta (Id)
ALTER TABLE Atleta_x_ArtesMarciais ADD CONSTRAINT FK_ARTESMARCIAIS_X_ATLETA FOREIGN KEY (IdArtesMarciais) REFERENCES ArtesMarciais (Id)