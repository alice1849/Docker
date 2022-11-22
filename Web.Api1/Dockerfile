FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY Web.Api1.sln ./
COPY Web.Api1/*.csproj ./Web.Api1/
COPY Web.Api.Core/*.csproj ./Web.Api.Core/
COPY Web.Api1.Infrastructure/*.csproj ./Web.Api1.Infrastructure/

RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish Web.Api1.sln -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Development

USER 1000

WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 8080
ENTRYPOINT ["dotnet", "Web.Api1.dll"]