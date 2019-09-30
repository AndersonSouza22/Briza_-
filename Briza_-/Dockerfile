FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Briza_-/Briza_-.csproj", "Briza_-/"]
COPY ["BrizaInfra/BrizaInfra.csproj", "BrizaInfra/"]
COPY ["DomainBriza/DomainBriza.csproj", "DomainBriza/"]
RUN dotnet restore "Briza_-/Briza_-.csproj"
COPY . .
WORKDIR "/src/Briza_-"
RUN dotnet build "Briza_-.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Briza_-.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Briza_-.dll"]
