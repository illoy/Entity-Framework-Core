using Task_1.Data;
using Task_1.Models;

using OrderContext context = new OrderContext();

//Customer customer1 = new Customer()
//{
//    FirstName = "Name 1",
//    LastName = "LName 1",
//    Address = "Address 1",
//    Phone = "Phone 1",
//    Email = "Email 1"
//};
//context.Add(customer1);


//Product product1 = new Product()
//{
//    Name = "Prod 1",
//    Price = 10.21M
//};
//context.Add(product1);

//Product product2 = new Product()
//{
//    Name = "Prod 2",
//    Price = 23.1M
//};
//context.Add(product2);

//Order order1 = new Order()
//{
//    Customer = customer1,
//    Product = product1
//};
//context.Add(order1);

//Order order2 = new Order()
//{
//    Customer = customer1,
//    Product = product2
//};
//context.Add(order2);

//context.SaveChanges();

var storeProduct = context.Products.ToList();

foreach (Product p in storeProduct)
{
    Console.WriteLine($"id - {p.Id}");
    Console.WriteLine($"Name - {p.Name}");
    Console.WriteLine($"Price - {p.Price}");
    Console.WriteLine(new string('-', 20));
    Console.WriteLine();
}

var orderDetails = from x in context.Order
                   join y in context.Products on x.Product.Id equals y.Id
                   join z in context.Customers on x.Customer.Id equals z.Id
                   select new
                   {
                       z.FirstName,
                       z.LastName,
                       z.Email,
                       z.Phone,
                       y.Name,
                       y.Price,
                       y.Id
                   };

//var orderDetails = from x in context.Order
//                   join y in context.Products on x.Product.Id equals y.Id
//                   select new
//                   {
//                       y.Name,
//                       y.Price,
//                       y.Id,
//                       x.Customer.FirstName,
//                       x.Customer.LastName,
//                       x.Customer.Email,
//                       x.Customer.Phone
//                   };

foreach (var item in orderDetails)
{
    Console.WriteLine($"First Name - {item.FirstName}");
    Console.WriteLine($"Last Name - {item.LastName}");
    Console.WriteLine($"Email - {item.Email}");
    Console.WriteLine($"Phone - {item.Phone}");
    Console.WriteLine(new string('-', 20));
    Console.WriteLine($"Product Name - {item.Name}");
    Console.WriteLine($"Product Prise - {item.Price}");
    Console.WriteLine($"Product id - {item.Id}");

    Console.WriteLine();
}



