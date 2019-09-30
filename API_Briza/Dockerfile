FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["API_Briza/API_Briza.csproj", "API_Briza/"]
COPY ["BrizaInfra/BrizaInfra.csproj", "BrizaInfra/"]
COPY ["DomainBriza/DomainBriza.csproj", "DomainBriza/"]
RUN dotnet restore "API_Briza/API_Briza.csproj"
COPY . .
WORKDIR "/src/API_Briza"
RUN dotnet build "API_Briza.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "API_Briza.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "API_Briza.dll"]
