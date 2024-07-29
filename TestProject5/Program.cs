using System.Globalization;
using TestProject5.Entities;

Console.Write("Enter the number of employees: ");
var n = int.Parse(Console.ReadLine()!);

var employeesList = new List<Employee>();

for (int i = 1; n >= i; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsorced (y/n)? ");
    var test = Console.ReadLine()!.ToLower();
    Console.Write("Name: ");
    var name = Console.ReadLine()!;
    Console.Write("Hours: ");
    var hours = int.Parse(Console.ReadLine()!);
    Console.Write("Value per Hour: ");
    var valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
    if (test == "y")
    {
        Console.Write("Additional charge: ");
        var additionalCharge = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        var employee = new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge);
        employeesList.Add(employee);
    }
    else
    {
        var employee = new Employee(name, hours, valuePerHour);
        employeesList.Add(employee);
    }
}

foreach (var employee in employeesList)
{
    Console.WriteLine($"{employee.Name} {employee.Payment().ToString("f2", CultureInfo.InvariantCulture)}");
}