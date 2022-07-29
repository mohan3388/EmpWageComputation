using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmpWage
{
    public class EmpWage
    {
        public int Present = 1;
        public const int fulltime = 0, parttime = 1, absent = 2, wagehour = 20;

        public static void CheckEmployee()
        {

            int Emphour = 0;

       

        int EmpMonthly = 0;
             for(int i=0; i<=wagehour; i++)
            {

                Random TimeCheck = new Random();
                int CheckTime = TimeCheck.Next(0, 3);
                switch (CheckTime)
                {
                    case 0:
                        Console.WriteLine("Day: " + i + " Employee Is Present");
                        Emphour = 8;

                        break;

                    case 1:
                        Console.WriteLine("Day: " + i + " Employee Is Parttime Present");
                        Emphour = 4;

                        break;

                    case 2:
                        Console.WriteLine("Day: " + i + " Employee Is Absent");
                        Emphour = 0;

                        break;
                }
                int EmpWageDaily = Emphour * wagehour;
                Console.WriteLine("Total Empwage: "+EmpWageDaily);
                EmpMonthly += EmpWageDaily;
               
            }
            int Wage = Emphour * wagehour;
            Console.WriteLine("Monthly Wage is " + EmpMonthly);




        }
    }
}
