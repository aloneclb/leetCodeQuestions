FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Question13_Roman_To_Integer/Question13_Roman_To_Integer.csproj", "Question13_Roman_To_Integer/"]
RUN dotnet restore "Question13_Roman_To_Integer/Question13_Roman_To_Integer.csproj"
COPY . .
WORKDIR "/src/Question13_Roman_To_Integer"
RUN dotnet build "Question13_Roman_To_Integer.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Question13_Roman_To_Integer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question13_Roman_To_Integer.dll"]
