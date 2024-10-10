
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY ./bin/Release/net8.0 /App/
COPY ./wwwroot /App/wwwroot
#EXPOSE 8080
ENTRYPOINT ["dotnet", "WuWarDotNet.dll"]