using RulesApi.Models;
using System.Net.Http.Json;

namespace RulesApi.Tests.Integration;

[Collection(TestCollection.Definition)]
public sealed class RulesTests
{
  private readonly RulesApiFactory rulesApiFactory;
  private readonly HttpClient httpClient;

  public RulesTests(RulesApiFactory rulesApiFactory)
  {
    this.rulesApiFactory = rulesApiFactory;
    this.httpClient = rulesApiFactory.CreateClient();
  }

  [Fact]
  public async Task Get_ReturnOkStatusCode_WhenCalled()
  {
    // Act
    var response = await httpClient.GetAsync($"/rules/consistency");

    // Assert
    response.StatusCode.Should().Be(HttpStatusCode.OK);
  }

  [Fact]
  public async Task Get_Return1Result_WhenCalled()
  {
    // Act
    var response = await httpClient.GetAsync($"/rules/consistency");

    // Assert
    var data = await response.Content.ReadFromJsonAsync<List<RuleModel>>();
    data.Should().ContainSingle();
  }
}