using System.ComponentModel;
using Bogus;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random company-related data.
/// </summary>
internal class CompanyTools
{
    private readonly Faker _faker = new Faker();

    [McpServerTool]
    [Description("Generates a random company name.")]
    public string GetRandomCompany()
    {
        return _faker.Company.CompanyName();
    }
}
