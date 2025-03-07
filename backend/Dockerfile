# Base image for running the application in production
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

# Build stage: restore and compile the code
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /workspace

# Copy the solution file and restore dependencies
COPY ["./Fidlle.sln", "./"]
COPY ["./Fidlle.Application/Fidlle.Application.csproj", "Fidlle.Application/"]
COPY ["./Fidlle.Domain/Fidlle.Domain.csproj", "Fidlle.Domain/"]
COPY ["./Fidlle.Infrastructure/Fidlle.Infrastructure.csproj", "Fidlle.Infrastructure/"]
COPY ["./Fidlle.Api/Fidlle.Api.csproj", "Fidlle.Api/"]
RUN dotnet restore "./Fidlle.sln"

# Copy the entire project source
COPY ../ .

# Build the application
WORKDIR "/workspace/Fidlle.Api"
RUN dotnet build "./Fidlle.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage: optimize output for deployment
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Fidlle.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage: use a minimal runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet", "Fidlle.Api.dll"]
