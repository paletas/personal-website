FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Silvestre.App.Web/Silvestre.App.Web.csproj", "Silvestre.App.Web/"]
RUN dotnet restore "Silvestre.App.Web/Silvestre.App.Web.csproj"
COPY src/ .
WORKDIR "/src/Silvestre.App.Web"
RUN dotnet build "Silvestre.App.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Silvestre.App.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Silvestre.App.Web.dll"]
