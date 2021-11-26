using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageCalculation
    {
        int PartTime = 1;
        int FullTime = 2;
        int PerHrRate = 20;
        int emp_hr = 0;
        int emp_wage = 0;
        Random random_num = new Random();
        public int EmpWage()
        {
            int checkemp = random_num.Next(0, 2);
            if (checkemp == PartTime)
            {
                emp_hr = 8;
            }
            else if (checkemp == FullTime)
            {
                emp_hr = 16;
            }
            else
            {
               emp_hr = 0;
            }
            emp_wage = emp_hr * PerHrRate;
            Console.WriteLine("Part Time Employee Wage:-" + emp_wage);
            return emp_wage;
        }
        
    }
}
