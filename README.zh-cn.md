# Mem0.Net

[English](README.md) | [中文](README.zh-cn.md)

这是基于 .NET 封装的 Mem0Client SDK，方便在 .NET 项目中集成和调用 [Mem0](https://mem0.ai) 智能记忆服务的 API。

## 特性

- 支持 .NET 6.0、7.0、8.0、9.0
- 封装 Mem0 API 的常用接口（增、查、删、改等）
- 支持异步调用
- 简单易用，便于集成

## 安装

通过 NuGet 安装（发布后）：

```shell
dotnet add package Mem0.Net
```

## 快速开始

### 1. 依赖注入注册

在 `Program.cs` 中注册 Mem0Client 服务：

```csharp
using Mem0.Net;

var builder = WebApplication.CreateBuilder(args);

// 注册 Mem0Client 服务
builder.Services.AddMem0Client();

var app = builder.Build();
// ... 其他配置
```

### 2. 配置文件设置

在 `appsettings.json` 中添加 Mem0 配置：

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

### 3. 使用示例

```csharp
using Mem0.Net;
using Mem0.Net.Models;

// 通过依赖注入获取客户端
public class MyService
{
    private readonly IMem0Client _mem0Client;

    public MyService(IMem0Client mem0Client)
    {
        _mem0Client = mem0Client;
    }

    public async Task UseMem0Client()
    {
        // 添加记忆
        var addRequest = new AddMemoriesRequest
        {
            // 填写请求参数
        };
        var addResponse = await _mem0Client.AddMemoriesAsync(addRequest);

        // 搜索记忆
        var searchResults = await _mem0Client.SearchAsync("example", limit: 10);

        // 获取记忆详情
        var memory = await _mem0Client.GetMemoryAsync("memoryId");

        // 删除记忆
        var success = await _mem0Client.DeleteMemoryAsync("memoryId");
    }
}
```

### 4. 直接使用（不推荐）

如果不想使用依赖注入，也可以直接实例化：

```csharp
using Mem0.Net;
using Mem0.Net.Models;

// 初始化客户端
var client = new Mem0Client("your-mem0-api-key");

// 添加记忆
var addRequest = new AddMemoriesRequest
{
    // 填写请求参数
};
var addResponse = await client.AddMemoriesAsync(addRequest);

// 搜索记忆
var searchRequest = new SearchRequest
{
    Query = "example",
    Limit = 10
};
var searchResults = await client.SearchAsync(searchRequest);

// 获取记忆详情
var memory = await client.GetMemoryAsync("memoryId");

// 删除记忆
var success = await client.DeleteMemoryAsync("memoryId");
```

## 接口说明

- `AddMemoriesAsync(AddMemoriesRequest request)`：添加记忆
- `SearchAsync(SearchRequest request)`：搜索记忆
- `GetMemoryAsync(string memoryId)`：获取记忆详情
- `DeleteMemoryAsync(string memoryId)`：删除记忆
- ...（更多接口请参考源码和注释）

## 配置

- **API Key**：请在 [Mem0 官网](https://mem0.ai) 获取你的 API Key。
- **BaseUrl**：如需自定义服务地址，可在初始化时传入。

## 贡献

欢迎提交 Issue 或 Pull Request 参与贡献！

## License

[MIT](LICENSE)
