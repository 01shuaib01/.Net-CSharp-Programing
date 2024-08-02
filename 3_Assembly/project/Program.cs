
using _1_classLib;

namespace project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the coding era !");
            Class1 obj = new Class1();
            int a = obj.add(12, 12);
            int b = obj.sub(12, 5);

            Console.WriteLine("Value of a -> " + a);
            Console.WriteLine("Value of b -> " + b);
        }
    }
}
