class Program
{
    //public static void WriteToConsole<T>(this List<T> array)
    //{
    //    Console.WriteLine(string.Join(", ", array));
    //}

    static void Main()
    {
        //int[] numbers = { 58, 23, 15, 56 };

        //var newNumbers = numbers.Select(x => x * 2)
        //    .Where(x => x > 50)
        //    .OrderBy(x => x);

        //var newNumbers2 = from number in numbers
        //                  where number > 50
        //                  orderby number
        //                  select number * 2;


        List<string> list = new() { "David", "Loka", "Dida", "John" };

        var newList = from name in list where name.StartsWith("D") select name;

        //newList.WriteToConsole();

        foreach(var item in newList) Console.WriteLine(item);
    }
}
