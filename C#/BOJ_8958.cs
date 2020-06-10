using System;

namespace FP
{
    class BOJ_2588
    {
        static void Main(String[] args)
        {
            int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine());
            int b_len = 1;
            int b_tmp = b;
            
            while (true)
            {
                if (b_tmp == 0) break;
                b_tmp /= 10;
                if (b_tmp != 0) b_len++;
            }
            
            int sum = 0;
            for(int i = 0; i < b_len; i++)
            {
                int b_cal = (b / (int)Math.Pow(10,i)) % 10;
                int calTmp = b_cal * a;
                Console.WriteLine(calTmp);
                sum += calTmp * (int)Math.Pow(10,i);
                
            }
            Console.WriteLine(sum);
        }
    }
}
