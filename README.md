
# .NET 8 分层架构示例（Web API + Worker）

这个仓库已扩展为一个 .NET 8 的分层示例，包含：

- **Web API（Minimal API）**：对外提供 HTTP 接口。
- **Worker Service（后台任务）**：周期性执行后台逻辑。
- **分层结构（Domain/Application/Infrastructure）**：便于业务演进与测试。

## 目录结构

```text
src/
  Domain/          # 领域实体与核心模型
  Application/     # 用例服务与仓储抽象
  Infrastructure/  # 仓储实现与依赖注入
  WebApi/          # Minimal API 启动项目
  Worker/          # 后台任务启动项目
```

## 关键说明

- `Domain`：定义 `TodoItem` 等领域对象。
- `Application`：定义 `ITodoRepository` 与 `TodoService`。
- `Infrastructure`：提供内存仓储 `InMemoryTodoRepository`。
- `WebApi`：暴露 `/health`、`/todos`（GET/POST）接口。
- `Worker`：通过 `BackgroundService` 周期输出心跳与待办数量。

## 本地运行

> 需要 .NET 8 SDK

### 启动 Web API

```bash
dotnet run --project src/WebApi/WebApi.csproj
```

### 启动 Worker

```bash
dotnet run --project src/Worker/Worker.csproj
```

## 后续建议

可以继续加入：

- 持久化数据库（EF Core + PostgreSQL/MySQL）
- 消息队列（Kafka/RabbitMQ）
- 单元测试与集成测试项目
=======
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
