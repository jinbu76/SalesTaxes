FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SalesTaxes.API/SalesTaxes.API.csproj", "SalesTaxes.API/"]
COPY ["SalesTaxes.Domains.Product.Infrastructure/SalesTaxes.Domains.Product.Infrastructure.csproj", "SalesTaxes.Domains.Product.Infrastructure/"]
COPY ["SalesTaxes.Domains.Product.Domain/SalesTaxes.Domains.Product.Domain.csproj", "SalesTaxes.Domains.Product.Domain/"]
COPY ["SalesTaxes.Domains.Product.ServiceDefinition/SalesTaxes.Domains.Product.ServiceDefinition.csproj", "SalesTaxes.Domains.Product.ServiceDefinition/"]


RUN dotnet restore "SalesTaxes.API/SalesTaxes.API.csproj"
COPY . .
WORKDIR "/src/SalesTaxes.API"
RUN dotnet build "SalesTaxes.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalesTaxes.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalesTaxes.API.dll"]
