FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ClinicManagement.API/ClinicManagement.API.csproj", "ClinicManagement.API/"]
RUN dotnet restore "ClinicManagement.API/ClinicManagement.API.csproj"
COPY . .
WORKDIR "/src/ClinicManagement.API"
RUN dotnet build "ClinicManagement.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClinicManagement.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicManagement.API.dll"]
