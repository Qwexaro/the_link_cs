namespace tasks
{
    public partial class Tasks
    {
        public static void Sol1()
        {
            int[] numbers = { 5, 2, 9, 1, 7, 6, 3 };

            var newNumbers = numbers.Select(x => x).Where(x => x > 4).OrderBy(x => x);

            foreach (var number in newNumbers) Console.WriteLine(number);
        }
    }
}
