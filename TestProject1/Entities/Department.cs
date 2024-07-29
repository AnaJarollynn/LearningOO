namespace TestProject1.Entities
{
    public class Department
    {
        public string? Name { get; set; }


        public Department(string departmentName)
        {
            Name = departmentName;
        }
    }
}