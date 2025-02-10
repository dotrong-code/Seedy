# Start with the SQL Server base image
FROM mcr.microsoft.com/mssql/server:latest AS sqlserver

# Switch to the root user to install sudo
USER root

# Update the package list and install sudo
RUN apt-get update && apt-get install -y sudo

# Switch back to mssql user after installing sudo
USER mssql




FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# First copy everything
COPY . .

# Then do a clean restore and build
RUN dotnet restore "Seed.Host/Seed.Host.csproj"
RUN dotnet build "Seed.Host/Seed.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Seed.Host/Seed.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Seed.Host.dll"]