namespace method_or_function
{
    internal class Program
    {
        public void show() 
        {
            Console.WriteLine("welcome to c sharp programming...");
            Console.WriteLine("hello wordl !");
        }

        public static void show1()
        {
            Console.WriteLine("hello wordl !");
            Console.WriteLine("welcome to c sharp programming...");
        }

        public void Add(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addation result is : " + result);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.show();

            Console.WriteLine("Enter a first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());

            p1.Add(num1,num2);

            Program.show1();
            Console.WriteLine();
        }
    }
}
