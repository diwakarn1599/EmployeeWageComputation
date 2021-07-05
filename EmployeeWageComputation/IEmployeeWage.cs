using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    interface IEmployeeWage
    {
        public void AddWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours);
        public void ComputeEmpWage();

        //for saving total wage for each company
        public int GetTotalWage(string company);
    }
}
