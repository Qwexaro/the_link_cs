namespace tasks
{
    public static class ListExtension
    {
        public static void WriteListStudents(this IEnumerable<Student> students)
        {
            foreach (var student in students) Console.WriteLine($"\nСтудент: {student.getName()}, Оценка - {student.getGrade()}");
        }
        
        public static void WriteListProducts(this IEnumerable<Product> products)
        {
            foreach (var product in products) 
                Console.WriteLine($"\nПродукт: {product.getName()}, Цена - {product.getPrice()}, Категория - {product.getCategory()}");
        }

        public static List<Student> InitStudentsList(this List<Student> students)
        {
            students.Add(new("Maxim", 5)); students.Add(new("Timur", 3)); 

            students.Add(new("Dima", 9)); students.Add(new("Eldar", 10)); 
            
            students.Add(new("Lexa", 2)); students.Add(new("Sokrat", 10)); 
            
            students.Add(new("Leon", 10)); students.Add(new("Kirill", 9));

            return students;
        }

        public static List<Product> InitProductList(this List<Product> products)
        {
            products.Add(new("Хлеб", 2.5, 1)); products.Add(new("Телефон", 15000, 2));

            products.Add(new("Молоко", 1.8, 1)); products.Add(new("Ноутбук", 50000, 2));

            products.Add(new("Мука", 3.5, 1)); products.Add(new("Блютуз колонка", 3000, 2));

            products.Add(new("Чокопай", 2.8, 1)); products.Add(new("Провод type-c", 500, 2));

            return products;
        }
    }
}