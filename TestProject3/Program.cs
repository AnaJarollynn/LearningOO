using System.Globalization;
using TestProject3.Entities;
using TestProject3.Entities.Enum;

Console.WriteLine("Enter Client Data:");
Console.Write("Name: ");
var nameClient = Console.ReadLine();
Console.Write("Email: ");
var emailClient = Console.ReadLine();

Console.Write("Birth Date (DD/MM/YYYY): ");
var birthDate = Console.ReadLine();
DateTime birthClient = DateTime.ParseExact(birthDate, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

var client = new Client(nameClient!, emailClient!, birthClient);

Console.WriteLine("Enter Order Data: ");

Console.Write("Status: ");
var orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine()!, true);
Console.Write("How many items to this order? ");
var orderQuantity = int.Parse(Console.ReadLine()!);

Order order = new Order(DateTime.Now, orderStatus, client);

for (int i = 1; orderQuantity >= i; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product Name: ");
    var productName = Console.ReadLine();
    Console.Write("Product Price: ");
    var productPrice = double.Parse(Console.ReadLine()!);
    Console.Write("Quantity: ");
    var productQuantity = int.Parse(Console.ReadLine()!);

    var product = new Product(productName!, productPrice);
    var orderItem = new OrderItem(productQuantity, product);

    order.AddItem(orderItem);
}

Console.WriteLine(order.ToString());
