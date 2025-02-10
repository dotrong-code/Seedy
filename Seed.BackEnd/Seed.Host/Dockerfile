#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Seed.Host/Seed.Host.csproj", "Seed.Host/"]
COPY ["Seed.Application/Seed.Application.csproj", "Seed.Application/"]
COPY ["Seed.Domain/Seed.Domain.csproj", "Seed.Domain/"]
COPY ["Seed.Infrastructure/Seed.Infrastructure.csproj", "Seed.Infrastructure/"]
RUN dotnet restore "./Seed.Host/Seed.Host.csproj"
COPY . .
WORKDIR "/src/Seed.Host"
RUN dotnet build "./Seed.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Seed.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Seed.Host.dll"]