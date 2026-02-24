namespace tasks
{
    public class Task1
    {
        public static void Sol1()
        {
            int[] numbers = { 5, 2, 9, 1, 7, 6, 3 };

            var newNumbers = numbers.Select(x => x).Where(x => x > 4).OrderBy(x => x);

            foreach (var number in newNumbers) { Console.WriteLine(number); }
        }

        public static void Sol2()
        {
            List<Student> students = new() 
            {
                new Student("Maxim", 5), 
                new Student("Timur", 3), 
                new Student("Dima", 9), 
                new Student("Lexa", 2), 
                new Student("Sokrat", 10), 
                new Student("Eldar", 12), 
                new Student("Leon", 14), 
                new Student("Kirill", 9)
            };

            var sortStudent = students.Select(x => x).Where(x => x.getGrade() >= 7).OrderByDescending(x => x);

            foreach (var student in sortStudent) 
                Console.WriteLine($"Студент: {student.getName()}, Оценка - {student.getGrade()}");
        }
    }

    public class Student
    {
        string Name;

        int Grade;

        public Student(string name, int grade) { Name = name; Grade = grade; }

        public int getGrade() => Grade;

        public string getName() => Name;
    }
}
