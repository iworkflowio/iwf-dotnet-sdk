# IWF .NET SDK

A .NET SDK for the Indeed Workflow Framework (IWF).

## Installation

The package is available on NuGet:

```bash
dotnet add package IwfDotnetSdk
```

## Usage

```csharp
using IwfDotnetSdk;

var helloWorld = new HelloWorld();
string message = helloWorld.Hello();
Console.WriteLine(message); // Outputs: Hello, World!
```

## Development

### Prerequisites

- .NET 8.0 SDK or higher

### Build

```bash
dotnet build
```

### Test

```bash
dotnet test
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.