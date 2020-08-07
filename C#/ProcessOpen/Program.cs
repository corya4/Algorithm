using System;

namespace ProcessOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            FTPProcess FP = new FTPProcess();

            String commend = "";

            while (!commend.Equals("exit"))
            {

                commend = Console.ReadLine();

                FP.OrderCommend(commend);
                Console.WriteLine(FP.ResponString());

            }

            FP.Close();
        }
    }
}
