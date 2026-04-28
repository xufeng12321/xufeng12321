# .NET 8.0 新特性示例项目

这是一个最小可运行的 `.NET 8.0` 控制台项目，演示了几个常见的新能力。

## 本示例包含的特性

- **TimeProvider**：使用 `TimeProvider.System` 获取当前时间，方便后续在测试中替换时间源。
- **FrozenDictionary**：通过 `ToFrozenDictionary` 创建高性能只读字典，适合热路径查找。
- **Collection Expressions（C# 12）**：使用 `[]` 快速构建集合。

## 项目结构

- `XufengApp.csproj`: 目标框架 `net8.0`，启用 `Nullable` / `ImplicitUsings`，语言版本 `12.0`。
- `Program.cs`: .NET 8 特性演示入口。

## 运行方式

```bash
dotnet run
```

## 说明

如果你需要，我可以继续把这个项目扩展成：

- Web API（Minimal API）
- Worker Service（后台任务）
- 分层结构（Domain/Application/Infrastructure）
