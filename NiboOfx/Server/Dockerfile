#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY NiboOfx/Server/NiboOfx.Server.csproj NiboOfx/Server/
COPY NiboOfx/Client/NiboOfx.Client.csproj NiboOfx/Client/
COPY NiboOfx/Shared/NiboOfx.Shared.csproj NiboOfx/Shared/
RUN dotnet restore "NiboOfx/Server/NiboOfx.Server.csproj"
COPY . .
WORKDIR "/src/NiboOfx/Server"
RUN dotnet build "NiboOfx.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NiboOfx.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NiboOfx.Server.dll"]
