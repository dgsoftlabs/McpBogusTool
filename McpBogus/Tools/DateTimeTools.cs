using System.ComponentModel;
using Bogus;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random dates and times.
/// </summary>
internal class DateTimeTools
{
    private readonly Faker _faker = new Faker();

    [McpServerTool]
    [Description("Generates a random date.")]
    public DateTime GetRandomDate(
        [Description("Start year")] int startYear = 1990,
        [Description("End year")] int endYear = 2026)
    {
        return _faker.Date.Between(new DateTime(startYear, 1, 1), new DateTime(endYear, 12, 31));
    }
}
