FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime  
WORKDIR /app
COPY ./adminApp/in .
ENTRYPOINT ["dotnet", "adminApp.dll"]
# https://localhost:44304/