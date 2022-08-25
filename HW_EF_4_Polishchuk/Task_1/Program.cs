using Task_1.Data;
using Task_1.Models;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

using ProductContext pc = new ProductContext();

if (!pc.Countries.Any() && !pc.Companies.Any() && !pc.Products.Any())
{
    var country1 = new Country() { Name = "Corea" };
    var country2 = new Country() { Name = "China" };
    var country3 = new Country() { Name = "USA" };
    pc.AddRange(country1, country2, country3);
    pc.SaveChanges();

    var company1 = new Company() { Name = "Company1", CountryId = country1.Id };
    var company2 = new Company() { Name = "Company2", CountryId = country2.Id };
    var company3 = new Company() { Name = "Company3", CountryId = country2.Id };
    var company4 = new Company() { Name = "Company4", CountryId = country3.Id };
    pc.AddRange(company1, company2, company3, company4);
    pc.SaveChanges();

    List<Product> products = new List<Product>()
    {
        new Product() { Name = "CoreaTea_1", Price = 0 , Company = company1 },
        new Product() { Name = "CoreaTea_2", Price = 0 , Company = company1 },
        new Product() { Name = "CoreaTea_3", Price = 0 , Company = company1 },
        new Product() { Name = "CoreaTea_4", Price = 0 , Company = company1 },

        new Product() { Name = "ChinaPhone_1", Price = 0 , Company = company2 },
        new Product() { Name = "ChinaPhone_2", Price = 0 , Company = company2 },
        new Product() { Name = "ChinaPhone_3", Price = 0 , Company = company2 },
        new Product() { Name = "ChinaPhone_4", Price = 0 , Company = company2 },

        new Product() { Name = "ChinaToy_1", Price = 0 , Company = company3 },
        new Product() { Name = "ChinaToy_2", Price = 0 , Company = company3 },
        new Product() { Name = "ChinaToy_3", Price = 0 , Company = company3 },
        new Product() { Name = "ChinaToy_4", Price = 0 , Company = company3 },

        new Product() { Name = "USACar_1", Price = 0 , Company = company4 },
        new Product() { Name = "USACar_2", Price = 0 , Company = company4 },
        new Product() { Name = "USACar_3", Price = 0 , Company = company4 },
        new Product() { Name = "USACar_4", Price = 0 , Company = company4 },
    };

    pc.Products.AddRange(products);
    pc.SaveChanges();
}

Console.Write("Enter Product Id: ");
int num = Convert.ToInt32(Console.ReadLine());
var x = new SqlParameter("@Id", num);

var productData = pc.Products.FromSqlRaw("ProductData @Id", x);

foreach (var product in productData)
{
    Console.WriteLine($"id - {product.Id},\n" +
                        $"Name - {product.Name},\n" +
                        $"Product price - {product.Price},\n" +
                        $"CompanyId - {product.CompanyId},\n"
                        );
}


