namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Employee emp = new Employee();
            emp.Id = 11;
            emp.Name = "Name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            //dto t'hendab data transfer object
            EmployeeDto dto = new EmployeeDto();
            //algab mappimine

            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name);

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}