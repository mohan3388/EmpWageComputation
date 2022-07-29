using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmpWage
{
    public class EmpWage
    {
            const int Is_FullTime = 1;
            const int Is_PartTime = 2;
            const int Emp_Rate_Per_Hrs = 20;
            const int Emp_Wrk_Day_Per_Month = 20;
        public static void CheckEmployee()
        {
           
            
            int EmpHrs = 0;
            int EmpWage = 0;


            for (int i = 1; i <= Emp_Wrk_Day_Per_Month; i++)
            {
                Random random = new Random();
                int Check = random.Next(3);


                switch (Check)
                {
                    case 0:
                        Console.WriteLine("Day: "+i+" Employee Is Present");
                        EmpHrs += 8;
                        break;
                    case 1:
                        Console.WriteLine("Day: "+i +" Employee Is Parttime Present");
                        EmpHrs += 4;
                        break;
                    case 2:
                        Console.WriteLine("Day: "+i +" Employee Is Absent");
                        EmpHrs = 0;
                        break;


                }
            }
           
            EmpWage = EmpHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Empwage: " + EmpWage);
        }
    }
}
