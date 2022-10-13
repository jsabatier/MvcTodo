using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTodo.Data;
using MvcTodo.Models;

namespace MvcMovie.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoApiController : ControllerBase
{
    private readonly MvcTodoContext _context;

    public TodoApiController(MvcTodoContext context)
    {
        _context = context;
    }

    // GET: api/MovieApi
    public async Task<ActionResult<IEnumerable<Todo>>> GetMovies()
    {
        return await _context.Todos.ToListAsync();
    }
}