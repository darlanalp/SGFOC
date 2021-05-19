/****** OBJECT:  TABLE [DBO].[DRFILTRO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRFILTRO](
	[IDFILTRO] [INT] NOT NULL,
	[IDUSUARIO] [INT] NULL,
	[NOMECLASSE] [VARCHAR](100) NULL,
	[TABELA] [NCHAR](50) NULL,
	[DESCRICAO] [VARCHAR](50) NULL,
	[ATIVO] [BIT] NULL,
	[IDSEGFORM] [INT] NULL,
 CONSTRAINT [PK_DRFILTRO] PRIMARY KEY CLUSTERED 
(
	[IDFILTRO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DREMPRESA]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DREMPRESA](
	[IDEMPRESA] [INT] NOT NULL,
	[NOME] [VARCHAR](60) NULL,
	[ENDERECO] [VARCHAR](50) NULL,
	[NUMERO] [INT] NULL,
	[COMPLEMENTO] [VARCHAR](15) NULL,
	[TELEFONE1] [VARCHAR](13) NULL,
	[TELEFONE2] [VARCHAR](60) NULL,
	[BAIRRO] [VARCHAR](40) NULL,
	[CIDADE] [VARCHAR](50) NULL,
	[ESTADO] [VARCHAR](2) NULL,
	[CEP] [VARCHAR](13) NULL,
	[LOGO] [VARBINARY](MAX) NULL,
	[EMAIL] [VARCHAR](60) NULL,
 CONSTRAINT [PKDREMPRESA] PRIMARY KEY CLUSTERED 
(
	[IDEMPRESA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRFORNECEDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRFORNECEDOR](
	[CODFORNECEDOR] [INT] NOT NULL,
	[NOMEFANTASIA] [VARCHAR](60) NULL,
	[NOME] [VARCHAR](60) NULL,
	[PFISICAJURIDICA] [CHAR](1) NULL,
	[CPFCNPJ] [VARCHAR](20) NULL,
	[CEP] [VARCHAR](9) NULL,
	[ENDERECO] [VARCHAR](60) NULL,
	[NUMERO] [VARCHAR](8) NULL,
	[COMPLEMENTO] [VARCHAR](30) NULL,
	[BAIRRO] [VARCHAR](60) NULL,
	[CIDADE] [VARCHAR](60) NULL,
	[ESTADO] [CHAR](10) NULL,
	[TELEFONE] [VARCHAR](15) NULL,
	[CELULAR] [VARCHAR](15) NULL,
	[FAX] [VARCHAR](15) NULL,
	[EMAIL] [VARCHAR](60) NULL,
	[CONTATO] [VARCHAR](60) NULL,
 CONSTRAINT [PK_DRFORNECEDOR] PRIMARY KEY CLUSTERED 
(
	[CODFORNECEDOR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRINVESTIDORES]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRINVESTIDORES](
	[CODINVESTIDOR] [INT] NOT NULL,
	[NOME] [VARCHAR](60) NULL,
	[CPF] [VARCHAR](20) NULL,
	[RG] [VARCHAR](20) NULL,
	[CEP] [VARCHAR](9) NULL,
	[ENDERECO] [VARCHAR](60) NULL,
	[NUMERO] [VARCHAR](8) NULL,
	[COMPLEMENTO] [VARCHAR](30) NULL,
	[BAIRRO] [VARCHAR](60) NULL,
	[CIDADE] [VARCHAR](60) NULL,
	[ESTADO] [CHAR](10) NULL,
	[TELEFONE] [VARCHAR](15) NULL,
	[CELULAR] [VARCHAR](15) NULL,
	[FAX] [VARCHAR](15) NULL,
	[EMAIL] [VARCHAR](60) NULL,
	[DATANASCIMENTO] [DATETIME] NULL,
	[OBS] [VARCHAR](200) NULL,
 CONSTRAINT [PK_DRINVESTIDORES] PRIMARY KEY CLUSTERED 
(
	[CODINVESTIDOR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRUSUARIO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRUSUARIO](
	[IDUSUARIO] [INT] IDENTITY(1,1) NOT NULL,
	[NOME] [VARCHAR](60) NULL,
	[USUARIO] [VARCHAR](10) NULL,
	[SENHA] [VARCHAR](10) NULL,
	[USUARIOSUPERVISOR] [BIT] NULL,
	[LOGACODIGOPRJ] [INT] NULL,
 CONSTRAINT [PK_DRUSUARIO] PRIMARY KEY CLUSTERED 
(
	[IDUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRGERAAUTOINC]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRGERAAUTOINC](
	[IDAUTOINC] [INT] IDENTITY(1,1) NOT NULL,
	[IDENTIFICADOR] [VARCHAR](60) NULL,
	[VALOR] [INT] NULL,
 CONSTRAINT [PK_DRGERAAUTOINC] PRIMARY KEY CLUSTERED 
(
	[IDAUTOINC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRPROJETO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRPROJETO](
	[CODIGOPRJ] [INT] NOT NULL,
	[NOME] [VARCHAR](60) NULL,
	[DATAINICIO] [DATETIME] NULL,
	[DATAFIN] [DATETIME] NULL,
	[ENDERECO] [VARCHAR](50) NULL,
	[NUMERO] [INT] NULL,
	[COMPLEMENTO] [VARCHAR](15) NULL,
	[BAIRRO] [VARCHAR](40) NULL,
	[CIDADE] [VARCHAR](50) NULL,
	[ESTADO] [VARCHAR](2) NULL,
	[CEP] [VARCHAR](13) NULL,
 CONSTRAINT [PK_DRPROJETO] PRIMARY KEY CLUSTERED 
(
	[CODIGOPRJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRFILTROCONDICAO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRFILTROCONDICAO](
	[IDFILTRO] [INT] NOT NULL,
	[IDLINHA] [INT] NOT NULL,
	[CONDICAO] [VARCHAR](100) NULL,
	[CONDICAOVISUALIZADA] [VARCHAR](100) NULL,
	[TIPOCAMPO] [VARCHAR](30) NULL,
	[DESCRICAO] [VARCHAR](100) NULL,
	[OPERADOR] [VARCHAR](50) NULL,
 CONSTRAINT [PK_DRFILTROCONDICAO] PRIMARY KEY CLUSTERED 
(
	[IDFILTRO] ASC,
	[IDLINHA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRETAPA]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRETAPA](
	[CODIGOPRJ] [INT] NOT NULL,
	[CODETAPA] [VARCHAR](25) NOT NULL,
	[DESCRICAO] [VARCHAR](60) NULL,
	[MOSTRARGRAFICO] [BIT] NULL,
 CONSTRAINT [PK_DRETAPA] PRIMARY KEY CLUSTERED 
(
	[CODIGOPRJ] ASC,
	[CODETAPA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRATIVIDADE]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRATIVIDADE](
	[CODIGOPRJ] [INT] NOT NULL,
	[CODATIVIDADE] [VARCHAR](25) NOT NULL,
	[CODETAPA] [VARCHAR](25) NOT NULL,
	[DESCRICAO] [VARCHAR](60) NOT NULL,
	[OBSERVACAO] [VARCHAR](100) NULL,
	[DATAINI] [DATETIME] NULL,
	[DATATERMINO] [DATETIME] NULL,
	[UNIDADE] [VARCHAR](5) NULL,
	[QTD] [FLOAT] NULL,
	[PRECOUNITARIOMATERIAL] [NUMERIC](15, 2) NULL,
	[PRECOUNITARIOMAOOBRA] [NUMERIC](15, 2) NULL,
	[TOTAL] [NUMERIC](15, 2) NULL,
	[STATUS] [CHAR](1) NOT NULL,
	[PERCENTUALCOMPLETUDE] [SMALLINT] NULL,
	[TOTALGERAL] [NUMERIC](15, 2) NULL,
 CONSTRAINT [PK_DRATIVIDADE] PRIMARY KEY CLUSTERED 
(
	[CODIGOPRJ] ASC,
	[CODATIVIDADE] ASC,
	[CODETAPA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRDESPESA]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRDESPESA](
	[CODIGOPRJ] [INT] NOT NULL,
	[IDDESPESA] [INT] NOT NULL,
	[CODETAPA] [VARCHAR](25) NOT NULL,
	[CODFORNECEDOR] [INT] NULL,
	[DESCRICAO] [VARCHAR](60) NULL,
	[OBSERVACAO] [VARCHAR](150) NULL,
	[STATUS] [CHAR](1) NULL,
	[DATAINCLUSAO] [DATETIME] NOT NULL,
	[DATAPAG] [DATETIME] NULL,
	[VALOR] [NUMERIC](15, 2) NULL,
	[NUMERONOTA] [VARCHAR](20) NULL,
	[CODATIVIDADE] [VARCHAR](25) NOT NULL,
	[USUARIOINCLU] [VARCHAR](10) NOT NULL,
	[USUARIOAPROVACAO] [VARCHAR](10) NULL,
	[TIPODESPESA] [SMALLINT] NULL,
 CONSTRAINT [PK_DRDESPESA] PRIMARY KEY CLUSTERED 
(
	[CODIGOPRJ] ASC,
	[IDDESPESA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DROBRAINVESTIDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DROBRAINVESTIDOR](
	[CODINVESTIDOR] [INT] NOT NULL,
	[CODIGOPRJ] [INT] NOT NULL,
	[VALORPREVISTOINVESTI] [NUMERIC](15, 2) NULL,
	[APARTAMENTO] [VARCHAR](40) NULL,
	[PERCENTADQUIRIDO] [FLOAT] NULL,
 CONSTRAINT [PK_DROBRAINVESTIDOR_] PRIMARY KEY CLUSTERED 
(
	[CODINVESTIDOR] ASC,
	[CODIGOPRJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  TABLE [DBO].[DRPAGAMENTOINVESTIDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [DBO].[DRPAGAMENTOINVESTIDOR](
	[IDPAGAMENTO] [INT] NOT NULL,
	[CODINVESTIDOR] [INT] NOT NULL,
	[CODIGOPRJ] [INT] NOT NULL,
	[VALOR] [NUMERIC](15, 2) NULL,
	[DATAPAG] [DATETIME] NULL,
	[OBS] [VARCHAR](100) NULL,
	[STATUS] [CHAR](1) NULL,
	[USUARIOINCLU] [VARCHAR](10) NULL,
	[USUARIOAPROV] [VARCHAR](10) NULL,
	[DATAAPROVACAO] [DATETIME] NULL,
 CONSTRAINT [PK_DRPAGAMENTOINVESTIDOR] PRIMARY KEY CLUSTERED 
(
	[IDPAGAMENTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** OBJECT:  FOREIGNKEY [FK_DRATIVIDADE_DRETAPA]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DRATIVIDADE]  WITH CHECK ADD  CONSTRAINT [FK_DRATIVIDADE_DRETAPA] FOREIGN KEY([CODIGOPRJ], [CODETAPA])
REFERENCES [DBO].[DRETAPA] ([CODIGOPRJ], [CODETAPA])
GO
ALTER TABLE [DBO].[DRATIVIDADE] CHECK CONSTRAINT [FK_DRATIVIDADE_DRETAPA]
GO
/****** OBJECT:  FOREIGNKEY [FKDRDESPESA_DRFORNECEDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DRDESPESA]  WITH CHECK ADD  CONSTRAINT [FKDRDESPESA_DRFORNECEDOR] FOREIGN KEY([CODFORNECEDOR])
REFERENCES [DBO].[DRFORNECEDOR] ([CODFORNECEDOR])
GO
ALTER TABLE [DBO].[DRDESPESA] CHECK CONSTRAINT [FKDRDESPESA_DRFORNECEDOR]
GO
/****** OBJECT:  FOREIGNKEY [FK_DRETAPA_DRPROJETO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DRETAPA]  WITH CHECK ADD  CONSTRAINT [FK_DRETAPA_DRPROJETO] FOREIGN KEY([CODIGOPRJ])
REFERENCES [DBO].[DRPROJETO] ([CODIGOPRJ])
GO
ALTER TABLE [DBO].[DRETAPA] CHECK CONSTRAINT [FK_DRETAPA_DRPROJETO]
GO
/****** OBJECT:  FOREIGNKEY [FK_DRFILTRO_DRFILTROCONDICAO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DRFILTROCONDICAO]  WITH NOCHECK ADD  CONSTRAINT [FK_DRFILTRO_DRFILTROCONDICAO] FOREIGN KEY([IDFILTRO])
REFERENCES [DBO].[DRFILTRO] ([IDFILTRO])
ON DELETE CASCADE
GO
ALTER TABLE [DBO].[DRFILTROCONDICAO] CHECK CONSTRAINT [FK_DRFILTRO_DRFILTROCONDICAO]
GO
/****** OBJECT:  FOREIGNKEY [FK_DROBRAINVESTIDOR_DRINVESTIDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DROBRAINVESTIDOR]  WITH CHECK ADD  CONSTRAINT [FK_DROBRAINVESTIDOR_DRINVESTIDOR] FOREIGN KEY([CODINVESTIDOR])
REFERENCES [DBO].[DRINVESTIDORES] ([CODINVESTIDOR])
GO
ALTER TABLE [DBO].[DROBRAINVESTIDOR] CHECK CONSTRAINT [FK_DROBRAINVESTIDOR_DRINVESTIDOR]
GO
/****** OBJECT:  FOREIGNKEY [FK_DROBRAINVESTIDOR_DRPROJETO]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DROBRAINVESTIDOR]  WITH CHECK ADD  CONSTRAINT [FK_DROBRAINVESTIDOR_DRPROJETO] FOREIGN KEY([CODIGOPRJ])
REFERENCES [DBO].[DRPROJETO] ([CODIGOPRJ])
GO
ALTER TABLE [DBO].[DROBRAINVESTIDOR] CHECK CONSTRAINT [FK_DROBRAINVESTIDOR_DRPROJETO]
GO
/****** OBJECT:  FOREIGNKEY [FKDRPAGAMENTOINVESTIDOR_OBRAINVESTIDOR]    SCRIPT DATE: 11/07/2010 15:10:16 ******/
ALTER TABLE [DBO].[DRPAGAMENTOINVESTIDOR]  WITH CHECK ADD  CONSTRAINT [FKDRPAGAMENTOINVESTIDOR_OBRAINVESTIDOR] FOREIGN KEY([CODINVESTIDOR], [CODIGOPRJ])
REFERENCES [DBO].[DROBRAINVESTIDOR] ([CODINVESTIDOR], [CODIGOPRJ])
GO
ALTER TABLE [DBO].[DRPAGAMENTOINVESTIDOR] CHECK CONSTRAINT [FKDRPAGAMENTOINVESTIDOR_OBRAINVESTIDOR]
GO
