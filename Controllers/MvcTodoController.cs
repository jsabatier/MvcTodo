using Microsoft.AspNetCore.Mvc;

namespace MvcTodo.Controllers;

public class HelloController : ControllerBase
{
    // GET: /Hello/
    public string Index()
    {
        return "Hello World!";
    }
}