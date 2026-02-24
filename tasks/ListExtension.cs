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
            students.Add(new("Maxim", 5)); students.Add(new("Timur", 3)); 
            students.Add(new("Dima", 9)); students.Add(new("Eldar", 12)); 
            students.Add(new("Lexa", 2)); students.Add(new("Sokrat", 10)); 
            students.Add(new("Leon", 14)); students.Add(new("Kirill", 9));

            return students;
        }
    }
}