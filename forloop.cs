

namespace employee_payroll
{
    internal class forloop
    {
        public static void calculateEmployeemonthwage()
        {
            int empHour=0;
            int empWages = 0;
            int totalempWages = 0;
            const int EM_RATE_PER_HOUR = 20;
            for (int day = 1; day < 28; day++)
            {
                Console.WriteLine("employee day is"+day);
                Random random = new Random();
                int empcheck=random.Next(1,3);
                switch (empcheck)
                {
                    case 1:
                        empHour = 8;
                        break;
                        case 2:
                        empHour=4;
                        break;
                    case 3:
                        empHour = 0;
                        break;
                }
                empWages=empHour*EM_RATE_PER_HOUR;
               totalempWages+=empWages;
                Console.WriteLine("employee  salarry is"+empWages);
                Console.WriteLine("total employee monthly wage "+totalempWages);

            }
        }
    }
}
