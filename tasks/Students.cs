namespace tasks
{
    public class Student
    {
        string Name;

        int Grade;

        public Student(string name, int grade) { Name = name; Grade = grade; }

        public int getGrade() => Grade;

        public string getName() => Name;
    }
}