using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("[controller]")]
public class TeasController : ControllerBase
{
    private readonly TeaRepository repository = new();

    public TeasController() { }

    [HttpGet]
    public IEnumerable<Tea> Get()
    {
        return repository.Get(); 
    }
}
