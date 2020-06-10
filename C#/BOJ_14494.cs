using System;

namespace FP
{
    class BOJ_14494
    {
        static int ex, ey;
        static long[,] dp;
        const int mod = 1000000007;
        static void Main(String[] args)
        {
            String[] init = Console.ReadLine().Split(" ");
            ex = int.Parse(init[0]);
            ey = int.Parse(init[1]);

            if (!(1 <= ex) || !(ey <= 1000))
            {
                return;
            }
            dp = new long[ex+1, ey+1];
            for(int i = 0; i <= ex; i++)
            {
                for(int j = 0; j <= ey; j++)
                {
                    dp[i, j] = -1;
                }
            }
            Console.WriteLine(ignition(1, 1) % mod);
            
        }

        static long ignition(int x, int y)
        {
            long sum = 0;

         
            if (x > ex || y > ey) return 0;
            if (x == ex && y == ey) return 1;
            if (dp[x, y] != -1) return dp[x, y];

            sum += ignition(x + 1, y);
            sum += ignition(x + 1, y + 1);
            sum += ignition(x, y + 1);
            return dp[x,y] = sum % mod;
        }
    }
}

