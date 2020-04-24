FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
COPY . .
EXPOSE 5000
WORKDIR /WebApplication1
ENTRYPOINT ["dotnet", "restore"]

WORKDIR /XUnitTestProject1
ENTRYPOINT ["dotnet", "restore"]

WORKDIR /ConsoleApp1
ENTRYPOINT ["dotnet", "restore"]

WORKDIR /WebApplication1
ENTRYPOINT ["ls"]
ENTRYPOINT ["dotnet", "run"]
