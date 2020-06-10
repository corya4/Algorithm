using System;


namespace FP
{
    class BOJ_1330
    {
        static void main(String[] args)
        {
            String[] iTmp = Console.ReadLine().Split(" ");
            String calc = "";

            if (Convert.ToInt32(iTmp[0]) < Convert.ToInt32(iTmp[1]))
            {
                calc = "<";
            }
            else if (Convert.ToInt32(iTmp[0]) > Convert.ToInt32(iTmp[1]))
            {
                calc = ">";
            }
            else
            {
                calc = "=";
            }

            Console.WriteLine(calc);
        }
    }
}
