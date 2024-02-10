FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Silvestre.App.Web/Silvestre.App.Web.csproj", "Silvestre.App.Web/"]
RUN dotnet restore "Silvestre.App.Web/Silvestre.App.Web.csproj"
COPY src/ .
WORKDIR "/src/Silvestre.App.Web"
RUN dotnet build "Silvestre.App.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG RUNTIME_IDENTIFIER=linux-x64
RUN dotnet publish "Silvestre.App.Web.csproj" -c $BUILD_CONFIGURATION -r $RUNTIME_IDENTIFIER --self-contained -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Silvestre.App.Web.dll"]
