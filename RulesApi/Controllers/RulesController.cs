using Microsoft.AspNetCore.Mvc;
using RulesApi.Models;

namespace RulesApi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RulesController : ControllerBase
{
  [HttpGet("Consistency")]
  public ActionResult<List<RuleModel>> GetConsistencyRules()
  {
    var rules = new List<RuleModel>
    {
      new RuleModel{ Name = "Do you understand the value of consistency?", Url = "https://www.ssw.com.au/rules/do-you-understand-the-value-of-consistency", },
    };
    return Ok(rules);
  }
}