using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtension;

namespace TheTestOfficeProject
{
    public class Program
    {
        static void Main(string[] args)
        {

             List<Employee> employeeList = Data.GetEmployees();

             var filteredEmployees = employeeList.Where(e => e.isActive && e.salary > 55000).ToList();

            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.name}, Department: {emp.department}, Designation: {emp.Designation}, isActive: {emp.isActive}, Salary: {emp.salary}");
            }
            Console.ReadLine(); 

           
            //List<Department> dept = Data.GetDepartments();

            //var deptFiltered = dept.Filter(d => d.DeptName.Contains("IT"));

            //foreach (var d in deptFiltered)
            //{
            //    Console.WriteLine($"DeptID: {d.DeptID}, DeptName: {d.DeptName}");
            //}
            //Console.ReadLine();
            // this is okay
        }
    }
}
