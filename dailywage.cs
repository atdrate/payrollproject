

namespace employee_payroll
{
    internal class dailywage
    {
        public static void calculatedailywage()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empcheck=random.Next(0,2);
            Console.WriteLine("random value generate"+empcheck);
            if (empcheck==0)
            {
                Console.WriteLine("employee present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee absent");
                empHrs = 0;
            }
            int empwage=empHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("DAILY EMP WAGE IS "+empwage);

        }
    }
}
