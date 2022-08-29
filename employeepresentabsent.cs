

namespace employee_payroll
{
    internal class employeepresentabsent
    {
        internal static object employeeatendance;

        public static void employeeattendancecheck()
        {
            Random random = new Random();
            int empcheck=random.Next(0,2);
            Console.WriteLine("generate random value"+empcheck );
            if (empcheck == 0)

            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
