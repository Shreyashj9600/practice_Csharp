namespace restart_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i == 0)
                {
                   goto stop;
                }
                else if (i == 3)
                {
                    goto stop;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("loop end");

            stop:
            Console.WriteLine("program exits");

            Console.ReadLine();
        }
    }
}
