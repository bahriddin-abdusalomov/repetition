namespace LINQ.LINQ_HOME_TASK
{
    public class HomeTasK
    {
        public static void Main()
        {
            // Problem 1
            //List<int> numbers = new List<int>() { 1, 2, 3,4 ,5, 6, 7, 8, 9, 0, 11, 12, 14, 15, 35, 46 };

            //List<int> evenNumbers = numbers.Where(number => number % 2 == 0).ToList();
            //evenNumbers.ForEach(number => Console.Write(number + " "));
            //Console.WriteLine();

            //List<int> evenNumbers_ = (from number in numbers where number % 2 == 0 select number).ToList();
            //evenNumbers_.ForEach(number => Console.Write(number + " "));


            //Problem 2
            //List<int> numbers = new List<int> { 1, 2, 3, -1, -4, -12, 13, 14, 15, 30, -123 };

            //List<int> result = numbers.Where(number => number > 0).ToList();
            //result.ForEach(number => Console.WriteLine(number + " "));


            //Problem 3
            //List<int> numbers = new List<int> { 1, 2, 3, -1, -4, -12, 13, 14, 15, 30, -123 };

            //List<int> result = numbers.Select(number => number * number).ToList();
            //result.ForEach(number => { Console.WriteLine(number + " "); });

            // Problem 4
            //List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 6, 2, 4, 1, 4, 4, 5, 6, 2, 4 };

            //var result = numbers.GroupBy(x => x).ToList();
            //result.ForEach(numberGroup => Console.WriteLine($"{numberGroup.Key}: {numberGroup.Count()} "));

            // Problem 5
            //string word = "Assalomu alaykum";

            //var result = word.GroupBy(word => word).ToList();
            //result.ForEach(character => Console.WriteLine($"{character.Key}: {character.Count()}"));

            // Problem 6
            //List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 6, 2, 4, 1, 4, 4, 5, 6, 2, 4 };

            //var result = numbers.GroupBy(x => x).ToList();
            //result.ForEach(numberGroup => Console.WriteLine(
            //    $"{numberGroup.Key} => {numberGroup.Key * numberGroup.Count()} => {numberGroup.Count()} "));

            // Problem 7
            //List<string> city = new List<string>()
            //{
            //     "ROMA","LONDON","NAYROBI","KALIFORNIYA","ZURIX","YANGI DELHI","AMSTERDAM","ABU DHABI","PARIS"
            //};

            //var result = city.Where(city => city.StartsWith("A")  && city.EndsWith("M")).ToList();
            //result.ForEach(city => { Console.WriteLine(city); });

            // Problem 8
            //List<int> numbers = new List<int>() { 123, 12, 120, 456, 6, 324, 43, 6547, 345, 234, 45 };

            //var result = numbers.Where(x => x > 80).ToList();
            //result.ForEach(x => Console.WriteLine(x));


            // Problem 9
            //List<int> numbers = new List<int>() { 123, 12, 120, 456, 6, 324, 43, 6547, 345, 234, 45 };

            //int result = numbers.Count();
            //Console.WriteLine(result);

            // Problem 10
            //List<string> list = new List<string>() { "Assalomu alaykum", "salom", "Yaxshimisiz", "birodar" };

            //var result = list.Where(word => (int)word[0] < 90).ToList();
            //result.ForEach(word => { Console.WriteLine(word); });

            // Problem 11
            //List<string> list = new List<string>() { "Assalomu alaykum", "Yaxshimisiz", "birodar" };

            //var result = string.Join(" ", list);
            //Console.WriteLine(result);

        }
    }   
}
