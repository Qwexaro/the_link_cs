using tasks;

class Program 
{
    static void Main() 
    {
        // Задача 1

        new int[7].InitArray().Where(x => x > 4).OrderBy(x => x).WriteArray();

        // Задача 2

        new List<Student>().InitStudentsList().Where(x => x.getGrade() >= 7).OrderByDescending(x => x.getGrade()).WriteListStudents();

        // Задача 3

        new List<Product>().InitProductList().Where(x => x.getCategory() == 1).OrderBy(x => x.getPrice() > 2.0).WriteListProducts();
    } 
}