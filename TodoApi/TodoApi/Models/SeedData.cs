using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                // Look for any movies.
                if (context.TodoItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.TodoItems.AddRange(
                    new TodoItem
                    {
                        Name = "Turn in Lab",
                        IsComplete = true
                    },

                    new TodoItem
                    {
                        Name = "Get Job",
                        IsComplete = false
                    },

                    new TodoItem
                    {
                        Name = "Get Haircut",
                        IsComplete = false
                    },

                    new TodoItem
                    {
                        Name = "Get Sleep",
                        IsComplete = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
