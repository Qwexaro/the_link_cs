namespace tasks
{
    public class Product
    {
        string Name;

        double Price;

        int Category;

        public Product(string name, double price, int category) { Name = name; Price = price; Category = category; }

        public string getName() => Name;

        public double getPrice() => Price;

        public int getCategory() => Category;
    }
}