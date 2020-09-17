using System;
using System.Collections;
using System.Collections.Generic;

namespace FP
{
    class BOJ_1463
    {
        static int[] visited = new int[1000001];
        static void Main(String[] args)
        {
            int val = Convert.ToInt32(Console.ReadLine());
           // if (!(1 <= val && val <= Math.Pow(10, 6))) Environment.Exit(0);

            int count = devide(val);

            
            Console.WriteLine(count);
        }

        static int devide(int n)
        {
            int p = 1000000000;

            if(visited[n] != 0)
            {
                return visited[n];
            }

            if(n == 1)
            {
                return 0;
            }

            if(n%3 == 0)
            {
                p = devide(n / 3)+1;
            }

            if(n%2 == 0)
            {
                p = Math.Min(p, devide(n / 2) + 1);
            }

            p = Math.Min(p, devide(n - 1) + 1);

            return visited[n] = p;
            
        }
    }
}
