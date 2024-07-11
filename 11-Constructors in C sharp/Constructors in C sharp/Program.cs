namespace Constructors_in_C_sharp
{
    internal class Program
    {
        public Program() 
        {
            Console.WriteLine("constructor innvokes !!");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
