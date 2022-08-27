

namespace employee_payroll
{
    internal class calculatepercantage
    {
      public static void parttimewage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PARTTIME=2;
            const int EM_RATE_PER_HOUR = 20;
            int empHour=0;   
            Random random = new Random();   
            int empcheck=random.Next(1,3);
            if (empcheck == IS_FULL_TIME)
            {
                empHour = 8;
                Console.WriteLine("employee present for full time");

            }
            else if (empcheck == IS_PARTTIME) 
            {
                empHour = 4;
                Console.WriteLine("employee present for half time");
            }
                  else
            {
                empHour = 0;
                Console.WriteLine("employee is absent");
            }
            int empWage = empHour * EM_RATE_PER_HOUR;
            Console.WriteLine("employee daily wage icluding part and full time "+empWage);
        }
        
    }
}
