# Quotes Application

[![Build Status](https://travis-ci.com/abarrak/Quotes-Application.svg?token=6srXbW1inBqbcVxZhTbQ&branch=master)](https://travis-ci.com/abarrak/Quotes-Application) [![codecov](https://codecov.io/gh/abarrak/Quotes-Application/branch/master/graph/badge.svg?token=NQoRbhJ1Ys)](https://codecov.io/gh/abarrak/Quotes-Application)

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

## Lisence

MIT.

