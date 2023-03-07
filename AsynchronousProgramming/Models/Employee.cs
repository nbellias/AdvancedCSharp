using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { Id = 101, Name = "Mark", Department = "IT", City = "London", Salary = 55000 },
                new Employee() { Id = 102, Name = "Mary", Department = "HR", City = "Paris", Salary = 45000 },
                new Employee() { Id = 103, Name = "John", Department = "IT", City = "New York", Salary = 65000 },
                new Employee() { Id = 104, Name = "Pam", Department = "HR", City = "London", Salary = 35000 },
                new Employee() { Id = 105, Name = "Todd", Department = "IT", City = "Chennai", Salary = 25000 },
                new Employee() { Id = 106, Name = "Sara", Department = "IT", City = "London", Salary = 55000 },
                new Employee() { Id = 107, Name = "David", Department = "HR", City = "London", Salary = 45000 },
                new Employee() { Id = 108, Name = "Sam", Department = "IT", City = "New York", Salary = 65000 },
                new Employee() { Id = 109, Name = "Ram", Department = "HR", City = "London", Salary = 35000 },
                new Employee() { Id = 110, Name = "Ron", Department = "IT", City = "Chennai", Salary = 25000 }
            };
            return listEmployees;
        }

    }
}
