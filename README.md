# .NET ToDo List

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)

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

   ```git
   git clone https://github.com/Feelpe/dotnet-todolist.git
   ```

2. Enter the project directory:

   ```powershell
   cd dotnet-todolist
   ```

3. Set up your PostgreSQL database. Modify the `appsettings.json` file with your database connection details.

4. Apply the database migrations:

   ```powershell
   dotnet ef database update
   ```

5. Run the application:

   ```powershell
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

<!-- protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Task>().ToTable("Tasks");
} -->

   <!-- ```bash
  > dotnet restore
  > dotnet ef migrations add InitialCreate
  > dotnet ef database update
   ``` -->
