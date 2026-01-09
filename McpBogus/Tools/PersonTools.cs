using System.ComponentModel;
using Bogus;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random personal information (names, emails, phone numbers).
/// </summary>
internal class PersonTools
{
    private readonly Faker _faker = new Faker();

    [McpServerTool]
    [Description("Generates a random person's name.")]
    public string GetRandomName([Description("Name type: full, first, or last")] string type = "full")
    {
        return type.ToLower() switch
        {
            "first" => _faker.Name.FirstName(),
            "last" => _faker.Name.LastName(),
            _ => _faker.Name.FullName()
        };
    }

    [McpServerTool]
    [Description("Generates a random email address.")]
    public string GetRandomEmail()
    {
        return _faker.Internet.Email();
    }

    [McpServerTool]
    [Description("Generates a random phone number.")]
    public string GetRandomPhone()
    {
        return _faker.Phone.PhoneNumber();
    }
}
