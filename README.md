# Quotes Application

[![Build Status](https://travis-ci.com/abarrak/Quotes-Application.svg?token=6srXbW1inBqbcVxZhTbQ&branch=master)](https://travis-ci.com/abarrak/Quotes-Application) [![codecov](https://codecov.io/gh/abarrak/Quotes-Application/branch/master/graph/badge.svg?token=NQoRbhJ1Ys)](https://codecov.io/gh/abarrak/Quotes-Application) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

<img src="https://raw.githubusercontent.com/abarrak/Quotes-Application/master/QuotesApp.Application/ClientApp/src/assets/images/quotes-app-social.png?token=AE6SOXWPGTPX5VPMCKN2EFS5POEDC" alt="logo" width="700" height="350">

A sample .NET core API and Angular Application to demonstrate DDD patterns and techniques.


## Usage

Restore the packages, then run the application project as follows:

```csharp
dotnet restore
dotnet build
dotnet run --project QuotesApp.Application
```

## APIs

A RESTful quotes API is exposed to perform all CRUD operations on `Quotes` resource.

## Data

The data access layer is implemented by EF Core, with SQLite provider.

Add New migration:

```shell
dotnet ef migrations add AddXXX --project QuotesApp.Infrastructure --startup-project QuotesApp.Application
```

Reflect on the database:

```shell
dotnet ef database update --project QuotesApp.Infrastructure --startup-project QuotesApp.Application
```

To drop the database, use:

```shell
dotnet ef database drop  --project QuotesApp.Infrastructure --startup-project QuotesApp.Application
```

Remove migrations by:

```shell
dotnet ef migrations remove --project QuotesApp.Infrastructure --startup-project QuotesApp.Application
```

## Tests

Unit and integration tests suite is provided in  `QuotesApp.Tests` project.

```bash
dotnet test
```

Run the tests with the coverage report as follows:

```bash
dotnet test /p:CollectCoverage=true
```

## Docker Version

A containerized verison of the application is availabile in [docker hub](https://hub.docker.com/r/abarrak/quotes-app).

Pull the image:
```shell
docker pull abarrak/quotes-app
```

Run within a container:
```shell
docker container run --publish 8080:80 --name quotes-app abarrak/quotes-app
```


## Lisence

MIT.
