namespace tasks
{
    public partial class Tasks
    {
        public static void Sol2() => new List<Student>().InitStudentsList()
            .Where(x => x.getGrade() >= 7)
            .OrderByDescending(x => x.getGrade())
            .WriteListStudents();
    }
}