using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("[controller]")]
public class TeasController : ControllerBase
{
    private static readonly Tea[] teas = new[]
    {
        new Tea("Stubb", "https://white2tea.com/products/2023-stubb-minis"),
        new Tea("Reading Room", "https://white2tea.com/products/2023-reading-room-mini"),
    };

    public TeasController() { }

    [HttpGet]
    public IEnumerable<Tea> Get()
    {
        return teas; 
    }
}
