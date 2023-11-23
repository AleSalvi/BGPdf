CREATE TABLE [dbo].[Users](
	[Uid] [uniqueidentifier] NOT NULL DEFAULT (NEWID())
	,[Id] [int] IDENTITY(1,1) NOT NULL
	,[Nome] VARCHAR(255) NULL
	,[Cognome] VARCHAR(255) NULL
	,[CodiceFiscale] VARCHAR(16) NOT NULL
	,[Data_nascita] DATETIME NULL
	,[Cap_nascita] VARCHAR(5) NULL
	,[Comune_nascita] VARCHAR(255) NULL
	,[Provincia_nascita] VARCHAR(2) NULL
	,[Indirizzo_residenza] VARCHAR(255) NULL
	,[Cap_residenza] VARCHAR(5) NULL
	,[Comune_residenza] VARCHAR(255) NULL
	,[Provincia_residenza] VARCHAR(2) NULL
	,[Numero_porto_armi] VARCHAR(255) NULL
	,[Data_rilascio_porto_armi] DATETIME NULL
	,[Sezione] VARCHAR(1) NULL
	,[Data_pagamento] DATETIME NULL
	,[Numero] INT NULL
	,[Tipo] VARCHAR(255) NULL
	,[Telefono] VARCHAR(20) NULL
	,[Cellulare_whatsapp] VARCHAR(20) NULL
	,[Mail] VARCHAR(255) NULL
	,[UserInsert] VARCHAR(50) NOT NULL  DEFAULT (suser_sname())
	,[UserUpdate] VARCHAR(50) NOT NULL  DEFAULT (suser_sname())
	,[TimeInsert] DATETIME NOT NULL DEFAULT (getdate())
	,[TimeUpdate] DATETIME NOT NULL DEFAULT (getdate())
CONSTRAINT [PK_Users] PRIMARY KEY NONCLUSTERED 
	(
		[Uid] ASC
	),
	 CONSTRAINT [IK_Users] UNIQUE CLUSTERED 
	(
		[Id] ASC
	)
)
CREATE PROCEDURE [dbo].[Api_Users_Edit]
	@Uid uniqueidentifier
	,@Nome  VARCHAR(255)
	,@Cognome  VARCHAR(255) 
	,@CodiceFiscale  VARCHAR(255)
	,@Data_nascita  DATETIME 
	,@Cap_nascita  VARCHAR(255) 
	,@Comune_nascita  VARCHAR(255)
	,@Provincia_nascita  VARCHAR(255) 
	,@Indirizzo_residenza  VARCHAR(255)
	,@Cap_residenza  VARCHAR(255) 
	,@Comune_residenza  VARCHAR(255) 
	,@Provincia_residenza  VARCHAR(255)
	,@Numero_porto_armi  VARCHAR(255)
	,@Data_rilascio_porto_armi  DATETIME 
	,@Sezione  VARCHAR(255) 
	,@Data_pagamento  DATETIME 
	,@Numero  INT 
	,@Tipo  VARCHAR(255) 
	,@Telefono  VARCHAR(255) 
	,@Cellulare_whatsapp  VARCHAR(255)
	,@Mail  VARCHAR(255) 
AS
BEGIN	
IF (EXISTS(SELECT [Uid] FROM [Users] WHERE [Uid] = @Uid))
	BEGIN
		UPDATE [Users]
		SET
			[Nome] = @Nome
			,[Cognome] = @Cognome
			,[CodiceFiscale] = @CodiceFiscale
			,[Data_nascita] = @Data_nascita
			,[Cap_nascita] = @Cap_nascita
			,[Comune_nascita] = @Comune_nascita
			,[Provincia_nascita] = @Provincia_nascita
			,[Indirizzo_residenza] = @Indirizzo_residenza
			,[Cap_residenza] = @Cap_residenza
			,[Comune_residenza] = @Comune_residenza
			,[Provincia_residenza] = @Provincia_residenza
			,[Numero_porto_armi] = @Numero_porto_armi
			,[Data_rilascio_porto_armi] = @Data_rilascio_porto_armi
			,[Sezione] = @Sezione
			,[Data_pagamento] = @Data_pagamento
			,[Numero] = @Numero
			,[Tipo] = @Tipo
			,[Telefono] = @Telefono
			,[Cellulare_whatsapp] = @Cellulare_whatsapp
			,[Mail] = @Mail
			,UserUpdate	= SUSER_SNAME()
			,TimeUpdate	= GETDATE()
		WHERE [CodiceFiscale] = @CodiceFiscale
	END
