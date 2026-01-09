# McpBogus 🎲

**McpBogus** is a Model Context Protocol (MCP) server that leverages the popular [Bogus](https://github.com/bchavez/Bogus) library to generate realistic fake data for your AI agents and MCP clients.

Whether you need test data for development, simple placeholders, or complex datasets, McpBogus provides a suite of tools to generate names, addresses, companies, text, and dates on the fly.

## ✨ Features

- **Person Data**: Generate full names, first names, last names, emails, and phone numbers.
- **Location Data**: Create realistic addresses including street, city, state, and zip codes.
- **Company Info**: Generate random company names.
- **Text & Content**: Generate "Lorem Ipsum" text for placeholders.
- **Dates**: Get random dates within a specific range.
- **Utility**: Random booleans, numbers, and GUIDs.

## 🚀 Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Installation

Clone the repository and build the project:

```bash
git clone https://github.com/your-username/McpBogus.git
cd McpBogus/McpBogus
dotnet build
```

### Configuration

Add the server to your MCP client configuration (e.g., VS Code or Claude Desktop).

**VS Code (`.vscode/mcp.json`):**

```json
{
  "mcpServers": {
    "McpBogus": {
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "${workspaceFolder}/McpBogus/McpBogus.csproj"
      ]
    }
  }
}
```

**Claude Desktop (`claude_desktop_config.json`):**

```json
{
  "mcpServers": {
    "bogus": {
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "C:/Absolute/Path/To/McpBogus/McpBogus.csproj"
      ]
    }
  }
}
```

## 🛠️ Available Tools

Once connected, the following tools are available to your AI assistant:

### Person Tools
- **GetRandomName**: Generates a random name.
  - Arguments: `type` ("full", "first", "last") - defaults to "full".
- **GetRandomEmail**: Generates a random email address.
- **GetRandomPhone**: Generates a random phone number.

### Address Tools
- **GetRandomAddress**: Generates a random address.
  - Arguments: `type` ("full", "street", "city", "state", "zipcode") - defaults to "full".

### Company Tools
- **GetRandomCompany**: Generates a random company name.

### Text Tools
- **GetRandomText**: Generates Lorem Ipsum text.
  - Arguments: `sentences` (int) - Number of sentences to generate (default: 3).

### Date & Time Tools
- **GetRandomDate**: Generates a random date between two years.
  - Arguments: `startYear` (int), `endYear` (int).

### Number & Utility Tools
- **GetRandomNumber**: Generates a random integer between min and max.
- **GetRandomBoolean**: Generates a random true/false value.
- **GetRandomGuid**: Generates a random UUID/GUID.

## 🤝 Contributing

Contributions are welcome! This is a public project intended to showcase how to build useful MCP servers with .NET.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

---
*Built with [ModelContextProtocol .NET SDK](https://github.com/modelcontextprotocol/dotnet-sdk)*
