# Mem0.Net

[English](README.md) | [中文](README.zh-cn.md)

A .NET wrapper SDK for Mem0Client that facilitates integration and API calls to the [Mem0](https://mem0.ai) intelligent memory service in .NET projects.

## Features

- Supports .NET 6.0, 7.0, 8.0, 9.0
- Encapsulates common Mem0 API interfaces (CRUD operations)
- Supports asynchronous calls
- Simple and easy to integrate

## Installation

Install via NuGet (after release):

```shell
dotnet add package Mem0.Net
```

## Quick Start

### 1. Dependency Injection Registration

Register Mem0Client service in `Program.cs`:

```csharp
using Mem0.Net;

var builder = WebApplication.CreateBuilder(args);

// Register Mem0Client service
builder.Services.AddMem0Client();

var app = builder.Build();
// ... other configurations
```

### 2. Configuration File Setup

Add Mem0 configuration in `appsettings.json`:

```json
{
  "Mem0": {
    "ApiKey": "your-mem0-api-key",
    "Endpoint": "https://api.mem0.ai",
    "OrganizationId": "your-org-id",
    "ProjectId": "your-project-id"
  }
}
```

### 3. Usage Example

```csharp
using Mem0.Net;
using Mem0.Net.Models;

// Get client through dependency injection
public class MyService
{
    private readonly IMem0Client _mem0Client;

    public MyService(IMem0Client mem0Client)
    {
        _mem0Client = mem0Client;
    }

    public async Task UseMem0Client()
    {
        // Add memories
        var addRequest = new AddMemoriesRequest
        {
            // Fill in request parameters
        };
        var addResponse = await _mem0Client.AddMemoriesAsync(addRequest);

        // Search memories
        var searchResults = await _mem0Client.SearchAsync("example", limit: 10);

        // Get memory details
        var memory = await _mem0Client.GetMemoryAsync("memoryId");

        // Delete memory
        var success = await _mem0Client.DeleteMemoryAsync("memoryId");
    }
}
```

### 4. Direct Usage (Not Recommended)

If you don't want to use dependency injection, you can also instantiate directly:

```csharp
using Mem0.Net;
using Mem0.Net.Models;

// Initialize client
var client = new Mem0Client("your-mem0-api-key");

// Add memories
var addRequest = new AddMemoriesRequest
{
    // Fill in request parameters
};
var addResponse = await client.AddMemoriesAsync(addRequest);

// Search memories
var searchRequest = new SearchRequest
{
    Query = "example",
    Limit = 10
};
var searchResults = await client.SearchAsync(searchRequest);

// Get memory details
var memory = await client.GetMemoryAsync("memoryId");

// Delete memory
var success = await client.DeleteMemoryAsync("memoryId");
```

## API Reference

- `AddMemoriesAsync(AddMemoriesRequest request)`: Add memories
- `SearchAsync(SearchRequest request)`: Search memories
- `GetMemoryAsync(string memoryId)`: Get memory details
- `DeleteMemoryAsync(string memoryId)`: Delete memory
- ... (For more APIs, please refer to source code and comments)

## Configuration

- **API Key**: Please obtain your API Key from the [Mem0 official website](https://mem0.ai).
- **BaseUrl**: If you need to customize the service address, you can pass it during initialization.

## Contributing

Welcome to submit Issues or Pull Requests to contribute!

## License

[MIT](LICENSE)
