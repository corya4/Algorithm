using System;
using System.Collections.Generic;

namespace FP
{
    class BOJ_1110
    {
        static void Main(String[] args)
        {
            int org = Convert.ToInt32(Console.ReadLine());

            if (!(0 <= org && org <= 99)) Environment.Exit(0);
            
            int front = 0; int end = 0; int temp = -1;
            int count = 0;
            
            while(org != temp)
            {
                if (count == 0) temp = org;

                front = temp / 10;
                end = temp % 10;
                temp = (end * 10) + (front + end)%10;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
