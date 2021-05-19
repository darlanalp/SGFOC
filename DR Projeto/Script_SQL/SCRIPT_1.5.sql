CREATE TABLE DRCOTAS
(
 CODIGOPRJ    INT NOT NULL,
 IDCOTA       INT NOT NULL,
 DESCRICAO    varchar(100),
 OBSERVACAO   varchar(240),
 VALORPREVISTO DECIMAL(15, 4),
 PERCENTUAPROJETO DECIMAL(15, 4)
  CONSTRAINT PKDRCOTAS PRIMARY KEY (CODIGOPRJ,IDCOTA)
)

GO

ALTER TABLE DRCOTAS ADD CONSTRAINT FKDRCOTAS_DRPROJETO FOREIGN KEY(CODIGOPRJ)
REFERENCES DRPROJETO (CODIGOPRJ)

GO
ALTER TABLE DROBRAINVESTIDOR ADD IDCOTA INT 

GO

ALTER TABLE DROBRAINVESTIDOR ADD CONSTRAINT FKDRCOTAS_DROBRAINVESTIDOR FOREIGN KEY(CODIGOPRJ,IDCOTA)
REFERENCES DRCOTAS (CODIGOPRJ,IDCOTA)



