using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmpWage
{
    public class EmpWage
    {
        const int WAGE_PER_HOUR = 20, IS_FULL_DAY_HOUR = 8, IS_PART_TIME_HOUR = 4;
        const int IS_FULL_TIME_PRESENT = 1, IS_PART_TIME_PRESENT = 2, WORKING_DAYS_PER_MONTH = 20;
        

        public static void CheckEmployee()
        {
            int empHrs=0, totalEmpHrs=0, totalWorkingDays;

            for(int i=0; i<=WORKING_DAYS_PER_MONTH; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME_PRESENT:
                        empHrs = IS_FULL_DAY_HOUR;
                        break;

                    case IS_PART_TIME_PRESENT:
                        empHrs = IS_PART_TIME_HOUR;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                int TotalWageADay = empHrs * WAGE_PER_HOUR;
                
                Console.WriteLine("Days :" + i + "  " + "Emp Hrs: " + empHrs +" Emp Rs.: "+ TotalWageADay);
            }
            int totalEmpWage = totalEmpHrs * WAGE_PER_HOUR;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
