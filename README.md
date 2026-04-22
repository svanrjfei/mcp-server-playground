# MCP Server Playground

`mcp-server-playground` is a small .NET MCP server used for local experimentation, packaging, and publishing practice.

It currently exposes two sample tools:

- `get_random_number`: returns a random integer in a given range
- `get_city_weather`: returns a sample weather description for a city

## Repository

- GitHub: [svanrjfei/mcp-server-playground](https://github.com/svanrjfei/mcp-server-playground)
- NuGet package id: `Svanrj.McpServer.Playground`

## Run Locally

You can run the MCP server directly from source with `dotnet run`.

Example Codex MCP configuration:

```toml
[mcp_servers.mymcpserver]
enabled = true
cwd = "/Users/svanrj/project/CS/MyMcpServer"
command = "dotnet"
args = ["run", "--project", "."]
env = { WEATHER_CHOICES = "sunny,cloudy,rainy,stormy" }
```

## Build And Pack

Build the project:

```bash
dotnet build
```

Create a NuGet package:

```bash
dotnet pack -c Release
```

The package will be generated under `bin/Release`.

## Publish To NuGet

After creating a NuGet API key, publish with:

```bash
dotnet nuget push bin/Release/*.nupkg --api-key <your-api-key> --source https://api.nuget.org/v3/index.json
```

## Notes

This repository is a playground project. The weather tool is currently a sample tool that returns a randomized description rather than real weather data.
