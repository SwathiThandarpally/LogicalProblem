﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class ReverseNumber
    {
        public void DisplayReverse()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number is " + reverse);
        }
    }
}
