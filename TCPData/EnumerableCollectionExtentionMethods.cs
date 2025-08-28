using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class EnumerableCollectionExtentionMethods
    {
        public static IEnumerable<Employee> GetHighestSalaryEmployee(this IEnumerable<Employee> employees)
        {
            //if (employees == null || !employees.Any())
            //{
            //    return Enumerable.Empty<Employee>();
            //}
            //decimal maxSalary = employees.Max(e => e.salary);
            //return employees.Where(e => e.salary == maxSalary);


            //foreach(var emp in employees)
            //{
            //    if (emp.salary == employees.Max(e => e.salary))
            //    {
            //        yield return emp;
            //    }
            //}
            
            foreach(var emp in employees)
            {
                Console.WriteLine($"Acessing Employee:{emp.name} and {emp.salary}");
                if(emp.salary >= 50000)
                {
                    yield return emp;
                }
            }
        }

    }
}
