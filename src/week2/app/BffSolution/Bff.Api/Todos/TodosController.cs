using Bff.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bff.Api.Todos;

public class TodosController(TodosDataContext _context) : ControllerBase
{
    [HttpGet("/todos")]
    public async Task<IActionResult> GetAllTodosAsync()
    {
        var response = await _context.Todos.ToListAsync();
        return Ok(response);
    }

    [HttpPost("/todos")]
    public async Task<IActionResult> AddATodo([FromBody] CreateTodoRequest request)
    {
        // validate it - description is required, min length 3, maximum length 150
        //               dueDate >= Today's Date
        // If it's not valid, return a 400. 
        // if it is valid -
        // Write something to the database (we are stateless here)
        var todoToAdd = new TodoEntity
        {
            Description = request.Description,
            CreatedDate = DateTimeOffset.Now,
            DueDate = request.DueDate,
            Priority = request.Priority
        };
        _context.Todos.Add(todoToAdd);
        await _context.SaveChangesAsync();
        // send them back 
        var response = new CreateTodoResponse
        {
            Id = todoToAdd.Id,
            Description = todoToAdd.Description,
            DueDate = todoToAdd.DueDate,
            Priority = todoToAdd.Priority
        };
        return Ok(response);
    }
}
