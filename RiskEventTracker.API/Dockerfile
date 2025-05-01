# Use the official .NET SDK image to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and projects
COPY ../RiskEventTracker.sln ./
COPY ./ ./

# Restore and build
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Use the ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose the default port
EXPOSE 80

# Run the application
ENTRYPOINT ["dotnet", "RiskEventTracker.API.dll"]