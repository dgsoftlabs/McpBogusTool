using System.ComponentModel;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random numbers and boolean values.
/// </summary>
internal class NumberTools
{
    [McpServerTool]
    [Description("Generates a random number between the specified minimum and maximum values.")]
    public int GetRandomNumber(
        [Description("Minimum value (inclusive)")] int min = 0,
        [Description("Maximum value (exclusive)")] int max = 100)
    {
        return Random.Shared.Next(min, max);
    }

    [McpServerTool]
    [Description("Generates a random boolean value.")]
    public bool GetRandomBoolean()
    {
        return Random.Shared.Next(2) == 1;
    }

    [McpServerTool]
    [Description("Generates a random UUID/GUID.")]
    public string GetRandomGuid()
    {
        return Guid.NewGuid().ToString();
    }

    [McpServerTool]
    [Description("Generates a random decimal number between 0.0 and 100.0.")]
    public double GetRandomDecimal(
        [Description("Minimum value")] double min = 0.0,
        [Description("Maximum value")] double max = 100.0)
    {
        return Random.Shared.NextDouble() * (max - min) + min;
    }
}
