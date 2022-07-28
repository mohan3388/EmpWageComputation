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
            int Is_PartTime = 2;
            int Emp_Rate_Per_Hrs = 20;
            int Emp_Wrk_Day_Per_Month = 20;
            int Max_Wrk_Hrs = 100;

            int Day = 0;
            int EmpHrs = 0;
            int EmpWage = 0;


            while (Day <= Emp_Wrk_Day_Per_Month && EmpHrs<=Max_Wrk_Hrs)
            {
                Random random = new Random();
                int Check = random.Next(3);


                switch (Check)
                {
                    case 0:
                        Console.WriteLine(" Employee Is Present");
                        EmpHrs += 8;
                        break;
                    case 1:
                        Console.WriteLine(" Employee Is Parttime Present");
                        EmpHrs += 4;
                        break;
                    case 2:
                        Console.WriteLine(" Employee Is Absent");
                        EmpHrs = 0;
                        break;


                }
                Day++;
            }
           
            EmpWage = EmpHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Empwage: " + EmpWage);
        }
    }
}
