namespace tasks
{
    public partial class Tasks
    {
        public static void Sol1()
        {
            int[] numbers = { 5, 2, 9, 1, 7, 6, 3 };

            numbers.Select(x => x).Where(x => x > 4).OrderBy(x => x).WriteArray();
        }
    }
}
