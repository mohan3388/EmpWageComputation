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

            Random random = new Random();
            int Check = random.Next(2);

            if(Check==Is_FullTime)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
