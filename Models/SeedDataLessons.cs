using DeepLearn.Data;
using Microsoft.EntityFrameworkCore;

namespace DeepLearn.Models
{
    public static class SeedDataLessons
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeepLearnContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeepLearnContext>>()))
            {
                // Look for any movies.
                if (context.Lesson.Any())
                {
                    return;   // DB has been seeded
                }
                context.Lesson.AddRange(
                    new Lesson
                    {
                        Title = "What's C#?",
                        ModuleId = 1
                    },
                    new Lesson
                    {
                        Title = "Variables",
                        ModuleId = 1
                    },
                    new Lesson
                    {
                        Title = "Text output",
                        ModuleId = 1
                    },

                    new Lesson
                    {
                        Title = "While",
                        ModuleId = 2
                    },
                    new Lesson
                    {
                        Title = "Do-while",
                        ModuleId = 2
                    },
                    new Lesson
                    {
                        Title = "For",
                        ModuleId = 2
                    },

                    new Lesson
                    {
                        Title = "Methods",
                        ModuleId = 3
                    },
                    new Lesson
                    {
                        Title = "Parameters",
                        ModuleId = 3
                    },
                    new Lesson
                    {
                        Title = "Overload",
                        ModuleId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
