# InformacoesAPI
Curso Indra .NET

### Correção Sumary

* Clicar o botão direito do mouse em cima do projeto, Gerenciador de Pacotes Nuget e instalar "Swashbuckle.AspNetCore"

* Clicar duas vezes em cima do projeto e adicionar codigo abaixo:

    
    <PropertyGroup>
		<GenerateDocumentationFile>true</GenerateDocumentationFile>
		<NoWarn>$(NoWarm);1591</NoWarn>
	</PropertyGroup>
    
	
* Em startup.cs, no método ConfigureServices, corrigir o o codigo abaixo:
    
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InformacoesAPI", Version = "v1" });
                var fileName = $"{ Assembly.GetExecutingAssembly().GetName().Name }.xml";
                var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
                c.IncludeXmlComments(filePath);
            });
    	
