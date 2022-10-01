/****** Object:  Table [dbo].[Consulta]    Script Date: 11/07/2015 10:01:49 ******/

CREATE TABLE [dbo].[Consulta](
	[idConsulta] [int] NOT NULL,
	[idPaciente] [int] NULL,
	[DataConsulta] [datetime] NULL,
	[NomeMedico] [varchar](50) NULL,
	[ExamesRealizados] [text] NULL,
	[MedicamentosUtilizados] [text] NULL,
	[Alergico] [char](1) NULL,
	[Historico] [text] NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[idConsulta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])

ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Paciente]


