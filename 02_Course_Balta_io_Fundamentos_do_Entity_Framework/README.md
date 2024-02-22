# Balta.io Course - Fundamentos do Entity Framework

![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![image](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

### Estimeed Sirs,

I recommend the course “Fundamentos do Entity Framework” by André Baltieri.

Skills covered: .NET Core 5, Entity Framework Operations and SQL Server.

Overview: The course will explain some Entity Framework fundamentals, like modeling, mapping, running migrations and creating sql scripts.

[Course path](https://balta.io/cursos/fundamentos-entity-framework) (acessed 16/01/2024).

[Course official repository](https://github.com/balta-io/2808) (acessed 16/01/2024).

# Startup terminal commands

System must have dotnet sdk 5.0 installed: https://dotnet.microsoft.com/en-us/download/dotnet/5.0

Installation can be verified by cmd terminal command: dotnet --list-sdks

cmd startup terminal command: dotnet new console -n Blog --framework net5.0

cmd run program: dotnet build

cmd run program: dotnet run

cmd run program: dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9

cmd run program: dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9

cmd run program: dotnet tool install --global dotnet-ef

cmd run program: dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9

cmd run program: dotnet ef migrations add InitialCreation

cmd run program: dotnet ef database update

cmd run program: dotnet ef migrations script -o ./script.sql

Graciously,
