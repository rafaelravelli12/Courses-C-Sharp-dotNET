# Balta.io Course - Orientação a Objetos em Projetos Reais com C# e .NET 7

![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![image](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

### Estimeed Sirs,

I recommend the course “Orientação a Objetos em Projetos Reais com C# e .NET 7” by André Baltieri.

Skills covered:

Overview:

[Course path](https://balta.io/cursos/aplicando-orientacao-a-objetos-em-projetos-reais-com-csharp-11-e-dotnet-7).

[Course official repository](https://github.com/balta-io/2818) (acessed 16/01/2024).

# Startup terminal commands

System must have dotnet sdk 7.0 installed: https://dotnet.microsoft.com/en-us/download/dotnet/7.0

Installation can be verified by cmd terminal command: dotnet --list-sdks

cmd terminal command: mkdir UtmBuilder

cmd terminal command: dotnet new sln

cmd terminal command: dotnet new classlib -o UtmBuilder.Core --framework net7.0

cmd terminal command: dotnet sln add .\UtmBuilder.Core\

cmd terminal command: dotnet new mstest -o UtmBuilder.Core.Tests --framework net7.0

cmd terminal command: dotnet sln add .\UtmBuilder.Core.Tests\

cmd terminal command: dotnet test

cmd terminal command: dotnet add reference ..\UtmBuilder.Core\

Graciously,
