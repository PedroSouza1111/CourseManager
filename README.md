# CourseManager

Projeto .NET para gerenciamento de cursos, utilizando Oracle com EF Core e API RESTful.

## Como rodar

1. Configure a string de conexão Oracle no `appsettings.json`.
2. Rode os comandos:

```bash
dotnet build
dotnet ef migrations add InitialCreate --project CourseManager.Core --startup-project CourseManager.API
dotnet ef database update --project CourseManager.Core --startup-project CourseManager.API
dotnet run --project CourseManager.API
```

Swagger disponível em: `https://localhost:{PORT}/swagger`