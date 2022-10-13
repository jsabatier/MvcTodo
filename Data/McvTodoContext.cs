using Microsoft.EntityFrameworkCore;
using MvcTodo.Models;

namespace MvcMovie.Data;

public class MvcTodoContext : DbContext
{
    public DbSet<Todo> Todos { get; set; } = null!;
    public string DbPath { get; private set; }

    public MvcTodoContext()
    {
        // Path to SQLite database file
        DbPath = "MvcTodo.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}