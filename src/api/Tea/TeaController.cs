using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("teas")]
public class TeaController : ControllerBase
{
    private readonly TeaRepository repository = new();

    public TeaController() { }

    [HttpGet]
    public IEnumerable<Tea> Get()
    {
        return repository.Get(); 
    }
}
