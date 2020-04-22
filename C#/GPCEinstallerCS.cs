using System;
using System.IO;
using System.Net;
using System.IO.Compression;
using static System.Console;

namespace GPCEinstaller
{
    class Program
    {
        private const string Path = "GPCEinstallationlog.txt";

        static void Main(string[] args)
        {
            try
            {
                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }
                var logtext = "Program successfully launched\n";
                File.AppendAllText(Path, logtext);
                WriteLine("Install GPCE (Note: GPCE will install in the working directory)? Y for yes: ");
                if (ReadKey().Key == ConsoleKey.Y)
                {
                    logtext = "Started installation of GPCE\n";
                    File.AppendAllText(Path, logtext);
                    WriteLine("Installing...\n");
                    var GPCEdl = new WebClient();
                    WriteLine("Connected to internet...\n");
                    logtext = "Connected to internet\n";
                    File.AppendAllText(Path, logtext);
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    byte[] GPCEzipdl = GPCEdl.DownloadData("http://github.com/Blue0Tech/GPCE/archive/master.zip");
                    WriteLine("Fetched information...\n");
                    logtext = "Fetched information\n";
                    File.AppendAllText(Path, logtext);
                    File.WriteAllBytes("GPCE.zip", GPCEzipdl);
                    WriteLine("Downloaded GPCE...\n");
                    logtext = "Downloaded GPCE\n";
                    File.AppendAllText(Path, logtext);
                    ZipFile.ExtractToDirectory("GPCE.zip", Directory.GetCurrentDirectory());
                    WriteLine("Installed GPCE...\n");
                    logtext = "Installed GPCE\n";
                    File.AppendAllText(Path, logtext);
                    if (Directory.Exists("GPCE"))
                    {
                        Directory.Delete("GPCE");
                    }
                    WriteLine("Cleaned up...\n");
                    logtext = "Cleaned up\n";
                    File.AppendAllText(Path, logtext);
                    Directory.Move("GPCE-master", "GPCE");
                    WriteLine("Renamed directory to GPCE...\n");
                    logtext = "Renamed directory to GPCE\n";
                    File.AppendAllText(Path, logtext);
                    File.Delete("GPCE.zip");
                    WriteLine("Deleted unnecessary packages...\n");
                    logtext = "Deleted unnecessary packages\n";
                    File.AppendAllText(Path, logtext);
                    File.Delete("GPCE/Python 3/GPCE.py");
                    File.Delete("GPCE/Python 3/license.txt");
                    File.Delete("GPCE/Python 3/tc.txt");
                    File.Delete("GPCE/Python 3/privacy.txt");
                    Directory.Delete("GPCE/Python 3");
                    File.Delete("GPCE/C#/GPCE.cs");
                    File.Delete("GPCE/C#/GPCEinstaller.exe");
                    File.Delete("GPCE/C#/GPCEinstaller.cs");
					File.Delete("GPCE/GPCEinstaller.exe");
					File.Delete("GPCE/index.html");
                    File.Copy("GPCE/C#/GPCE.exe","GPCE/GPCE.exe");
                    File.Copy("GPCE/C#/tc.txt","GPCE/tc.txt");
                    File.Copy("GPCE/C#/privacy.txt","GPCE/privacy.txt");
                    File.Copy("GPCE/C#/license.txt","GPCE/license.txt");
                    File.Delete("GPCE/C#/GPCE.exe");
                    File.Delete("GPCE/C#/tc.txt");
                    File.Delete("GPCE/C#/privacy.txt");
                    File.Delete("GPCE/C#/license.txt");
                    WriteLine("Freed up storage...\n");
                    logtext = "Freed up storage...\n";
                    File.AppendAllText(Path, logtext);
                    WriteLine("Successfully installed GPCE...\n");
                    logtext = "Successfully installed GPCE\n";
                    File.AppendAllText(Path, logtext);
                }
                else
                {
                    logtext = "Cancelled installation of GPCE\n";
                    File.AppendAllText(Path, logtext);
                }
                WriteLine("Press any key to exit, copyright 2019 Pruthvi Shrikaanth\n");
                ReadKey();
                logtext = "Program successfully terminated\n";
                File.AppendAllText(Path, logtext);
            } catch(Exception e)
            {
                WriteLine("There was an error. Press Y to see it.");
                if (ReadKey().Key == ConsoleKey.Y)
                    WriteLine(e.Message);
                File.AppendAllText(Path, e.Message);
            }
        }
    }
}
