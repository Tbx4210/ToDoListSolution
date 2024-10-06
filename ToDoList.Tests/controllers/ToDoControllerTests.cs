using Microsoft.EntityFrameworkCore;
using ToDoList.API;
using ToDoList.Models; // Add this using directive

public class ToDoControllerTests
{
    private ToDoContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<ToDoContext>()
            .UseInMemoryDatabase(databaseName: "ToDoListDb_Test")
            .Options;

        return new ToDoContext(options);
    }
}
