FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["StarFitApi.csproj", "./"]
RUN dotnet restore "StarFitApi.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "StarFitApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM mcr.microsoft.com/dotnet/sdk:7.0 as migrations
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/
COPY . .
RUN dotnet tool install --global dotnet-ef --version 7.0.15
ENV PATH="${PATH}:/root/.dotnet/tools"
ENTRYPOINT ["dotnet", "ef", "database", "update"]

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "StarFitApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

COPY Docker/docker-entrypoint.sh /usr/local/bin/docker-entrypoint
RUN chmod +x /usr/local/bin/docker-entrypoint

ENTRYPOINT ["docker-entrypoint"]
CMD ["dotnet", "StarFitApi.dll"]