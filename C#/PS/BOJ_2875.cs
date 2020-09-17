using System;

namespace FP
{
    class BOJ_2588
    {
        
        static void Main(String[] args)
        {
            String[] members = Console.ReadLine().Split(" ");
            int g = Int32.Parse(members[0]);
            int b = Int32.Parse(members[1]);
            int i = Int32.Parse(members[2]);
            
            while(i > 0)
            {
                if (g > b * 2) g--;
                else b--;
                i--;
            }

            int r = 0;
            while(true)
            {
                g -= 2;
                b -= 1;
                if (g < 0 || b < 0) break; 
                r++;
            }
            
            Console.WriteLine(r);
        }
    }
}
