namespace Constructor_overloading_in_c_Sharp
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("this is a first constructor");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("this is a second constructor" + (a + b) );
        }
        public Program(string name)
        {
            Console.WriteLine("this is a third  constructor : " + name);
        }
        public Program(string fullname, int age)
        {
            Console.WriteLine("this is a fourth " + fullname, age);
        }
        static void Main(string[] args)
        {
            Program p = new Program(2,2);
        }
    }
}
