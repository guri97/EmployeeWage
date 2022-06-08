namespace Employeewage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage");
            CalculatingWagesForMonth employeepresent = new CalculatingWagesForMonth();
            employeepresent.CheckEmpPresentAbsent();


        }
    }
}
