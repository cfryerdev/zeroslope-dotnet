![ZeroSlope](https://bitbucket.org/zeroslope/zeroslope/raw/master/Icon.png)

### What is Zero Slope? ###
ZeroSlope is a .net core micro-service scaffold with adoption and simplicity in mind. This project is meant to provide a simple and lean architecture using common industry technologies and practices. All dependencies are constructed and stored in a IoC container following the Composition Root pattern. API Documentation is auto-generated using a Swagger front-end.

This implementation focuses on a Sql Server back-end using Dapper to persist.

### Third Party Libraries ###
| Libary | Version | Url |
|--|--|--|
| ZeroSlope.Infrastructure | 1.0.3 | [VIEW](https://www.nuget.org/packages/ZeroSlope.Infrastructure) |
| Microsoft.AspNetCore.Mvc | 2.0.3 | [VIEW](https://www.microsoft.com/net) |
| AutoFac | 4.6.2 | [VIEW](https://github.com/autofac/Autofac) |
| Dapper | 1.50.4 | [VIEW](https://www.nuget.org/packages/Dapper) |
| Dapper.Contrib | 1.50.4 | [VIEW](https://www.nuget.org/packages/Dapper.Contrib) |
| AutoMapper | 6.2.2 | [VIEW](https://github.com/AutoMapper/AutoMapper) |
| Serilog.AspNetCore | 2.6.0 | [VIEW](https://github.com/serilog/serilog-aspnetcore) |
| Swashbuckle.AspNetCore | 2.3.0 | [VIEW](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) |
| Microsoft.Extensions.Caching.Redis | 2.0.1 | [VIEW](https://www.nuget.org/packages/Microsoft.Extensions.Caching.Redis) |
| RabbitMQ.Client | 5.0.1 | [VIEW](https://www.nuget.org/packages/RabbitMQ.Client) |

### Dependencies ###
* Sql Server 2012-2017, Azure Sql PaaS, PostgresSQL
* .Net Core 2.0 or higher
* Docker *(Optional)*
* Redis Cache *(Optional)*
* RabbitMq *(Optional)*

### How do I get set up? ###
* Windows
	* Open Visual studio, and click the `Play` button.
* Unix / MacOSX
	* Open bash in the root of the solution, and use the command `dotnet restore` and then `dotnet start`

### Sql Server in Docker?
Simply run the following
```
docker run -d --name sqldevdb --env "ACCEPT_EULA=Y" --env "MSSQL_SA_PASSWORD=P4ssw0rd!" --env "SA_PASSWORD=P4ssw0rd!" --env "MSSQL_PID=Developer" -p 1401:1433 -d microsoft/mssql-server-linux:2017-latest
```

### Postgres in Docker
Simply run the following
```
docker run --name pgdb -e POSTGRES_PASSWORD=P4ssw0rd! -e POSTGRES_DB=zeroslope -p 5432:5432 -d postgres
```

### How do I deploy? ###
Coming soon.

### Configuration ###
Coming soon.

### Getting Started ###
Coming soon.

### Examples ###
Coming soon.

### Architecture Diagram ###
![ZeroSlope Architecture](https://bitbucket.org/zeroslope/zeroslope/raw/master/Documentation/Architecture.png)