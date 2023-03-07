# Wa ToDolist Server

### Uma lista de afazeres feita com DotNet, EntityFramework e Postgresql .
### Feita em conjunto com a api [web-wa-todolist](https://github.com/Feelpe/web-wa-todolist).

## Executando o Projeto Localmente 

### Depende de
dotnet
docker/postgresql ou pgadmin

### Em um terminal no diretório do projeto, execute os seguintes comandos:

```bash
  > dotnet restore
  > dotnet ef migrations add InitialCreate
  > dotnet ef database update
```

Após iniciar a aplicação abra este link [https://localhost:7012/swagger](https://localhost:7012/swagger) para ver em seu browser.
