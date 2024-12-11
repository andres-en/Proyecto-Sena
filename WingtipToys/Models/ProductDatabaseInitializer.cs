using System.Collections.Generic;
using System.Data.Entity;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace WingtipToys.Models
{
  public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "T-shirts"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Hoodies"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Joggers"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "sneakers"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Gorras"
                },
            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
      var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "camiseta de corte clásico",
                    Description = "Es una camiseta de corte clásico y estilo casual, confeccionada en un tono beige o crema suave. Tiene mangas cortas, cuello redondo y un diseño minimalista. En el lado izquierdo del pecho, lleva una pequeña impresión con el texto en negro que dice: Thank You Being Kind",
                    ImagePath="IMG_3340.jpg",
                    UnitPrice = 60.000,
                    CategoryID = 1
                },
          new Product
          {
              ProductID = 2,
                    ProductName = "camiseta color cafe",
                    Description = "Es una camiseta de corte clásico y estilo casual, confeccionada en un tono beige o crema suave. Tiene mangas cortas, cuello redondo y un diseño minimalista. En el lado izquierdo del pecho, lleva una pequeña impresión con el texto en negro",
                    ImagePath="IMG_3328.jpg",
                    UnitPrice = 60.000,
                     CategoryID = 1
               },
                
                new Product
                {
                    ProductID = 6,
                    ProductName = "Hoodies color verde",
                    Description = "Sudadera con capucha para hombre, de gran tamaño, unisex, lavado ácido, atlética, sudadera de forro polar pesado, sudaderas vintage.",
                    ImagePath="Hoodies_1.jpg",
                    UnitPrice = 95.000,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Hoodies color negro lavado",
                    Description = "\r\nHoodie Oversized Fit con aspecto lavado.",
                    ImagePath="Hoodies_2.jpg",
                    UnitPrice = 95.000,
                    CategoryID = 2
                },
                
                new Product
                {
                    ProductID = 10,
                    ProductName = "Joggers color negro",
                    Description = "joggers corte ancho.",
                    ImagePath="Joggers_1.jpg",
                    UnitPrice = 60.000,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Joggers color gris",
                    Description = "joggers corte ancho.",
                    ImagePath="Joggers_2.jpg",
                    UnitPrice = 60.000,
                    CategoryID = 3
                },
                
                
                new Product
                {
                    ProductID = 13,
                    ProductName = "sneakers",
                    Description = "sneakers color gris, especial para la practica deportiva. " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="sneakers_1.jpg",
                    UnitPrice = 95.000,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "sneakers",
                    Description = "sneakers color negro, especial para la practica deportiva." + 
                                  "Some folding required.",
                    ImagePath="sneakers_2.jpg",
                    UnitPrice = 80.000,
                    CategoryID = 4
                },
               
                new Product
                {
                    ProductID = 16,
                    ProductName = "Gorras",
                    Description = "Gorra Image Streetwear Collection 59Fifty Cerrada New Era.",
                    ImagePath="gorra_1.png",
                    UnitPrice = 280.000,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Gorras",
                    Description = "Gorra Colombia Collection 9FORTY Ajustable New Era.",
                    ImagePath="gorra_2.png",
                    UnitPrice = 280.000,
                    CategoryID = 5
                }
            };

      return products;
    }
  }
}