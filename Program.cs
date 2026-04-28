using System.Collections.Frozen;

var clock = TimeProvider.System;
var now = clock.GetLocalNow();

var featureMap = new Dictionary<string, string>
{
    ["TimeProvider"] = "统一时间抽象，便于测试与时间注入",
    ["FrozenDictionary"] = "高性能只读查找集合，适合启动后不再修改的数据",
    ["CollectionExpression"] = "C# 12 集合表达式，写法更简洁"
}.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);

string[] requested = ["TimeProvider", "FrozenDictionary", "CollectionExpression"];

Console.WriteLine($".NET 8 Feature Demo @ {now:yyyy-MM-dd HH:mm:ss zzz}");
foreach (var key in requested)
{
    if (featureMap.TryGetValue(key, out var desc))
    {
        Console.WriteLine($"- {key}: {desc}");
    }
}
