using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        // Get all ToDoItems without CompletedDate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> GetIncompleteToDoItems()
        {
            return await _context.ToDoItems
                .Where(t => t.CompletedDate == null)
                .ToListAsync();
        }

        // GET: api/todo/{id}
        // Get a specific ToDoItem by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItem>> GetToDoItemById(int id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(id);

            if (toDoItem == null)
            {
                return NotFound();
            }

            return toDoItem;
        }

        // POST: api/todo
        // Create a new ToDoItem
        [HttpPost]
        public async Task<ActionResult<ToDoItem>> CreateToDoItem(ToDoItem toDoItem)
        {
            _context.ToDoItems.Add(toDoItem);
            await _context.SaveChangesAsync();

            // Return the newly created item along with its URL
            return CreatedAtAction(nameof(GetToDoItemById), new { id = toDoItem.Id }, toDoItem);
        }

        // PUT: api/todo/{id}
        // Mark a ToDoItem as completed by setting the CompletedDate to the current DateTime
        [HttpPut("{id}")]
        public async Task<IActionResult> MarkAsCompleted(int id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(id);

            if (toDoItem == null)
            {
                return NotFound();
            }

            // Set CompletedDate to the current DateTime
            toDoItem.CompletedDate = DateTime.Now;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}


