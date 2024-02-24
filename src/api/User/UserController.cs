using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly UserRepository repository = new();

    public UserController() { }

    [HttpGet]
    public IEnumerable<User> GetAll()
    {
        return repository.GetAll(); 
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<User> GetById(int id)
    {
        var user = repository.GetById(id);

        if (user is null)
        {
            return NotFound();
        }

        return user; 
    }
}
