using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UniqueBowl.Data;
using System;
using System.Linq;

namespace UniqueBowl.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UniqueBowlContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UniqueBowlContext>>()))
            {
                // Look for any movies.
                if (context.Bowl.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bowl.AddRange(
                    new Bowl
                    {
                        Name = "Classic White Cereal Bowl",
                        design = "Simple and Elegant",
                        Color = "White",
                        Size = "16 oz",
                        Price = 4.99M,
                        Rating = 4
                    },
                    new Bowl
                    {
                        Name = "Rustic Stoneware Soup Bowl",
                        design = "Rustic Charm",
                        Color = "Earthy Brown",
                        Size = "20 oz",
                        Price = 6.99M,
                        Rating = 4
                    },
                    new Bowl
                    {
                        Name = "Colorful Salad Bowl Set",
                        design = "Vibrant and Fun",
                        Color = "Assorted Colors",
                        Size = "32 oz",
                        Price = 12.99M,
                        Rating = 5
                    },
                    new Bowl
                    {
                        Name = "Japanese Ramen Bowl",
                        design = "Authentic Japanese Style",
                        Color = "Navy Blue",
                        Size = "28 oz",
                        Price = 9.99M,
                        Rating = 3
                    },
                    new Bowl
                    {
                        Name = "Glass Dessert Bowl",
                        design = "Elegant Glassware",
                        Color = "Clear",
                        Size = "10 oz",
                        Price = 3.99M,
                        Rating = 4
                    },
                    new Bowl
                    {
                        Name = "Stainless Steel Mixing Bowl",
                        design = "Sleek and Modern",
                        Color = "Silver",
                        Size = "5 qt",
                        Price = 14.99M,
                        Rating = 5
                    },
                    new Bowl
                    {
                        Name = "Porcelain Noodle Bowl",
                        design = "Asian Inspired",
                        Color = "Blue and White",
                        Size = "24 oz",
                        Price = 7.99M,
                        Rating = 3
                    },
                    new Bowl
                    {
                        Name = "Crystal Fruit Bowl",
                        design = "Crystal Elegance",
                        Color = "Transparent",
                        Size = "12 in",
                        Price = 19.99M,
                        Rating = 3
                    },
                    new Bowl
                    {
                        Name = "Bamboo Serving Bowl",
                        design = "Natural and Sustainable",
                        Color = "Light Brown",
                        Size = "16 in",
                        Price = 10.99M,
                        Rating = 5
                    },
                    new Bowl
                    {
                        Name = "Patterned Ceramic Bowl",
                        design = "Artistic Patterns",
                        Color = "Assorted Patterns",
                        Size = "18 oz",
                        Price = 8.99M,
                        Rating = 4
                    }



                );
                context.SaveChanges();
            }
        }
    }
}