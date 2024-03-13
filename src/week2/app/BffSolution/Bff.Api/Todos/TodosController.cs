using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Todos;

public class TodosController : ControllerBase
{
    [HttpPost("/todos")]
    public IActionResult AddATodo([FromBody] CreateTodoRequest request)
    {
        // validate it - description is required, min length 3, maximum length 150
        //               dueDate >= Today's Date
        // If it's not valid, return a 400. 
        // if it is valid -
        // Write something to the database (we are stateless here)
        // send them back 
        var response = new CreateTodoResponse
        {
            Id = Guid.NewGuid(),
            Description = request.Description,
            DueDate = request.DueDate,
            Priority = request.Priority
        };
        return Ok(response);
    }
}
