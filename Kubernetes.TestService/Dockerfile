FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Kubernetes.TestService/Kubernetes.TestService.csproj", "Kubernetes.TestService/"]
RUN dotnet restore "Kubernetes.TestService/Kubernetes.TestService.csproj"
COPY . .
WORKDIR "/src/Kubernetes.TestService"
RUN dotnet build "Kubernetes.TestService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Kubernetes.TestService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Kubernetes.TestService.dll"]