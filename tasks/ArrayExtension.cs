namespace tasks
{
    public static class ArrayExtension
    {
        public static void WriteArray(this IOrderedEnumerable<int> array) => Console.WriteLine(string.Join(", ", array));
    }
}