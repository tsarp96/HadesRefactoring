FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HadesRefactoring/HadesRefactoring.csproj", "HadesRefactoring/"]
RUN dotnet restore "HadesRefactoring/HadesRefactoring.csproj"
COPY . .
WORKDIR "/src/HadesRefactoring"
RUN dotnet build "HadesRefactoring.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HadesRefactoring.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HadesRefactoring.dll"]
