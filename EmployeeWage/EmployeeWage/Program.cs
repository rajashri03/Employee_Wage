﻿using System;
class Employeewage
{
    public static void Main()
    {
        int Fulltime = 1;
        Random random_num = new Random();
        int checkemp = random_num.Next(0, 2);
        if(checkemp == Fulltime)
        {
            Console.WriteLine("Employee Is Present");
        }
        else
        {
            Console.Write("Employee is Absent");
        }

    }
}