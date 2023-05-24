# Mixing NET Framework with netstandard2.0

You can mix netstandard2.0 class libraries with net6.0 and Net framework v4.6.1.

# v4.6.1 with shared netstdnard2.0

A .NET Framework ASP.NET MVC/API v4.6.1 project can reference a `netstandard2.0` project.

# net6.0 with shared netstandard2.0

A dotnet core net6.0 Web Api project can reference a `netstandard2.0` project.

Example: 
- Mixed.Core6.API is a standard net6.0 project
- Mixed.NetFramework461.Web is a .NET Framework 4.6.1 asp.net mvc/api project
- Mixed.Models is a netstandard2.0 project

Both Core6 and NetFramework461 are referencing the netstandard2.0 class library.

# Mixed.Model

.NET Standard 2.0 can be used as a target framework by projects that are built on .NET Framework 4.6.1 and later, .NET Core 2.0 and later, and other compatible platforms. IF we are using Net Framework v4.6.1, then any shared class libraries (Models) projects must be built against netstandard2.0

Here is how to adapt. For a Shared Model class library project that is used by both .NET Framework and .NET Core, some things to check:

(For Mixed.Model)


1. Change the TargetFramework:

```xml
    <TargetFramework>netstandard2.0</TargetFramework>
```

2. Change the c# language version to the one recognised by netstandard

```xml
	  <LangVersion>7.3</LangVersion>
```

3. Turn off Nullable, since c# 7.3 doesn't recognise it:

```xml
    <Nullable>disable</Nullable>
```

4. Turn off Implicit Using, so we don't need a global using file

```xml
    <ImplicitUsings>disable</ImplicitUsings>
```


If you are looking to build an example v4.6.1 project, the version of Visual studio that support netstandard and net461 new project templates is Visual Studio 2017 Version 15.9






