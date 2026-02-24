namespace tasks
{
    public static class ArrayExtension
    {
        public static void WriteArray(this IOrderedEnumerable<int> array) { foreach (var item in array) Console.Write($"{item} "); }

        public static int[] InitArray(this int[] array) => array = new int[] { 5, 2, 9, 1, 7, 6, 3 };
    }
}