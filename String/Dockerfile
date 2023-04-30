FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["String/String.csproj", "String/"]
RUN dotnet restore "String/String.csproj"
COPY . .
WORKDIR "/src/String"
RUN dotnet build "String.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "String.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "String.dll"]
