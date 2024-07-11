namespace Constructor_in_C_sharp
{
    internal class Empolyes
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public Empolyes(int EmpId, string EmpName, int EmpAge) 
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }
        public int getId()
        {
            return this.EmpId;
        }
        public string getEmpName() 
        {
            return this.EmpName;
        }
        public int getAge() 
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            Empolyes rohit = new Empolyes(1,"rohit",10);

            Console.WriteLine(rohit.getId());
            Console.WriteLine(rohit.getEmpName());
            Console.WriteLine(rohit.getAge());
           
                Console.ReadLine();

        }
    }
}
