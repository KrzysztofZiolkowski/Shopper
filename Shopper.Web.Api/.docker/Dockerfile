FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /App
COPY . ./
RUN dotnet restore "./Shopper.Web.Api/Shopper.Web.Api.csproj"

FROM build AS publish
COPY ./Shopper.Web.Api/ ./Shopper.Web.Api/
RUN dotnet publish "./Shopper.Web.Api/Shopper.Web.Api.csproj" -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=publish /App/out .
ENTRYPOINT ["dotnet", "Shopper.Web.Api.dll"]