# .NET Wa ToDo List

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)

## Description

A simple ToDo list application built with .NET, Entity Framework, and PostgreSQL.

## Usage

This is a simple ToDo application.

- You can add a new task.
- Mark tasks as completed.
- Remove tasks.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET SDK
- PostgreSQL or Docker

### Installation

1. Clone the repository

   ```git
   git clone https://github.com/Feelpe/dotnet-wa-todolist.git
   ```

2. Enter the project directory:

   ```powershell
   cd dotnet-wa-todolist
   ```

3. Install the dependencies:

   ```powershell
   dotnet restore
   ```

4. Set up your PostgreSQL database.

   - Modify the `appsettings.json` file with your database connection details or just leave it how it is and use the docker compose database with the following code:

   ```docker
   docker compose up
   ```

5. Apply the database migrations:

   ```powershell
   dotnet ef database update
   ```

6. Run the application:

   ```powershell
   dotnet run
   ```

7. The application will be available at [https://localhost:7012/swagger](https://localhost:7012/swagger) in your browser.
