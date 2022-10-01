/****** Object:  Table [dbo].[Paciente]    Script Date: 11/07/2015 10:01:36 ******/

CREATE TABLE [dbo].[Paciente](
	[idPaciente] [int] NOT NULL,
	[Nome] [varchar](50) NULL,
	[Telefone] [varchar](15) NULL,
	[Sexo] [char](1) NULL,
	[Convenio] [varchar](20) NULL,
	[DataNascimento] [datetime] NULL,
	[Profissao] [varchar](20) NULL,
	[TipoSangue] [varchar](5) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

