using DeepLearn.Data;
using Microsoft.EntityFrameworkCore;

namespace DeepLearn.Models
{
    public static class SeedDataThoryBlocks
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //using (var context = new DeepLearnContext(
            //    serviceProvider.GetRequiredService<
            //        DbContextOptions<DeepLearnContext>>()))
            //{
            //    // Look for any movies.
            //    if (context.TheoryBlock.Any())
            //    {
            //        return;   // DB has been seeded
            //    }
            //    context.TheoryBlock.AddRange(
            //        new TheoryBlock
            //        {
            //        },
            //        new TheoryBlock
            //        {
            //            Title = "Loops",
            //        },
            //        new TheoryBlock
            //        {
            //            Title = "Methods",
            //        }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
