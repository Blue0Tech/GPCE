﻿using System;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace GPCEinstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("GPCEinstallationlog.txt"))
            {
                File.Delete("GPCEinstallationlog.txt");
            }
            var logtext = "Program successfully launched\n";
            File.AppendAllText("GPCEinstallationlog.txt", logtext);
            Console.WriteLine("Install GPCE? Y for yes: ");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                logtext = "Started installation of GPCE\n";
            File.AppendAllText("GPCEinstallationlog.txt", logtext);
                Console.WriteLine("Installing...\n");
                var GPCEdl = new WebClient();
                Console.WriteLine("Connected to internet...\n");
                logtext = "Connected to internet\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                byte[] GPCEzipdl = GPCEdl.DownloadData("https://github.com/Blue0Tech/GPCE/archive/master.zip");
                Console.WriteLine("Fetched information...\n");
                logtext = "Fetched information\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                File.WriteAllBytes("GPCE.zip", GPCEzipdl);
                Console.WriteLine("Downloaded GPCE...\n");
                logtext = "Downloaded GPCE\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                Console.WriteLine("Where do you want to install GPCE?");
                var installdir = Console.ReadLine();
                ZipFile.ExtractToDirectory("GPCE.zip", installdir);
                Console.WriteLine("Installed GPCE...\n");
                logtext = "Installed GPCE\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                if(Directory.Exists("GPCE"))
                {
                    Directory.Delete("GPCE");
                }
                Console.WriteLine("Cleaned up...\n");
                logtext = "Cleaned up\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                Directory.Move("GPCE-master", "GPCE");
                Console.WriteLine("Renamed directory to GPCE...\n");
                logtext = "Renamed directory to GPCE\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                File.Delete("GPCE.zip");
                Console.WriteLine("Deleted unnecessary packages...\n");
                logtext = "Deleted unnecessary packages\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
                Console.WriteLine("Successfully installed GPCE...\n");
                logtext = "Successfully installed GPCE\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
            } else
            {
                logtext = "Cancelled installation of GPCE\n";
                File.AppendAllText("GPCEinstallationlog.txt", logtext);
            }
            logtext = "Program successfully terminated\n";
            File.AppendAllText("GPCEinstallationlog.txt", logtext);
        }
    }
}