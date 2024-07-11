namespace STATIC_AND_INSTANCE_MEMBERS
{
    class Student
    {
        public int rollNo;
        public string firstName;
        public string lastName;
        public int standerd;
        public static string schoolName = "zp school mumbai";
        public static int fees = 4000;
        public void fullName()
        {
            Console.WriteLine("your full name is :" + this.firstName + " " +this.lastName  );
        }

        public static int getFees()
        {
            return fees;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student rohit = new Student();
            rohit.rollNo = 1;
            rohit.firstName = "Rohit";
            rohit.lastName = "sharma";
            rohit.standerd = 12;

            Console.WriteLine(rohit.rollNo);
            Console.WriteLine(rohit.firstName);
            Console.WriteLine(rohit.lastName);
            Console.WriteLine(rohit.standerd);
            rohit.fullName();
            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.getFees());

        }
    }
}
