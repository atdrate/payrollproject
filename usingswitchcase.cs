

namespace employee_payroll
{
    internal class usingswitchcase
    {
        public static void switchcaseprogram()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PARTTIME = 2;
            const int EM_RATE_PER_HOUR = 20;
            int empHour = 0;
            Random random = new Random();
            int empcheck = random.Next(1, 3);
            Console.WriteLine("random value is"+empcheck);
            switch (empcheck)
            {

                case 0:
                    Console.WriteLine("employee present for full time");
                    empHour = 8;
                    break;  
               case 1:
                    Console.WriteLine("employee present for part time");
                    empHour = 4;
                    break;
                    default:
                    Console.WriteLine("employee absent for whole day");
                    break;

                    
            }
        }
    }
}

