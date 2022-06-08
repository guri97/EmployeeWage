﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class SwitchCaseProb
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        int EmpDailyWage = 0;
        public int EmpWage = 20;

        public static int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void calculateEmpWage()
        {
            int EmpWorkingHours = 0;

            switch (IsEmployeePresent())
            {
                case IS_ABSENT:
                    EmpWorkingHours = 0;
                    break;

                case IS_PART_TIME:
                    EmpWorkingHours = 4;
                    break;

                case IS_FULL_TIME:
                    EmpWorkingHours = 8;
                    break;
            }
            EmpDailyWage = EmpWorkingHours * EmpWage;
            Console.WriteLine("Total Employee Wage = {0}", EmpDailyWage);
        }
    }
}
