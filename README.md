# .NET ToDo List

## Description
A simple ToDo list application built with .NET, Entity Framework, and PostgreSQL.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
- .NET SDK
- PostgreSQL
- VScode

### Installation

1. Clone the repository

```
git clone https://github.com/Feelpe/dotnet-todolist.git
```

2. Enter the project directory:

```
cd dotnet-todolist
```

```bash
  > dotnet restore
  > dotnet ef migrations add InitialCreate
  > dotnet ef database update
```

3. Set up your PostgreSQL database. Modify the `appsettings.json` file with your database connection details.

4. Apply the database migrations:

```
dotnet ef database update
```

5. Run the application:

```
dotnet run
```

6. The application will be available at [https://localhost:7012/swagger](https://localhost:7012/swagger) in your browser.

## Usage

This is a simple ToDo application.

- You can add a new task.
- Mark tasks as completed.
- Remove tasks.

## License

This project is licensed under the terms of the MIT license.
