using Microsoft.EntityFrameworkCore.Internal;
using WebApplicationTask4.Models;

namespace WebApplicationTask4
{
    public class SampleData
    {
        public static void Initialize(PerfumeContext context)
        {
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(
                    new Brand
                    {
                        Name = "Chanel",
                        Country = "France"
                    },
                    new Brand
                    {
                        Name = "Eclat d’Arpege",
                        Country = "France"
                    },
                    new Brand
                    {
                        Name = "Lanvin",
                        Country = "France"
                    },
                    new Brand
                    {
                        Name = "Armani",
                        Country = "Italy"
                    },
                    new Brand
                    {
                        Name = "Versace",
                        Country = "Italy"
                    },
                    new Brand
                    {
                        Name = "Givenchy",
                        Country = "France"
                    },
                    new Brand
                    {
                        Name = "Burberry",
                        Country = "UK"
                    },
                    new Brand
                    {
                        Name = "Kenzo",
                        Country = "French"
                    }
                );
                context.SaveChanges();
            }
            
            if (!context.Perfumes.Any())
            {
                context.Perfumes.AddRange(
                    new Perfume
                    {
                        Name = "Eclat d’Arpege",
                        Price = 1500,
                        Count = 10,
                        Volume = 30,
                        Brand = "Chanel"
                    },
                    new Perfume
                    {
                        Name = "Coco Mademoiselle",
                        Price = 6000,
                        Count = 50,
                        Volume = 50,
                        Brand = "Lanvin"
                    },
                    new Perfume
                    {
                        Name = "Acqua di Gioia",
                        Price = 4700,
                        Count = 15,
                        Volume = 50,
                        Brand = "Armani"
                    },
                    new Perfume
                    {
                        Name = "Bright Crystal",
                        Price = 4000,
                        Count = 10,
                        Volume = 50,
                        Brand = "Versace"
                    },
                    new Perfume
                    {
                        Name = "Very Irresistible",
                        Price = 4500,
                        Count = 15,
                        Volume = 50,
                        Brand = "Givenchy"
                    },
                    new Perfume
                    {
                        Name = "Chance Eau Tendre",
                        Price = 7400,
                        Count = 15,
                        Volume = 50,
                        Brand = "Chanel"
                    },
                    new Perfume
                    {
                        Name = "Body Tender",
                        Price = 2500,
                        Count = 15,
                        Volume = 60,
                        Brand = "Burberry"
                    },
                    new Perfume
                    {
                        Name = "L'eau par",
                        Price = 2400,
                        Count = 15,
                        Volume = 50,
                        Brand = "Kenzo"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}