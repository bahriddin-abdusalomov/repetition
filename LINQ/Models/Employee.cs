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
        public List<string> Tools { get; set; }

        public static List<Employee> GetAllAsync()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Bahriddin", LastName = "Abdusalomov", Position = "Middle", Salary = 1500,
                    ProgrammingLanguages = new List<string>() { "c++", "java"  },
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 2, FirstName = "Lazizbek", LastName = "Xoshimov", Position = "Middle", Salary = 1200,
                    ProgrammingLanguages = new List<string>() { "c++", "C#"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 3, FirstName = "Jasurbek", LastName = "Ubaydullayev", Position = "Junior", Salary = 700 ,
                    ProgrammingLanguages = new List<string>() { "c++", "c"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 3, FirstName = "Jasurbek", LastName = "Nosirov", Position = "Junior", Salary = 700 ,
                    ProgrammingLanguages = new List<string>() { "c++", "c"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 4, FirstName = "Ibrat", LastName = "Ibroximov", Position = "Middle", Salary = 1500,
                    ProgrammingLanguages = new List<string>() { "c++", "php"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 5, FirstName = "Muhammadali", LastName = "Akbarov", Position = "Senior", Salary = 3000 ,
                    ProgrammingLanguages = new List < string >() { "c++", "C#" },
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 6, FirstName = "Kamoliddin", LastName = "Isrofilov", Position = "Junior", Salary = 600,
                    ProgrammingLanguages = new List<string>() { "php", "java"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 7, FirstName = "Abrorjon", LastName = "Ortiqboyev", Position = "Junior", Salary = 800,
                    ProgrammingLanguages = new List<string>() { "c++", "java"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 7, FirstName = "Abrorjon", LastName = "Mominov", Position = "Junior", Salary = 800,
                    ProgrammingLanguages = new List<string>() { "c++", "java"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
                new Employee() { Id = 7, FirstName = "Abrorjon", LastName = "Javlonov", Position = "Junior", Salary = 800,
                    ProgrammingLanguages = new List<string>() { "c++", "java"},
                    Tools = new List<string>(){"add", "sufoiwebf"}},
            };

            return list;

        }
    }
}