#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/AreaCirculo/AreaCirculo.csproj", "src/AreaCirculo/"]
RUN dotnet restore "src/AreaCirculo/AreaCirculo.csproj"
COPY . .
WORKDIR "/src/src/AreaCirculo"
RUN dotnet build "AreaCirculo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AreaCirculo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AreaCirculo.dll"]