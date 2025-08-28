using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee()
            {
                Id = 1,
                name = "John Doe",
                department = "IT",
                Designation = "Developer",
                isActive = true,
                salary = 60000,
                deptId = 1
            };
            employees.Add(employee);
            employee = new Employee()
            {
                Id = 2,
                name = "Jane Smith",
                department = "HR",
                Designation = "Manager",
                isActive = true,
                salary = 75000,
                deptId = 2
            };
            employees.Add(employee);

            employee = new Employee()
            {
                Id = 3,
                name = "Sam Brown",
                department = "Finance",
                Designation = "Tester",
                isActive = false,
                salary = 50000,
                deptId = 3
            };
            employees.Add(employee);


            return employees;

        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department department = new Department()
            {
                DeptID = 1,
                DeptName = "IT"
            };
            departments.Add(department);
            department = new Department()
            {
                DeptID = 2,
                DeptName = "HR"
            };
            departments.Add(department);
            department = new Department()
            {
                DeptID = 3,
                DeptName = "Finance"
            };
            departments.Add(department);
            return departments;
        }
    }
}
