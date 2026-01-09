using System.ComponentModel;
using Bogus;
using ModelContextProtocol.Server;

/// <summary>
/// Tools for generating random text content.
/// </summary>
internal class TextTools
{
    private readonly Faker _faker = new Faker();

    [McpServerTool]
    [Description("Generates random lorem ipsum text.")]
    public string GetRandomText(
        [Description("Number of sentences to generate")] int sentences = 3)
    {
        return _faker.Lorem.Sentences(sentences);
    }
}
