

namespace employee_payroll
{
    internal class whileloopmonthlywage
    {
        public static void calculatewage()
        { 

            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
             const int EMP_RATE_PER_HOUR = 20;
             const int NUM_OF_WORKING_DAY = 20;
             const int MAX_HRS_IN_MONTH = 100;
        
         
            int emphrs = 0, totalemphrs = 0, totalworkingday = 0;
            while (totalemphrs <= MAX_HRS_IN_MONTH && totalworkingday < NUM_OF_WORKING_DAY)
            {
                totalworkingday++;
                Random random = new Random();
                int empcheck=random.Next(0,3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                        case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                        default:
                        emphrs = 0; 
                        break;


                }
                totalemphrs = emphrs + totalemphrs;
                Console.WriteLine("day {0} and emphrs {1}", totalworkingday, emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
           
            Console.WriteLine("total emp wage is: {0}",totalempwage);
        }
    }
}
