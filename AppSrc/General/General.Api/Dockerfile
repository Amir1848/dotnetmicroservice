#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["General/General.Api/General.Api.csproj", "General/General.Api/"]
COPY ["FUM.BaseApi/FUM.BaseApi.csproj", "FUM.BaseApi/"]
COPY ["FUM.BaseBusiness/FUM.BaseBusiness.csproj", "FUM.BaseBusiness/"]
COPY ["FUM.BaseCommon/FUM.BaseCommon.csproj", "FUM.BaseCommon/"]
COPY ["General/General.Business/General.Business.csproj", "General/General.Business/"]
COPY ["General/General.Common/General.Common.csproj", "General/General.Common/"]
RUN dotnet restore "General/General.Api/General.Api.csproj"
COPY . .
WORKDIR "/src/General/General.Api"
RUN dotnet build "General.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "General.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "General.Api.dll"]