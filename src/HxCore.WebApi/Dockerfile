#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#�������������Լ���asp.net���񣬷��ڰ����Ʋִ���ʹ��΢����Ҳ���ԣ�ֻ����ȡʱ�Ƚ���
FROM registry.cn-hangzhou.aliyuncs.com/songtaojie_centos/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM registry.cn-hangzhou.aliyuncs.com/songtaojie_centos/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/HxCore.Entity/HxCore.Entity.csproj", "/src/HxCore.Entity/"]
COPY ["src/HxCore.Model/HxCore.Model.csproj", "/src/HxCore.Model/"]
COPY ["src/HxCore.IServices/HxCore.IServices.csproj", "/src/HxCore.IServices/"]
COPY ["src/HxCore.Services/HxCore.Services.csproj", "/src/HxCore.Services/"]
COPY ["src/HxCore.Extensions/HxCore.Extensions.csproj", "/src/HxCore.Extensions/"]
COPY ["src/HxCore.WebApi/HxCore.WebApi.csproj", "/src/HxCore.WebApi/"]

RUN dotnet restore "/src/HxCore.WebApi/HxCore.WebApi.csproj"
COPY . .
WORKDIR "/src/src/HxCore.WebApi"
RUN dotnet build "HxCore.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HxCore.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# CMD ["dotnet","HxCore.WebApi.dll","/seed"]
ENTRYPOINT ["dotnet", "HxCore.WebApi.dll"]