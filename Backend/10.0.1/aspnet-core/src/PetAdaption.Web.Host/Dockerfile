FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/PetAdaption.Web.Host/PetAdaption.Web.Host.csproj", "src/PetAdaption.Web.Host/"]
COPY ["src/PetAdaption.Web.Core/PetAdaption.Web.Core.csproj", "src/PetAdaption.Web.Core/"]
COPY ["src/PetAdaption.Application/PetAdaption.Application.csproj", "src/PetAdaption.Application/"]
COPY ["src/PetAdaption.Core/PetAdaption.Core.csproj", "src/PetAdaption.Core/"]
COPY ["src/PetAdaption.EntityFrameworkCore/PetAdaption.EntityFrameworkCore.csproj", "src/PetAdaption.EntityFrameworkCore/"]
WORKDIR "/src/src/PetAdaption.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PetAdaption.Web.Host", "src/PetAdaption.Web.Host"]
COPY ["src/PetAdaption.Web.Core", "src/PetAdaption.Web.Core"]
COPY ["src/PetAdaption.Application", "src/PetAdaption.Application"]
COPY ["src/PetAdaption.Core", "src/PetAdaption.Core"]
COPY ["src/PetAdaption.EntityFrameworkCore", "src/PetAdaption.EntityFrameworkCore"]
WORKDIR "/src/src/PetAdaption.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PetAdaption.Web.Host.dll"]
