FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/KitchenService/GrubGlider.KitchenService/GrubGlider.KitchenService.csproj", "src/KitchenService/GrubGlider.KitchenService/"]
RUN dotnet restore "src/KitchenService/GrubGlider.KitchenService/GrubGlider.KitchenService.csproj"
COPY . .
WORKDIR "/src/src/KitchenService/GrubGlider.KitchenService"
RUN dotnet build "GrubGlider.KitchenService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GrubGlider.KitchenService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrubGlider.KitchenService.dll"]
