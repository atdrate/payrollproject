namespace employee_payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee payroll");
            Console.WriteLine("chosse option\n1 check present or absent \n2 calculate daily wage\n3calculate percentage \n4 programme with switch case \n5calculate monthly wage ");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch (opt)
            { 
              case 1:
                    employeepresentabsent.employeeattendancecheck();
                    break;
             case 2:
                    dailywage.calculatedailywage();
                    break;
                case 3:
                    calculatepercantage.parttimewage();
                    break;
                    case 4:
                    usingswitchcase.switchcaseprogram();
                    break;
                case 5:
                    forloop.calculateEmployeemonthwage();
                    break ;
            
            }

        }
    }
}