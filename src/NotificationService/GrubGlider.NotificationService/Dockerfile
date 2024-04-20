FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/NotificationService/GrubGlider.NotificationService/GrubGlider.NotificationService.csproj", "src/NotificationService/GrubGlider.NotificationService/"]
RUN dotnet restore "src/NotificationService/GrubGlider.NotificationService/GrubGlider.NotificationService.csproj"
COPY . .
WORKDIR "/src/src/NotificationService/GrubGlider.NotificationService"
RUN dotnet build "GrubGlider.NotificationService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GrubGlider.NotificationService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrubGlider.NotificationService.dll"]
