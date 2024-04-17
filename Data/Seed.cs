using WebAppStudy.Data.Enum;
using WebAppStudy.Models;

namespace WebAppStudy.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Clubs.Any())
                {
                    context.Clubs.AddRange(new List<Club>()
                    {
                        new Club()
                        {
                            Title = "Running Club 1",
                            Image = "src/~",
                            Description = "This is descriptions for running Club 1",
                            ClubCategory = ClubCategory.City,
                            Adress = new Adress()
                            {
                                Street = "123 Main St",
                                City = "USA",
                                State = "NC"
                            }
                        },
                        new Club()
                        {
                            Title = "Running Club 2",
                            Image = "src/~",
                            Description = "This is descriptions for running Club 2",
                            ClubCategory = ClubCategory.City,
                            Adress = new Adress()
                            {
                                Street = "123 Main St 2",
                                City = "USA",
                                State = "NC"
                            }
                        },
                        new Club()
                        {
                            Title = "Running Club 3",
                            Image = "src/~",
                            Description = "This is descriptions for running Club 3",
                            ClubCategory = ClubCategory.City,
                            Adress = new Adress()
                            {
                                Street = "123 Main St 3",
                                City = "USA",
                                State = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
