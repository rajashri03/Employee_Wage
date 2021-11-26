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
        int Emp_Hr = 0;
        int Emp_Wage = 0;
        Random random_num = new Random();
        public int EmpWage()
        {
            int checkemp = random_num.Next(0, 3);
            switch (checkemp)
            {
                case 1:
                    Emp_Hr = 4;
                    break;
                case 2:
                    Emp_Hr = 8;
                    break;
                default:
                    Emp_Hr = 0;
                    break;
            }
            Emp_Wage = Emp_Hr * PerHrRate;
            Console.WriteLine("Part Time Employee Wage:-" + Emp_Wage);
            return Emp_Wage;
        }

    }
}