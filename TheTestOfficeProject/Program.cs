//using System.Reflection.Metadata;
//using System.Security.Cryptography.X509Certificates;
//using TCPData;
//using TCPExtension;

//namespace TheTestOfficeProject
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {

//            List<Employee> employeeList = Data.GetEmployees();

//            var filteredEmployees = employeeList.Where(e => e.isActive && e.salary > 55000).ToList();

//            foreach (var emp in filteredEmployees)
//            {
//                Console.WriteLine($"ID: {emp.Id}, Name: {emp.name}, Department: {emp.department}, Designation: {emp.Designation}, isActive: {emp.isActive}, Salary: {emp.salary}");
//            }
//            Console.ReadLine();

//            List<Employee> employeeList = Data.GetEmployees();
//            List<Department> dept = Data.GetDepartments();


//            select and where opartion in Method Synthex
//            var result = employeeList.Select(e => new
//            {

//                Name = e.name,
//                salary = e.salary


//            }).Where(e => e.salary > 50000);
//            foreach (var emp in employeeList)
//            {
//                Console.WriteLine($"Name: {emp.name}, Salary: {emp.salary}");
//            }


//            select and where opartion in Query Synthex

//            var result = from emp in employeeList
//                         where emp.salary > 50000
//                         select new
//                         {
//                             Name = emp.name,
//                             Salary = emp.salary
//                         };

//            foreach (var emp in employeeList)
//            {
//                Console.WriteLine($"Name: {emp.name}, Salary: {emp.salary}");
//            }

//            Console.ReadKey();

//            //Deferred Execution Example
//            var result = from emp in employeeList.GetHighestSalaryEmployee() select new { name = emp.name, salary = emp.salary };
//            foreach (var emp in employeeList)
//            {
//                Console.WriteLine($"Name: {emp.name}, Salary: {emp.salary}");
//            }
//            Console.ReadKey();

//            var result = from e in employeeList
//                         join d in dept on e.deptId equals d.DeptID
//                         where e.isActive && e.salary > 50000
//                         select new
//                         {
//                             e.Id,
//                             e.name,
//                             e.department,
//                             e.Designation,
//                             e.isActive,
//                             e.salary,
//                             d.DeptName
//                         };
//            var avarageSalary = result.Average(e => e.salary);
//            Console.WriteLine($"Avarage Salary: {avarageSalary}");
//            var totalSalary = result.Sum(e => e.salary);
//            Console.WriteLine($"Total Salary: {totalSalary}");
//            var minSalary = result.Min(e => e.salary);
//            Console.WriteLine($"Min Salary: {minSalary}");
//            foreach (var emp in result)
//            {
//                Console.WriteLine($"ID: {emp.Id}, Name: {emp.name}, Department: {emp.department}, Designation: {emp.Designation}, isActive: {emp.isActive}, Salary: {emp.salary}, DeptName: {emp.DeptName}");
//            }
//            Console.ReadLine();

//            List<Department> dept = Data.GetDepartments();

//            var deptFiltered = dept.Filter(d => d.DeptName.Contains("IT"));

//            foreach (var d in deptFiltered)
//            {
//                Console.WriteLine($"DeptID: {d.DeptID}, DeptName: {d.DeptName}");
//            }
//            Console.ReadLine();
//            this is okay
//        }
//    }
//}