ELSE
	BEGIN		
		INSERT INTO [Users]
		(
			Uid
			,Nome
			,Cognome
			,CodiceFiscale
			,Data_nascita
			,Cap_nascita
			,Comune_nascita
			,Provincia_nascita
			,Indirizzo_residenza
			,Cap_residenza
			,Comune_residenza
			,Provincia_residenza
			,Numero_porto_armi
			,Data_rilascio_porto_armi
			,Sezione
			,Data_pagamento
			,Numero
			,Tipo
			,Telefono
			,Cellulare_whatsapp
			,Mail
			,UserInsert
			,TimeInsert
			,UserUpdate
			,TimeUpdate
		)
		VALUES
		(
			NEWID()
			,@Nome
			,@Cognome
			,@CodiceFiscale
			,@Data_nascita
			,@Cap_nascita
			,@Comune_nascita
			,@Provincia_nascita
			,@Indirizzo_residenza
			,@Cap_residenza
			,@Comune_residenza
			,@Provincia_residenza
			,@Numero_porto_armi
			,@Data_rilascio_porto_armi
			,@Sezione
			,@Data_pagamento
			,@Numero
			,@Tipo
			,@Telefono
			,@Cellulare_whatsapp
			,@Mail
			,SUSER_SNAME()
			,GETDATE()
			,SUSER_SNAME()
			,GETDATE()
		)
	END

	SELECT 
		Uid
		,Nome
		,Cognome
		,CodiceFiscale
		,Data_nascita
		,Cap_nascita
		,Comune_nascita
		,Provincia_nascita
		,Indirizzo_residenza
		,Cap_residenza
		,Comune_residenza
		,Provincia_residenza
		,Numero_porto_armi
		,Data_rilascio_porto_armi
		,Sezione
		,Data_pagamento
		,Numero
		,Tipo
		,Telefono
		,Cellulare_whatsapp
		,Mail
	FROM [Users]

END
GO

CREATE PROCEDURE [Api_Users_GetAll]
AS
BEGIN
	SELECT  
		Uid
		,Nome
		,Cognome
		,CodiceFiscale
		,Data_nascita
		,Cap_nascita
		,Comune_nascita
		,Provincia_nascita
		,Indirizzo_residenza
		,Cap_residenza
		,Comune_residenza
		,Provincia_residenza
		,Numero_porto_armi
		,Data_rilascio_porto_armi
		,Sezione
		,Data_pagamento
		,Numero
		,Tipo
		,Telefono
		,Cellulare_whatsapp
		,Mail
	FROM [Users] 
END 
GO

CREATE PROCEDURE [Api_Users_GetByUid]
	@Uid UNIQUEIDENTIFIER
AS
BEGIN
	SELECT  
		Uid
		,Nome
		,Cognome
		,CodiceFiscale
		,Data_nascita
		,Cap_nascita
		,Comune_nascita
		,Provincia_nascita
		,Indirizzo_residenza
		,Cap_residenza
		,Comune_residenza
		,Provincia_residenza
		,Numero_porto_armi
		,Data_rilascio_porto_armi
		,Sezione
		,Data_pagamento
		,Numero
		,Tipo
		,Telefono
		,Cellulare_whatsapp
		,Mail
	FROM [Users] 
	WHERE Uid = @Uid
END 
GO

CREATE PROCEDURE [Api_Users_Delete]
	@Uid UNIQUEIDENTIFIER
AS
BEGIN				
	DELETE Users
	WHERE [Uid] = @Uid		
END