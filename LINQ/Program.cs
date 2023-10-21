using LINQ.MethodSyntax;
using LINQ.MixedSyntax;
using LINQ.Models;
using LINQ.QuerySyntax;
using System.Collections.Generic;


// Method syntax
//MethodSyntaxExample.Run();

//Query syntax
//QuerySyntaxExample.Run

//Mixed syntax
//MixedSyntaxExample.Run();


var employee = from emp in Employee.GetAllAsync() select new Employee()
{
    FirstName = emp.FirstName,
    Position = emp.Position,
    Salary = emp.Salary * 12,
};

var result = Employee.GetAllAsync().SelectMany(employee => employee.ProgrammingLanguages,
    (employee, language) => new { employee.FirstName, Language = language });

foreach (var item in result)
{
    Console.WriteLine(item.FirstName + " " + item.Language);
}

