using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("teas")]
public class TeaController : ControllerBase
{
    private readonly TeaRepository repository = new();

    public TeaController() { }

    [HttpGet]
    public IEnumerable<Tea> GetAll()
    {
        return repository.GetAll(); 
    }
    
    [HttpGet("{id:int}")]
    public Tea GetById(int id)
    {
        return repository.GetById(id);
    }
}
