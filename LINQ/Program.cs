using LINQ;
using LINQ.MethodSyntax;
using LINQ.MixedSyntax;
using LINQ.Models;
using LINQ.QuerySyntax;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;


// Method syntax
//MethodSyntaxExample.Run();

//Query syntax
//QuerySyntaxExample.Run

//Mixed syntax
//MixedSyntaxExample.Run();

// Select and SelectMany
//var employee = from emp in Employee.GetAllAsync() select new Employee()
//{
//    FirstName = emp.FirstName,
//    Position = emp.Position,
//    Salary = emp.Salary * 12,
//};

//var result = Employee.GetAllAsync().SelectMany(employee => employee.ProgrammingLanguages,
//    (employee, language) => new { employee.FirstName, Language = language });

//var result2 = Employee.GetAllAsync().Select(employee => new 
//{
//    Name = employee.FirstName,
//    ProgrammingLanguages  = string.Join(" ", employee.ProgrammingLanguages),
//    Tools = string.Join(" ", employee.Tools)
//});

//foreach (var item in result2)
//{
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.ProgrammingLanguages);
//    Console.WriteLine(item.Tools);
//}


// OrderBy OrderByDescending and ThenBy ThenByDescending


//var orderByMethod = Employee.GetAllAsync().OrderBy(emp => emp.Id).ThenBy(emp => emp.LastName).ToList();

//orderByMethod.ForEach(emp => Console.WriteLine($"{emp.Id}: {emp.LastName}"));

//var studentOrder = Student.GetAllStudents().OrderBy(studenet =>  studenet.FirstName)
//    .ThenByDescending(student => student.Course)
//    .ThenBy(student => student.Contract)
//    .ThenByDescending(student => student.Age).ToList();

//studentOrder.ForEach(student => Console.WriteLine($"{student.FirstName} {student.Course} {student.Contract} {student.Age}"));

//var studentOrderQuery = (from student in Student.GetAllStudents() 
//                         orderby student.FirstName,
//                         student.Course descending, 
//                         student.Contract, 
//                         student.Age descending 
//                         select student);

//var avgStudentContract = Student.GetAllStudents().Average(student => student.Contract);
//Console.WriteLine(avgStudentContract);

//var kechgi = Student.GetAllStudents().Any(student => student.IsKechgi == true);
//Console.WriteLine(kechgi);

//var selectKechgi =  Student.GetAllStudents().Where(student => student.IsKechgi == true).ToList();
//selectKechgi.ForEach(student => Console.WriteLine($"{student.FirstName} {student.Course}"));



//public class StudentComparer : IEqualityComparer<Student>
//{
//    public bool Equals(Student? x, Student? y)
//    {
//        if (x == null || y == null)
//            return false;
//        if(object.ReferenceEquals(x, y)) 
//            return true;

//        return x.Id == y.Id && x.FirstName == y.FirstName;
//    }

//    public int GetHashCode([DisallowNull] Student obj)
//    {
//        if(object.ReferenceEquals (obj, null))
//            return 0;

//        int hashCardId  = obj.Id.GetHashCode();

//        int hashCardName  = obj.FirstName == null ? 0 : obj.FirstName.GetHashCode();

//        return hashCardId ^ hashCardName;
//    }
//}