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
