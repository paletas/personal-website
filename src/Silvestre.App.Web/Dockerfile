FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Tailwind CSS 4 build (scans Pages/**/*.cshtml) and vendored charts.css; site.css is generated, not committed.
FROM node:26-slim AS css
WORKDIR /src/src/Silvestre.App.Web
COPY src/Silvestre.App.Web/package*.json ./
RUN npm ci
COPY src/Silvestre.App.Web/ ./
RUN npm run build:css

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Silvestre.App.Web/Silvestre.App.Web.csproj", "Silvestre.App.Web/"]
RUN dotnet restore "Silvestre.App.Web/Silvestre.App.Web.csproj"
COPY src/ .
COPY --from=css /src/src/Silvestre.App.Web/wwwroot/css/site.css Silvestre.App.Web/wwwroot/css/site.css
COPY --from=css /src/src/Silvestre.App.Web/wwwroot/vendor/charts.min.css Silvestre.App.Web/wwwroot/vendor/charts.min.css
WORKDIR "/src/Silvestre.App.Web"
RUN dotnet build "Silvestre.App.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "Silvestre.App.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Silvestre.App.Web.dll"]
