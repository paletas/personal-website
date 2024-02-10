FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Silvestre.App.Blog.Web/Silvestre.App.Blog.Web.csproj", "src/Silvestre.App.Blog.Web/"]
RUN dotnet restore "src/Silvestre.App.Blog.Web/Silvestre.App.Blog.Web.csproj"
COPY . .
WORKDIR "/src/src/Silvestre.App.Blog.Web"
RUN dotnet build "Silvestre.App.Blog.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG RUNTIME_IDENTIFIER=linux-x64
RUN dotnet publish "Silvestre.App.Blog.Web.csproj" -c $BUILD_CONFIGURATION -r $RUNTIME_IDENTIFIER --self-contained -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=publish /src/src/Silvestre.App.Blog.Web/Blog/Content Blog/Content
ENTRYPOINT ["dotnet", "Silvestre.App.Blog.Web.dll"]