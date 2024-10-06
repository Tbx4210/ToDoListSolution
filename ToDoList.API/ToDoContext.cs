namespace ToDoList.API
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}

