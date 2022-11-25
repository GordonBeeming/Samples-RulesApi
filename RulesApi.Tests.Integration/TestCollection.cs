namespace RulesApi.Tests.Integration;

[CollectionDefinition(Definition)]
public sealed class TestCollection : ICollectionFixture<RulesApiFactory>
{
  public const string Definition = "Rules Api Collection";
}