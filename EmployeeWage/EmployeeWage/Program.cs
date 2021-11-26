using System;
using EmployeeWage;
class Employeewage
{
    public static void Main()
    {
        Console.Write("*******Calculating Part Time Employee Wage:********\n");
        EmpWageCalculation empWageCalculation = new EmpWageCalculation();
        empWageCalculation.EmpWage();
        
    }
}