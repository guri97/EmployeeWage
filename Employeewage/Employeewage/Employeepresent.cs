﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class PartTimeEmpWage
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int WagePerHour = 20;
        public int FullDayHour = 4;
        public int PartTimeDayHour = 4;
        public int DailyWage = 0;


        public void CheckPartTimeEmpWage()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    DailyWage = WagePerHour * FullDayHour;
                    Console.WriteLine("Employee is Present,in Full time and DailyWage = {0}", DailyWage);
                }
                else
                {
                    DailyWage = WagePerHour * PartTimeDayHour;
                    Console.WriteLine("Employee is present,in Part time and DailyWage = {0}", DailyWage);
                }
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
