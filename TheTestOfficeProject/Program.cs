using TCPData;
using TCPExtension;

namespace TheTestOfficeProject
{
    public class Program
    {
        static void Main(string[] args)
        {

             List<Employee> employeeList = Data.GetEmployees();

             var filteredEmployees = employeeList.Filter(e => e.isActive == true);

            foreach(var emp in filteredEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.name}, Department: {emp.department}, Designation: {emp.Designation}, isActive: {emp.isActive}, Salary: {emp.salary}");
            }
            Console.ReadLine(); 
            // this is okay
        }
    }
}
