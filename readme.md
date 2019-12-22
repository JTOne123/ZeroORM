![ZeroORM logo](https://raw.githubusercontent.com/bessgeor/ZeroORM/master/icon.png)

# ZeroORM
[![Build status](https://ci.appveyor.com/api/projects/status/5tjepv5kun3ouuap/branch/master?svg=true)](https://ci.appveyor.com/project/bessgeor/zeroorm/branch/master)
[![ZeroORM nuget package version](https://buildstats.info/nuget/ZeroORM?includePreReleases=true)](https://www.nuget.org/packages/ZeroORM)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

ZeroORM is a lightweight RDBMS iteraction helper.
It is not really an ORM as for now because it does no mapping. 

The main aim of the library is to aid developers in writing SQL in a refactor-safe way.

# Usage

Currently, the only APIs of the library are to access table/column names via POCOs.

Example (using [ZeroORM.EFCore](https://www.nuget.org/packages/ZeroORM.EFCore/))
```csharp
using System;
using Microsoft.EntityFrameworkCore;
using ZeroORM;

namespace ZeroORMExample
{
	class ExmpleClass
	{
		string GetLastCreatedItemIdSql(DbContext context)
			=> context
			.ZeroORM()
			.UseTable<ExampleEntityType>(out var exampleEntities)
			.Script()
			.RawSql(@$"
SELECT ""{exampleEntities.GetColumnName(e => e.Id)}""
FROM ""{exampleEntities.TableName}""
ORDER BY ""{exampleEntities.GetColumnName(e => e.CreatedAt)}"" DESC
LIMIT 1
"); // PostgreSQL SQL flavour
	}
}
```

# Architecture

The core of the project is [ZeroORM.Extensibility package](https://www.nuget.org/packages/ZeroORM.Extensibility/).

It defines all of the metadata related interfaces to be used internally alongside with common ZeroORM exceptions.

The interfaces are
- `ITableMetadata` which represents relational metadata for some POCO
- `IMetadataProvider` which is used to access `ITableMetadata`

Those interfaces are to be implemented by ORM adapter packages.

ORM adapters:
- to EFCore [![ZeroORM.EFCore nuget package version](https://buildstats.info/nuget/ZeroORM.EFCore?includePreReleases=true)](https://www.nuget.org/packages/ZeroORM.EFCore)

The other extensibility point is the `ISqlBuilder` interface defined in this package.
It is returned from `.Script()` extension method and is planned to be used to create more complicated sql building experience.
The class implementing `ISqlBuilder` should always implement `IMetadataProviderContainer`. Those two are splitted to hide raw metadata access from public APIs for better Intellisense experience.

There are plans to implement complex SQL builder without both string typing and LINQ (as I see it as misused abstraction for SQL) as extension to ISQLBuilder.
