namespace Types_of_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single dimensional arrays in c sharp

            int[] myArray = new int[2];
            myArray[0] = 10;
            myArray[1] = 20; 

            foreach (int items in myArray)
            {
                Console.WriteLine(items);
            };

            Console.WriteLine("multi dimesional arrays");
            // multi dimesional arrays in c sharp
            int[,] myArr2 = new int[3, 4]
            {
                {11,22,33,44 },
                {55,66,77,88 },
                {99,11,22,33 }
            };
            Console.WriteLine(myArr2[1, 2]);
            Console.WriteLine(myArr2.GetLength(0));

            // for loop
            for (int i = 0; i < myArr2.GetLength(0); i++)
            {
                for (int j = 0; j < myArr2.GetLength(1); j++)
                {
                    Console.Write(myArr2[i , j]);
                }
                Console.WriteLine();
            }
            //for (int i = 0; i < myArr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine("print by for loop:" + myArr2[i,j]);
            //    }
            //}

            foreach (int items in myArr2)
            {
                Console.WriteLine("print by Foreach loop" + items);
            }; 
        }
    }
}
