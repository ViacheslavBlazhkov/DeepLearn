using DeepLearn.Data;
using Microsoft.EntityFrameworkCore;

namespace DeepLearn.Models
{
    public static class SeedDataModules
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeepLearnContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeepLearnContext>>()))
            {
                // Look for any movies.
                if (context.Module.Any())
                {
                    return;   // DB has been seeded
                }
                context.Module.AddRange(
                    new Module
                    {
                        Title = "Basics",
                        Status = Status.Current
                    },
                    new Module
                    {
                        Title = "Loops",
                    },
                    new Module
                    {
                        Title = "Methods",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
