#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Silvestre.Blog.WebApp/Silvestre.Blog.WebApp.csproj", "Silvestre.Blog.WebApp/"]
RUN dotnet restore "Silvestre.Blog.WebApp/Silvestre.Blog.WebApp.csproj"
COPY . .
WORKDIR "/src/Silvestre.Blog.WebApp"
RUN dotnet build "Silvestre.Blog.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Silvestre.Blog.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Silvestre.Blog.WebApp.dll"]