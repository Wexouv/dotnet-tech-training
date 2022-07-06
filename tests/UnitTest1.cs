using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace tests;

public class TodoTests
{
    [Fact]
    public async Task GetEmptyAsync()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetStringAsync("/todo");

        System.Console.WriteLine(JsonSerializer.Serialize(response));
    }
}
