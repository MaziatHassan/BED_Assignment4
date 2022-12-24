FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BED_Assignment_4_grp4/BED_Assignment_4_grp4.csproj", "BED_4/"]
RUN dotnet restore "BED_Assignment_4_grp4/BED_Assignemnt_4_grp4.csproj"
COPY . .
WORKDIR "/src/BED_Assignement_4_grp4"
RUN dotnet build "BED_Assignment_4_grp4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BED_Assignment_4_grp4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BED_Assignment_4_grp4.dll"]