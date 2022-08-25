using Task_2.Data;
using Task_2.Models;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

using ShopContext shop = new ShopContext();

if (!shop.Products.Any())
{
    List<Product> products = new List<Product>();
    products.Add(new Product() { Name = "Корона", ProductNum = "AK-53818", Cost = 5, Count = 50, SellStartDate = new DateTime(2011, 8, 15) });
    products.Add(new Product() { Name = "Милка", ProductNum = "AM-51122", Cost = 2.4M, Count = 50, SellStartDate = new DateTime(2011, 7, 15) });
    products.Add(new Product() { Name = "Аленка", ProductNum = "AA-52211", Cost = 2.5M, Count = 20, SellStartDate = new DateTime(2011, 6, 15) });
    products.Add(new Product() { Name = "Snickers", ProductNum = "BS-32118", Cost = 2.8M, Count = 50, SellStartDate = new DateTime(2011, 8, 15) });
    products.Add(new Product() { Name = "Snickers", ProductNum = "BSL-3818", Cost = 5, Count = 100, SellStartDate = new DateTime(2011, 8, 20) });
    products.Add(new Product() { Name = "Bounty", ProductNum = "BB-38218", Cost = 3, Count = 100, SellStartDate = new DateTime(2011, 8, 1) });
    products.Add(new Product() { Name = "Nuts", ProductNum = "BN-37818", Cost = 3, Count = 100, SellStartDate = new DateTime(2011, 8, 21) });
    products.Add(new Product() { Name = "Mars", ProductNum = "BM-3618", Cost = 2.5M, Count = 50, SellStartDate = new DateTime(2011, 8, 24) });
    products.Add(new Product() { Name = "Свиточ", ProductNum = "AS-54181", Cost = 5, Count = 100, SellStartDate = new DateTime(2011, 8, 12) });
    products.Add(new Product() { Name = "Свиточ", ProductNum = "AS-54182", Cost = 5, Count = 100, SellStartDate = new DateTime(2011, 8, 12) });

    shop.AddRange(products);
    shop.SaveChanges();
}

var myProducts = shop.Products.OrderBy(p => p.Name).ThenBy(p => p.Cost).ToList();

foreach (var product in myProducts)
{
    Console.WriteLine(  $"id - {product.Id},\n" +
                        $"Name - {product.Name},\n" +
                        $"ProductNum - {product.ProductNum},\n" +
                        $"Cost - {product.Cost},\n" +
                        $"Count - {product.Count},\n" +
                        $"SellStartDate - {product.SellStartDate.ToString("yyyy/MM/dd")}.\n"
                        );

    Console.WriteLine();
}