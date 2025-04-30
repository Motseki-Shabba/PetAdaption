FROM mcr.microsoft.com/dotnet/sdk:9.0.201 AS build
 
WORKDIR /app
 
COPY aspnet-core/PetAdaption.sln ./
COPY aspnet-core/src/ ./src/
 
RUN dotnet restore ./src/PetAdaption.Web.Host/PetAdaption.Web.Host.csproj
RUN dotnet publish ./src/PetAdaption.Web.Host/PetAdaption.Web.Host.csproj -c Release -o /app/publish
 
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
 
COPY --from=build /app/publish .
 
ENV ASPNETCORE_ENVIRONMENT=Docker
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
 
ENTRYPOINT ["dotnet", "evolve.Web.Host.dll"]
 
 