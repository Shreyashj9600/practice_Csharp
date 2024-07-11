namespace pass_by_value_and_pass_by_refrence
{
    internal class Program
    {
        // pass by value
        //public static void passByaaValue(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Value is :" + a);
        //}
        
        // pass by Refrance
        public static void passByRefrence(ref int a) 
        {
            a = a + 10;
            Console.WriteLine("value is Refeance is :" + a);
        }
        public static void passByOut(out int a)
        {
            a = 20;
            Console.WriteLine("value is Out is :" + a);
        }
        static void Main(string[] args)
        {
            // pass by value
            //int value = 5;
            //Program.passByaaValue(value);
            //Console.WriteLine(value);

            // pass by Refrence
            //int value = 5;
            //Program.passByRefrence(ref value);
            //Console.WriteLine(value);

            // pass by Out
            int value;
            Program.passByOut(out value);
            Console.WriteLine(value);
        }
    }
}
