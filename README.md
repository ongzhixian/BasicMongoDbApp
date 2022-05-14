# BasicMongoDbApp

A basic .NET Core console application use for simple deployments in Kubernetes with MongoDb functionality.

(Because sometimes I just need a simple console application to test out some MongoDb code/concepts).

## dotnet CLI

dotnet CLI used to create this project:

```ps1: In C:\src\github.com\ongzhixian\BasicMongoDbApp
dotnet new sln -n BasicMongoDbApp
dotnet new console -n BasicMongoDbApp.ConsoleApp
dotnet sln .\BasicMongoDbApp.sln add .\BasicMongoDbApp.ConsoleApp\

dotnet add .\BasicMongoDbApp.ConsoleApp\ package Microsoft.Extensions.Configuration
dotnet add .\BasicMongoDbApp.ConsoleApp\ package Microsoft.Extensions.Configuration.UserSecrets
dotnet add .\BasicMongoDbApp.ConsoleApp\ package MongoDB.Driver
dotnet add .\BasicMongoDbApp.ConsoleApp\ package MongoDB.Analyzer

dotnet user-secrets --project .\BasicMongoDbApp.ConsoleApp\ init
dotnet user-secrets --project .\BasicMongoDbApp.ConsoleApp\ set "mongodb:ConnectionString" "mongodb+srv://<userid>:<password>@<mongodb-server>/<database>?retryWrites=true&w=majority"

```

Other ways to extend configuration

```
Microsoft.Extensions.Configuration.Json
Microsoft.Extensions.Configuration.CommandLine 
Microsoft.Extensions.Configuration.Binder 
Microsoft.Extensions.Configuration.EnvironmentVariables
```