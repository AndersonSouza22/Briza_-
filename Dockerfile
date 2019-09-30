#FROM microsoft/dotnet:2.1-sdk AS build
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
##FROM microsoft/dotnet:2.1-sdk AS build
##WORKDIR /app
##VOLUME C:/ProgramData/Docker/tmp/
##COPY ["api_briza/api_briza.csproj", "api_briza/"]
#COPY . ./
##RUN dotnet restore
##RUN dotnet restore
##COPY . ./
##WORKDIR "/src/api_briza"
##RUN dotnet build  -c Release -o /app
#
##FROM build AS publish
#RUN dotnet publish API_Briza.csproj  -c Release -o /app
#
#FROM microsoft/dotnet:2.1-aspnetcore-runtime
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "API_Briza.dll"]

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build-env
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY . ./
RUN dotnet publish Briza_-  -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
WORKDIR /app
COPY --from=build-env /app/Briza_-/out .

ENTRYPOINT ["dotnet", "Briza_-.dll"]