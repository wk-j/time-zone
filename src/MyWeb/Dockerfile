FROM mcr.microsoft.com/dotnet/core/sdk:5.0-alpine as build
WORKDIR /app

COPY src/MyWeb/*.csproj src/MyWeb/MyWeb.csproj
RUN  dotnet restore src/MyWeb

COPY src/MyWeb src/MyWeb
RUN dotnet publish src/MyWeb -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV TZ='Asia/Bangkok'
RUN apk add --no-cache tzdata

ENTRYPOINT [ "dotnet", "MyWeb.dll" ]