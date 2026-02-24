namespace tasks
{
    public static class ListExtension
    {
        public static void WriteListStudents(this IEnumerable<Student> students)
        {
            foreach (var student in students) Console.WriteLine($"Студент: {student.getName()}, Оценка - {student.getGrade()}");
        }

        public static List<Student> InitStudentsList(this List<Student> students)
        {
            students.Add(new Student("Maxim", 5));
            students.Add(new Student("Timur", 3));
            students.Add(new Student("Dima", 9));
            students.Add(new Student("Lexa", 2));
            students.Add(new Student("Sokrat", 10));
            students.Add(new Student("Eldar", 12));
            students.Add(new Student("Leon", 14));
            students.Add(new Student("Kirill", 9));

            return students;
        }
    }
}