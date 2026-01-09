using System.ComponentModel;
using Bogus;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random addresses and locations.
/// </summary>
internal class AddressTools
{
    private readonly Faker _faker = new Faker();

    [McpServerTool]
    [Description("Generates a random address.")]
    public string GetRandomAddress([Description("Address type: full, street, city, state, or zipcode")] string type = "full")
    {
        return type.ToLower() switch
        {
            "street" => _faker.Address.StreetAddress(),
            "city" => _faker.Address.City(),
            "state" => _faker.Address.State(),
            "zipcode" => _faker.Address.ZipCode(),
            _ => _faker.Address.FullAddress()
        };
    }
}
