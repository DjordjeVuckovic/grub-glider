FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/OrderService/GrubGlider.OrderService/GrubGlider.OrderService.csproj", "src/OrderService/GrubGlider.OrderService/"]
RUN dotnet restore "src/OrderService/GrubGlider.OrderService/GrubGlider.OrderService.csproj"
COPY . .
WORKDIR "/src/src/OrderService/GrubGlider.OrderService"
RUN dotnet build "GrubGlider.OrderService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GrubGlider.OrderService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrubGlider.OrderService.dll"]
