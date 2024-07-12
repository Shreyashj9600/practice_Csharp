namespace COPY_CONSTRUCTOR
{
    class Example
    {
        public string name;
        public int age;

        public Example(string name, int age)
        { 
            this.name = name;
            this.age = age;
        }

        public Example(Example e)
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("your name is : {0}" , name);
            Console.WriteLine("your name is : {0}" , age);
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("rohit", 10);
            obj.getData();

            Example obj1 = new Example(obj);
            obj1.getData();

            Console.ReadLine();
        }
    }
}
