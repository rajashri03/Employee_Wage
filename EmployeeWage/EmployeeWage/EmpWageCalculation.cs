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
        int TotalEmpHr = 0;
        int TotalWorkingDays = 0;
        int NumOFDays = 20;
        int MaxTotalHr = 100;
        int TotalEmpWage = 0;
        public int EmpWage()
        {
            while(Emp_Hr <= MaxTotalHr && TotalWorkingDays < NumOFDays)
            {

                TotalWorkingDays++;
                Random random_num = new Random();
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
                TotalEmpHr = TotalEmpHr * Emp_Hr;
               
                Console.WriteLine("Days:-" + TotalWorkingDays + "Employee Hrs:-" + Emp_Hr);
            }
            TotalEmpWage = TotalEmpHr + PerHrRate;
            Console.WriteLine("Monthly Employee Wage:-" + TotalEmpWage);
           return TotalEmpWage;
        }

    }
}
