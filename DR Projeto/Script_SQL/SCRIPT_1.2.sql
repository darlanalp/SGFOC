ALTER TABLE DRDESPESA ALTER COLUMN CODETAPA VARCHAR(25)  NULL
GO
ALTER TABLE DRDESPESA ALTER COLUMN CODATIVIDADE VARCHAR(25)  NULL
GO

CREATE TABLE DRPATRIMONIO(
	CODIGOPRJ	    INTEGER NOT NULL,
	IDPATRIMONIO    INTEGER NOT NULL,	
	CODETAPA        VARCHAR(25),
	CODATIVIDADE    VARCHAR(25),
	CODFORNECEDOR   INTEGER,
	DATAAQUISICAO   DATETIME NOT NULL,
	PATRIMONIO      VARCHAR(100),
	QTDPAT          INT,
	VALORAQUISICAO	NUMERIC(18, 4) NOT NULL,
	VALORTOTAL      NUMERIC(18, 4) NOT NULL,
	OBSERVACAO	    VARCHAR(100),
CONSTRAINT PKDRPATRIMONIO PRIMARY KEY(CODIGOPRJ,IDPATRIMONIO))
GO
ALTER TABLE DRPATRIMONIO ADD CONSTRAINT FKDRPATRIMONIO_DRATIVIDADE FOREIGN KEY (CODIGOPRJ, CODATIVIDADE, CODETAPA)
REFERENCES DRATIVIDADE(CODIGOPRJ, CODATIVIDADE, CODETAPA)
GO
ALTER TABLE DRPATRIMONIO ADD CONSTRAINT FKDRPATRIMONIO_DRFORNECEDOR FOREIGN KEY (CODFORNECEDOR)
REFERENCES DRFORNECEDOR(CODFORNECEDOR)
GO
CREATE TABLE DRRENDIMENTO(
	CODIGOPRJ	    INTEGER NOT NULL,
	IDRENDIMENTO    INTEGER NOT NULL,	
	VALORRENDIMENTO	NUMERIC(18, 4) NOT NULL,
	MES             SMALLINT,
	DATAAPURACAO    DATETIME,	
    CONSTRAINT PKDRRENDIMENTO PRIMARY KEY(CODIGOPRJ,IDRENDIMENTO)
)
GO
ALTER TABLE DRRENDIMENTO ADD CONSTRAINT FKDRRENDIMENTO_DRPROJETO FOREIGN KEY (CODIGOPRJ)
REFERENCES DRPROJETO(CODIGOPRJ)
