using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Threading;

namespace ProcessEx
{
    class Program
    {

        public static void Main(String[] args)
        {
            Process p = new Process();

            ini(p);
            
            String input;
            String path = "c:/";

            while (true)
            {
                p.StartInfo.WorkingDirectory = path;
                p.Start();

                input = Console.ReadLine();

                if (String.IsNullOrEmpty(input)) break;

                p.StandardInput.Write(input);
                p.StandardInput.Close();
                Console.WriteLine(p.StandardOutput.ReadToEnd());

                if (input.IndexOf("cd") == 0) path = input;

                p.Close();
            }

        }



        static void ini(Process p)
        {
            p.StartInfo.FileName = "cmd";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = false;
        }
    }
}
