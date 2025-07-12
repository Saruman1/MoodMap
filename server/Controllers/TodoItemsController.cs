using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoItemsController : ControllerBase
{
    private static readonly List<TodoItem> Items = new();

    [HttpGet]
    public ActionResult<IEnumerable<TodoItem>> GetAll()
    {
        return Ok(Items);
    }

    [HttpPost]
    public ActionResult<TodoItem> Create(TodoItem item)
    {
        item.Id = Items.Count + 1;
        Items.Add(item);
        return CreatedAtAction(nameof(GetAll), new { id = item.Id }, item);
    }
}
