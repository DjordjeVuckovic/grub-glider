FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/OfferingService/GrubGlider.OfferingService/GrubGlider.OfferingService.csproj", "src/OfferingService/GrubGlider.OfferingService/"]
RUN dotnet restore "src/OfferingService/GrubGlider.OfferingService/GrubGlider.OfferingService.csproj"
COPY . .
WORKDIR "/src/src/OfferingService/GrubGlider.OfferingService"
RUN dotnet build "GrubGlider.OfferingService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GrubGlider.OfferingService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrubGlider.OfferingService.dll"]
