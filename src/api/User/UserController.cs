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
    public User GetById(int id)
    {
        return repository.GetById(id);
    }
}
