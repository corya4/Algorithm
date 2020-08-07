using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProcessOpen
{

    
    class FTPProcess : Process
    {

        List<String> host = new List<String>();

        public FTPProcess()
        {
            ProcessStartInfo info = new ProcessStartInfo("FTP.exe");
            info.UseShellExecute = false;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            
            base.EnableRaisingEvents = false;
            base.StartInfo = info;
 
            base.Start();

        }



        public void OrderCommend(String cmd)
        {

            using (base.StandardInput)
            {
                base.StandardInput.WriteLine(cmd);
            }

        }


        public String ResponString()
        {

            String ReturnCont;
            using (base.StandardOutput)
            {
                ReturnCont = base.StandardOutput.ReadLine();
            }

            return ReturnCont;
        }

/*
        public void Executor()
        {

            while (true)
            {
                    

                try
                {
                  // base.Start();

                    using (base.StandardInput)
                    {
                        base.StandardInput.WriteLine(host[0]);
                         Console.WriteLine(base.StandardOutput.ReadLine());
                        base.StandardInput.WriteLine(host[1]);
                         Console.WriteLine(base.StandardOutput.ReadLine());
                        base.StandardInput.WriteLine(host[2]);

                    }

                    using (base.StandardError)
                    {
                        String err = base.StandardError.ReadLine();
                        if (!String.IsNullOrWhiteSpace(err))
                        {
                            Console.WriteLine(err);
                        }
                    }

                    using (base.StandardOutput)
                    {
                        String line = base.StandardOutput.ReadLine();
                        Console.Write(line);
                    }


                } 
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    
                   // base.Close();
                }

            }

        }
        */
    }
}
