using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmpWage
{
    public class EmpWage
    {
        public static void CheckEmployee()
        {
            int Is_FullTime = 1;
            int Emp_Rate_Per_Hrs = 20;

            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int Check = random.Next(2);

            if(Check==Is_FullTime)
            {
                Console.WriteLine("Employee Is Present");
                EmpHrs = 8;

            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Empwage: " + EmpWage);
        }
    }
}
