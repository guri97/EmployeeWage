﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage4
{
    internal interface Interface
    {
        public interface ICompute_Emp_Wage
        {

            public void AddCompany(String CompanyName, int EmpWagePerhour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS);
            public void CalculateEmpWage(string CompanyName);


        }
    }
}
