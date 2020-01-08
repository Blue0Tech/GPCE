/*GPCE (General Purpose Command Executor - a command line program which can be used for many purposes.*/
/*Copyright © 2019 Pruthvi Shrikaanth "Blue0Tech"*/
using System;
using System.Net;
using System.IO;
using System.IO.Compression;
using static System.IO.File;
using static System.Console;

namespace GPCE
{
    class GPCE
    {
        private const string seeError = "Press Y to see the error.";
        private const string cmdEx = " command successfully executed\n";
        private const string cmdEnt = " command entered\n";

        static void Main(string[] args)
        {
        	string logfilename = "GPCElog.txt";
            if (Exists(logfilename))
                Delete(logfilename);
            const string ProgramName = "General Purpose Command Executor", ExitMsg = "Terminating... Press any key to exit, Copyright 2019 Pruthvi Shrikaanth";
            string input, filecontent2;
            OperatingSystem osver = Environment.OSVersion;
            decimal num1, num2, ans;
            string currentdir = "C:\\";
            string filename1;
            string filecontent1;
            string url;
            WebClient fdl;
            string fdlname;
            string fdlcontent;
            string tc, privacy, license;
            string extractfilename, extractdir;
            string compressfolder, compressfilename;
            string logtext = "Program successfully launched\n";
            AppendAllText(logfilename, logtext);
            WriteLine("Welcome to {0}, type help for a list of commands, Copyright 2019 Pruthvi Shrikaanth", ProgramName);
        /*Main activity*/
        MainActivity:
            do
            {
                Write("GPCE >");
                input = ReadLine();
                switch (input)
                {
                	case "":
                	{
                		/*Do nothing*/
                	}
                	break;
                    case "help":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("help: Displays a list of commands and how to use them");
                            WriteLine("now: Displays the time and date");
                            WriteLine("exit: Exits {0}", ProgramName);
                            WriteLine("clear: Clears the screen");
                            WriteLine("pcname: Gets your computer name");
                            WriteLine("osver: Returns the operating system version that you are running");
                            WriteLine("sum: Gets the sum of two numbers, input one at a time.");
                            WriteLine("diff: Gets the difference of two numbers, input one at a time.");
                            WriteLine("prod: Gets the product of two numbers, input one at a time.");
                            WriteLine("div: Gets the quotient of one number divided by another, input one at a time.");
                            WriteLine("rem: Gets the remainder of one number divided by another, input one at a time.");
                            WriteLine("fwrite: Writes to a file. Type \\n for a new line, \\t for a tabspace, and \\\\ for a backslash. If the file doesn't exist, error is thrown.");
                            WriteLine("fdel: Deletes a file.");
                            WriteLine("fopen: Opens a file with the default program (only on Windows).");
                            WriteLine("ftype: Types the contents of a file.");
                            WriteLine("dir: Displays the path of the current directory that GPCE is running from.");
                            WriteLine("fdl: Downloads a file from the Web to a local file.");
                            WriteLine("contact: Shows contact details to contact me.");
                            WriteLine("tc: Displays the terms and conditions");
                            WriteLine("privacy: Displays the privacy policy");
                            WriteLine("license: Displays the license");
                            WriteLine("extract: Extract a zip to a directory");
                            WriteLine("compress: Compress a directory to a zip archive");
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "now":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            DateTime now = DateTime.Now;
                            WriteLine("Now, it is {0}", now);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "exit":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine(ExitMsg);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "clear":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            Clear();
                            WriteLine("Welcome to {0}, type help for a list of commands", ProgramName);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "osver":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("You are running {0}", osver);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "pcname":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                var pcname = Dns.GetHostName();
                                WriteLine("Your computer name is {0}", pcname);
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "sum":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 + num2;
                            WriteLine("The sum of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "diff":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 - num2;
                            WriteLine("The difference of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "prod":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 * num2;
                            WriteLine("The product of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "div":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(ReadLine());
                                ans = num1 / num2;
                            }
                            catch (DivideByZeroException e)
                            {
                                WriteLine("You cannot divide by zero.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("The quotient of {0} divided by {1} is {2}", num1, num2, ans);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "rem":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(ReadLine());
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(ReadLine());
                            }
                            catch (DivideByZeroException e)
                            {
                                WriteLine("You cannot divide by zero.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("You must enter a decimal number or integer.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 % num2;
                            WriteLine("The remainder of {0} divided by {1} is {2}", num1, num2, ans);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fwrite":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("File name? ");
                            filename1 = ReadLine();
                            try
                            {
                                filecontent2 = ReadAllText(filename1); /*To not allow the user to continue the program without checking for a valid file path*/
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("File content? ");
                            filecontent1 = ReadLine();
                            filecontent1 = filecontent1.Replace("\\\\", "\\");
                            filecontent1 = filecontent1.Replace("\\n", "\n");
                            filecontent1 = filecontent1.Replace("\\t", "\t");
                            WriteLine("Overwrite or append? O for overwrite ");
                            try {
                                if (ReadKey().Key == ConsoleKey.O)
                                    WriteAllText(filename1, filecontent1);
                                else
                                    AppendAllText(filename1, filecontent1);
                            }
                            catch (Exception e)
		                    {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fdel":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("File name? ");
                            filename1 = ReadLine();
                            try
                            {
                                Delete(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fopen":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("File name? ");
                            filename1 = ReadLine();
                            try
                            {
                                System.Diagnostics.Process.Start(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "ftype":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("File name? ");
                            filename1 = ReadLine();
                            try
                            {
                                filecontent1 = ReadAllText(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                WriteLine("You must enter a valid file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Write("{0}\n", filecontent1);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fcreate":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("File name and path? ");
                            filename1 = ReadLine();
                            try
                            {
                                if (Exists(filename1))
                                {
                                    WriteLine("File already exists. Replace it? Y for yes ");
                                    if (ReadKey().Key == ConsoleKey.Y)
                                        Delete(filename1);
                                    else
                                    {
                                        WriteLine("Aborted.");
                                        goto MainActivity;
                                    }
                                }
                                Create(filename1).Dispose();
                                WriteLine("File created.");
                            }
                            catch(Exception e)
                            {
                                WriteLine("Error. ");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "dir":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                currentdir = Directory.GetCurrentDirectory();
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            WriteLine("{0}", currentdir);
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "contact":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("Email: shrikaanthpruthvispareemail@gmail.com\nPhone: +447712343856\nWebsite: http://blue0tech.unaux.com/");
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fdl":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                WriteLine("Enter URL? ");
                                url = ReadLine();
                                fdl = new WebClient();
                                fdlcontent = fdl.DownloadString(url);
                                WriteLine("Enter filename? ");
                                fdlname = ReadLine();
                                WriteAllText(fdlname, fdlcontent);
                            }
                            catch (HttpListenerException e)
                            {
                                WriteLine("Could not connect to the Internet. Please check your connection and the url entered was correct.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                {
                                    WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                WriteLine("Please check the file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                WriteLine("Please check the file name and path.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "tc":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                tc = ReadAllText("tc.txt");
                                WriteLine(tc);
                            } 
                            catch(Exception e)
                            {
                                WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "privacy":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                privacy = ReadAllText("privacy.txt");
                                WriteLine(privacy);
                            } 
                            catch(Exception e)
                            {
                                WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "license":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            try
                            {
                                license = ReadAllText("license.txt");
                                WriteLine(license);
                            } 
                            catch(Exception e)
                            {
                                WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                        case "extract":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("Archive file name? ");
                    		extractfilename = ReadLine();
                            WriteLine("Archive extraction destination directory? ");
                    		extractdir = ReadLine();
                    		try {
                    			ZipFile.ExtractToDirectory(extractfilename,extractdir);
                    		} catch(Exception e) {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y) WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "compress":
                        {
                            logtext = input + cmdEnt;
                            AppendAllText(logfilename, logtext);
                            WriteLine("Directory to compress? ");
                            compressfolder = ReadLine();
                            WriteLine("Archive file name? ");
                            compressfilename = ReadLine();
                            try
                            {
                                ZipFile.CreateFromDirectory(compressfolder, compressfilename);
                            }
                            catch (Exception e)
                            {
                                WriteLine("Unknown error.");
                                WriteLine(seeError);
                                if (ReadKey().Key == ConsoleKey.Y)
                                    WriteLine(e.Message);
                                logtext = e.Message + "\n";
                                AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + cmdEx;
                            AppendAllText(logfilename, logtext);
                        }
                        break;
                    default:
                        {
                            WriteLine("{0} is not a valid command", input);
                        }
                        break;
                }
            } while (input != "exit");
            ReadKey(true);
            logtext = "Program successfully terminated";
            AppendAllText(logfilename, logtext);
        }
    }
}
