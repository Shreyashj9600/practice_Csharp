namespace classe_and_object
{
    internal class Student
    {
        int RollNo;
        string Name;
        int age;
        int standerd;

        public void setStudent(int RollNo, string Name, int age, int standerd)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.age = age;
            this.standerd = standerd;
        }
        public void getStudent()
        {
            Console.WriteLine("roll no is :" + this.RollNo);
            Console.WriteLine("name is :" + this.Name);
            Console.WriteLine("age is :" + this.age);
            Console.WriteLine("standerd is : " + this.standerd);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Roll no");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your standerd");
            int std = int.Parse(Console.ReadLine());

            Student rohit = new Student();
            Console.WriteLine("student information");
            rohit.setStudent(roll , name, age, std);
            rohit.getStudent();
        }
    }
}
