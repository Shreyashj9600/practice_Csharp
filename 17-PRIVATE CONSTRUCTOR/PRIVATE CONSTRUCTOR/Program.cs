namespace PRIVATE_CONSTRUCTOR
{
    class Example
    {
        public Example() { }
        private Example() 
        {
            
        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }

    //class Example2 : Example
    //{
        
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example e = new Example();
            Example.getTime(); 
        }
    }
}
