﻿using System;
using EmployeeWage;
class Employeewage
{
    public static void Main()
    {
        Console.Write("*******Calculating Part Time Employee Wage using Switch Case:********\n");
        EmpWageCalculation empWageCalculation = new EmpWageCalculation();
        empWageCalculation.EmpWage();
        
    }
}