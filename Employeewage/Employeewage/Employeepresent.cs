using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class DailyEmpWage
    {
        int Is_EmpPresent = 1;
        int Wage_Per_Hour = 20;
        int FullDay_Hour = 8;
        int DailyWage = 0;

        public void CheckDailyEmpWg()
        {
            Random CheckEmp = new Random();
            int value = CheckEmp.Next(0, 2);
            if (value == Is_EmpPresent)
            {
                DailyWage = FullDay_Hour * Wage_Per_Hour;

                Console.WriteLine("Employee Present and DailyWage = {0}", DailyWage);

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
