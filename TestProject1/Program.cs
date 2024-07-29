using System.Globalization;
using TestProject1.Entities;
using TestProject1.ProductClasses;
using TestProject1.Entities.Enum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string nameDepartment = Console.ReadLine()!;

        Console.WriteLine("Enter worker data:");
        Console.Write("Name: ");
        string nameWorker = Console.ReadLine()!;

        Console.Write("Level (Junior/MidLevel/Senior): ");
        var levelWorker = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Department department = new Department(nameDepartment!);
        var worker = new Worker(nameWorker!, levelWorker, baseSalary, department);

        Console.Write("How many contracts to this worker? ");
        int quantityWorkers = int.Parse(Console.ReadLine()!);

        for (int i = 1; quantityWorkers >= i; i++)
        {
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            string date = Console.ReadLine()!;
            DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConverted);
            Console.Write("Value per Hour: ");
            double valueHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine()!);

            var contract = new HourContract(dataConverted, valueHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine()!;

        if (!DateTime.TryParseExact(monthAndYear, "MM/yyyy", CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out DateTime monthAndYearConverted))
            Console.WriteLine("Invalid Date");


        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Department: {worker.Department!.Name}");
        Console.WriteLine($"Income for {monthAndYearConverted:MM/yyyy}: {worker.Income(monthAndYearConverted.Month, monthAndYearConverted.Year).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}