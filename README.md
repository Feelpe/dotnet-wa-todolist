# Wa ToDolist Backend

### Uma lista de afazeres feita com DotNet, EntityFramework e Postgresql .
### Feita em conjunto com a api [wa-todolist-frontend](https://github.com/Feelpe/wa-todolist-frontend).

## Executando o Projeto Localmente 

### Depende de
dotnet

### Em um terminal no diretório projeto, execute os seguintes comandos:

```bash
  > dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  > dotnet add package Microsoft.EntityFrameworkCore.Sqlite
  > dotnet restore
  > dotnet ef migrations add InitialCreate
  > dotnet ef database update
```

Após iniciar a aplicação abra este link [https://localhost:7012/swagger](https://localhost:7012/swagger) para ver em seu browser.
