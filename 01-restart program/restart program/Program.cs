namespace restart_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                int add = num1 + num2;
                Console.WriteLine("Addation result is : " + add);

                Console.WriteLine("start from one more time yes / no");
                confirm = Console.ReadLine().ToLower();

            } while (confirm == "yes");

            Console.ReadLine();
        }
    }
}
