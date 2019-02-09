FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src

COPY ["DevOpsLyntale/DevOpsLyntale.csproj", "DevOpsLyntale/"]
RUN dotnet restore "DevOpsLyntale/DevOpsLyntale.csproj"
COPY . .
WORKDIR "/src/DevOpsLyntale"
RUN dotnet build "DevOpsLyntale.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DevOpsLyntale.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DevOpsLyntale.dll"]