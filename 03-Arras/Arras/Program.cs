namespace Arras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArr = new int[2];
            //myArr[0] = 1;
            //myArr[1] = 2;

            //Console.WriteLine(myArr[0]);

            //string[] myarr = new string[] { "shreyash", "rohit", "yash", "sanket" };
            //Console.WriteLine(myarr.Length);

            // using loops

            int[] myArr = new int[4];
            myArr[0] = 1;
            myArr[1] = 2;
            myArr[2] = 3;
            myArr[3] = 4;

            for(int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }
            Console.WriteLine("////////////////");
            foreach (int element in myArr )
            {
                Console.WriteLine(element);
            }
        }
    }
}
