using TestProject1.ProductClasses;
using TestProject1.Entities.Enum;

namespace TestProject1.Entities
{
    public class Worker
    {
        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department? Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double totalSalary = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    totalSalary += contract.TotalValue();
                }
            }
            return totalSalary;
        }
    }
}