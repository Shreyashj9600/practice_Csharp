namespace calculator_console_application
{
    internal class Program
    {
        public static void Addation(int num1, int num2)
        {
            int restult = num1 + num2;
            Console.WriteLine("Addation result is {0}" , restult);
        }
        public static void Subration(int num1, int num2)
        {
            int restult = num1 - num2;
            Console.WriteLine("Subration result is {0}", restult);
        }
        public static void Multiplication(int num1, int num2)
        {
            int restult = num1 * num2;
            Console.WriteLine("Multiplication result is {0}", restult);
        }
        public static void Divisition(int num1, int num2)
        {
            int restult = num1 / num2;
            Console.WriteLine("Divisition result is {0}", restult);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter you second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your operator (+, -, *, /) ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Program.Addation(num1, num2);
            }
            else if (op == "-")
            {
                Program.Subration(num1, num2);
            }
            else if (op == "*")
            {
                Program.Multiplication(num1, num2);
            }
            else if (op == "/")
            {
                Program.Divisition(num1, num2);
            }
            else
            {
                Console.WriteLine("invalied operator");
            }
            Console.ReadLine();

        }
    }
}
