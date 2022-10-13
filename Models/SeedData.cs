using MvcTodo.Data;

namespace MvcTodo.Models
{
    public class SeedData
    {public static void Init()
    {
        using (var context = new MvcTodoContext())
        {
            if(context.Todos.Any())
            {
                return;
            }
            context.Todos.AddRange(
                new Todo
                {
                    Task = "Faire la cuisine",
                    Completed = false,
                    Deadline = DateTime.Now,
                },
                new Todo
                {
                    Task = "Aller chercher un chat",
                    Completed = true,
                    Deadline = DateTime.Parse("2022-11-22"),
                },
                new Todo
                {
                    Task = "Préparer affaires",
                    Completed = false,
                    Deadline = DateTime.Parse("2022-10-14"),
                }
            );
            context.SaveChanges();
        }

        }
    }
}