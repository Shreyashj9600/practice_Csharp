namespace static_constructor
{
    class Person
    {
        public static string name = "rohit";
        public static int age = 10;

        static Person()
        {
            Console.WriteLine("staric constructor invoke !!");
        }

        public Person() 
        {
            Console.WriteLine("defaul constructor invoke !!");
        }
        public static void getDetails()
        {
            Console.WriteLine("your name is " + name );
        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
          Person rohit = new Person();
            Person.getDetails();

          
        }
    }
}
