using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "cmd.exe";

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = "/c dotnet test";

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Optional
            pProcess.StartInfo.WorkingDirectory = "D:\\Projects\\xunittest1\\XUnitTestProject1";

            //Start the process
            pProcess.Start();

            //wait
            pProcess.WaitForExit();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            Console.WriteLine(strOutput);
        }
    }
}
