using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public long Salary { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
        public static List<Employee> GetAllAsync()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Bahriddin", LastName = "Abdusalomov", Position = "Middle", Salary = 1500,
                    ProgrammingLanguages = new List<string>() { "c++", "java"} },
                new Employee() { Id = 1, FirstName = "Lazizbek", LastName = "Xoshimov", Position = "Middle", Salary = 1200,
                ProgrammingLanguages = new List<string>() { "c++", "C#"}},
                new Employee() { Id = 1, FirstName = "Jasurbek", LastName = "Ubaydullayev", Position = "Junior", Salary = 700 ,
                ProgrammingLanguages = new List<string>() { "c++", "c"}},
                new Employee() { Id = 1, FirstName = "Ibrat", LastName = "Ibroximov", Position = "Middle", Salary = 1500,
                ProgrammingLanguages = new List<string>() { "c++", "php"}},
                new Employee() { Id = 1, FirstName = "Muhammadali", LastName = "Akbarov", Position = "Senior", Salary = 3000 ,
                ProgrammingLanguages = new List < string >() { "c++", "C#" }},
                new Employee() { Id = 1, FirstName = "Kamoliddin", LastName = "Isrofilov", Position = "Junior", Salary = 600,
                ProgrammingLanguages = new List<string>() { "php", "java"}},
                new Employee() { Id = 1, FirstName = "Abrorjon", LastName = "Ortiqboyev", Position = "Junior", Salary = 800,
                ProgrammingLanguages = new List<string>() { "c++", "java"}},
            };

            return list;

        }
    }
}